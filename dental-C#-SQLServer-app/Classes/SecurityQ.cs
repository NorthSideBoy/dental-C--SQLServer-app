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

        public static void SaveRecoveryToken(int userID, string token, DateTime expirationDate)
        {
            string query = @"
        INSERT INTO PasswordRecovery (UserID, Token, ExpirationDate)
        VALUES (@UserID, @Token, @ExpirationDate)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@UserID", userID);
                    command.Parameters.AddWithValue("@Token", token);
                    command.Parameters.AddWithValue("@ExpirationDate", expirationDate);
                    command.ExecuteNonQuery();
                }
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

        public static void SaveSecurityQuestions(int userID, string[] questions, string[] answers)
        {
            string query = @"
    INSERT INTO UserSecurityQuestions (UserID, SecurityQuestion, SecurityAnswer)
    VALUES (@UserID, @SecurityQuestion, @SecurityAnswer)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                for (int i = 0; i < questions.Length; i++)
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@UserID", userID);
                        command.Parameters.AddWithValue("@SecurityQuestion", questions[i]);
                        command.Parameters.AddWithValue("@SecurityAnswer", Encriptacion.EncripPass.HashPassword(answers[i]));
                        command.ExecuteNonQuery();
                    }
                }
            }
        }
    }
}
