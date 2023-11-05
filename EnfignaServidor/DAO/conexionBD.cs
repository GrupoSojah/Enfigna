using System;
using MySql.Data.MySqlClient;

namespace EnfignaServidor.DAO
{
    internal class conexionBD : IDisposable
    {
        private MySqlConnection bdConexion = new MySqlConnection();
        private bool disposed = false;

        static string servidor = "localhost";
        static string puerto = "3306";
        static string userId = "root";
        static string password = "admin";
        static string baseDatos = "juegocartas";

        string cadenaDeConexion = "server=" + servidor + ";" + "port=" + puerto + ";" +
            "user id=" + userId + ";" + "password=" + password + ";" + "database=" + baseDatos + ";";

        public MySqlConnection establecerConexion()
        {
            try
            {
                bdConexion.ConnectionString = cadenaDeConexion;
                bdConexion.Open();
                // MessageBox.Show("Conexión establecida");
            }

            catch (MySqlException ex)
            {
                 MessageBox.Show("Error al establecer la conexión: " + ex.ToString());
            }

            return bdConexion;
        }

        public void cerrarConexion()
        {
            bdConexion.Close();
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    // Liberar recursos no administrados aquí, por ejemplo, cerrar la conexión.
                    cerrarConexion();
                }
                disposed = true;
            }
        }
    }
}
