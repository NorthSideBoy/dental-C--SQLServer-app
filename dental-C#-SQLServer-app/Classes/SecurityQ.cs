using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace dental_C__SQLServer_app.Classes
{
    internal class SecurityQ
    {
        private static string connectionString;

        // Método para guardar preguntas y respuestas de seguridad
        public static void SaveSecurityQuestions(int userId, string[] preguntas, string[] respuestas)
        {
            if (preguntas.Length != respuestas.Length)
            {
                throw new ArgumentException("El número de preguntas y respuestas no coincide.");
            }

            string connectionString = "Server=localhost;Database=histodent;Trusted_Connection=True;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlTransaction transaction = connection.BeginTransaction())
                {
                    try
                    {
                        for (int i = 0; i < preguntas.Length; i++)
                        {
                            string query = @"
                        INSERT INTO UserSecurityQuestions (UserId, SecurityQuestion, SecurityAnswer)
                        VALUES (@UserId, @SecurityQuestion, @SecurityAnswer)";

                            using (SqlCommand command = new SqlCommand(query, connection, transaction))
                            {
                                command.Parameters.AddWithValue("@UserId", userId);
                                command.Parameters.AddWithValue("@SecurityQuestion", preguntas[i]);
                                command.Parameters.AddWithValue("@SecurityAnswer", respuestas[i]);

                                command.ExecuteNonQuery();
                            }
                        }

                        transaction.Commit();
                    }
                    catch
                    {
                        transaction.Rollback();
                        throw; // Vuelve a lanzar la excepción para manejarla en el nivel superior
                    }
                }
            }
        }
        public static bool VerifySecurityAnswers(int userID, string[] providedAnswers)
        {
            string query = @"
        SELECT SecurityAnswer1, SecurityAnswer2, SecurityAnswer3
        FROM Users
        WHERE UserID = @UserID";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@UserID", userID);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string storedAnswer1 = reader["SecurityAnswer1"].ToString();
                            string storedAnswer2 = reader["SecurityAnswer2"].ToString();
                            string storedAnswer3 = reader["SecurityAnswer3"].ToString();

                            // Encripta las respuestas proporcionadas y compáralas
                            string hashedProvidedAnswer1 = Encriptacion.EncripPass.HashPassword(providedAnswers[0]);
                            string hashedProvidedAnswer2 = Encriptacion.EncripPass.HashPassword(providedAnswers[1]);
                            string hashedProvidedAnswer3 = Encriptacion.EncripPass.HashPassword(providedAnswers[2]);

                            return hashedProvidedAnswer1 == storedAnswer1 &&
                                   hashedProvidedAnswer2 == storedAnswer2 &&
                                   hashedProvidedAnswer3 == storedAnswer3;
                        }
                    }
                }
            }
            return false;
        }

        public static string GenerateRecoveryToken() // se genera un token único
        {
            using (var rng = new RNGCryptoServiceProvider())
            {
                var tokenData = new byte[32];
                rng.GetBytes(tokenData);
                return Convert.ToBase64String(tokenData);
            }
        }

        public static void SaveRecoveryToken(int iD, string token, DateTime expirationDate)
        {
            string query = @"
            INSERT INTO PasswordRecovery (UserID, Token, ExpirationDate)
            VALUES (@UserID, @Token, @ExpirationDate)";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@UserID", iD);
                        command.Parameters.AddWithValue("@Token", token);
                        command.Parameters.AddWithValue("@ExpirationDate", expirationDate);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (SqlException sqlEx)
            {
                // Manejo de errores específicos de SQL
                MessageBox.Show("Error de SQL: " + sqlEx.Message);
            }
            catch (Exception ex)
            {
                // Manejo de errores generales
                MessageBox.Show("Ocurrió un error: " + ex.Message);
            }
        }

        public static bool ValidateRecoveryToken(string token)
        {
            string query = @"
        SELECT UserID
        FROM PasswordRecovery
        WHERE Token = @Token
        AND ExpirationDate > GETDATE()
        AND IsUsed = 0";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Token", token);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        return reader.HasRows; // True si el token es válido
                    }
                }
            }
        }

        public static void MarkTokenAsUsed(string token)
        {
            string query = @"
        UPDATE PasswordRecovery
        SET IsUsed = 1
        WHERE Token = @Token";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Token", token);
                    command.ExecuteNonQuery();
                }
            }
        }

        public static List<string> GetPredefinedSecurityQuestions()
        {
            return new List<string>
    {
        "¿Cuál es el nombre de tu mascota?",
        "¿Cuál es tu ciudad de nacimiento?",
        "¿Cuál es tu comida favorita?",
        "¿Cuál es el nombre de tu primer profesor?",
        "¿Cuál es el nombre de tu mejor amigo de la infancia?"
    };
        }
    }
    public static class DatabaseConnection
    {
        private static string connectionString;

        public static void SetConnectionString(string server, string database, string id, string password)
        {
            var builder = new SqlConnectionStringBuilder
            {
                DataSource = server,
                InitialCatalog = database,
                UserID = id,
                Password = password,
                IntegratedSecurity = false // Cambia a true si usas autenticación de Windows
            };

            connectionString = builder.ConnectionString;
        }

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}
