using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace dental_C__SQLServer_app.Classes
{
    public class Factura
    {
        private string connectionString = "Server=localhost;Database=Histodent;Integrated Security=True;";

        public void GuardarFactura(Facturas factura)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlTransaction transaction = conn.BeginTransaction();

                try
                {
                    // Insertar la factura
                    string query = "INSERT INTO Facturas (patientsID, FechaFactura, Total) VALUES (@patientsID, @FechaFactura, @Total); SELECT SCOPE_IDENTITY();";
                    SqlCommand cmd = new SqlCommand(query, conn, transaction);
                    cmd.Parameters.AddWithValue("@patientsID", factura.patientsID);
                    cmd.Parameters.AddWithValue("@FechaFactura", factura.FechaFactura);
                    cmd.Parameters.AddWithValue("@Total", factura.Total);
                    int facturaID = Convert.ToInt32(cmd.ExecuteScalar());

                    // Insertar los detalles de la factura
                    foreach (var detalle in factura.Detalles)
                    {
                        query = "INSERT INTO DetalleFactura (FacturaID, ServicesID, Cantidad, PrecioUnitario, Subtotal) VALUES (@FacturaID, @ServicesID, @Cantidad, @PrecioUnitario, @Subtotal)";
                        cmd = new SqlCommand(query, conn, transaction);
                        cmd.Parameters.AddWithValue("@FacturaID", facturaID);
                        cmd.Parameters.AddWithValue("@ServicesID", detalle.ServicesID);
                        cmd.Parameters.AddWithValue("@Cantidad", detalle.Cantidad);
                        cmd.Parameters.AddWithValue("@PrecioUnitario", detalle.PrecioUnitario);
                        cmd.Parameters.AddWithValue("@Subtotal", detalle.Subtotal);
                        cmd.ExecuteNonQuery();
                    }

                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    throw ex;
                }
            }
        }
    }

    public class patients
    {
        public int patientsID { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Cedula { get; set; }
        public string FechaDeNacimiento { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        public DateTime FechaRegistro { get; set; }
    }

    public class Services
    {
        public int ServicesID { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public decimal Precio { get; set; }
    }

    public class Facturas
    {
        public int FacturaID { get; set; }
        public int patientsID { get; set; }
        public DateTime FechaFactura { get; set; }
        public decimal Total { get; set; }

        // Inicializa la lista de detalles en el constructor
        public List<DetalleFactura> Detalles { get; set; } = new List<DetalleFactura>();
    }

    public class DetalleFactura
    {
        public int DetalleFacturaID { get; set; }
        public int FacturaID { get; set; }
        public int ServicesID { get; set; }
        public int Cantidad { get; set; }
        public decimal PrecioUnitario { get; set; }
        public decimal Subtotal { get; set; }
    }
}
