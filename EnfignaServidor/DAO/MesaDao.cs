using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnfignaServidor.DAO
{
    internal class MesaDao
    {
        conexionBD conexion = new conexionBD();

        public MesaDao(conexionBD conexion) {
            this.conexion = conexion;
        }

        public string RecuperarInfoDelJugador1() {
            string criatura1 = "";
            string recuperarCriatura1 = "SELECT Criatura1 FROM mesa";

            using (MySqlConnection conneccion = conexion.establecerConexion()) {

                using (MySqlCommand comando = new MySqlCommand(recuperarCriatura1, conneccion)) {

                    try
                    {
                        using (MySqlDataReader lector = comando.ExecuteReader())
                        {
                            if (lector.Read())
                            {
                                criatura1 = lector["Criatura1"].ToString();



                            }
                            return criatura1;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("No se pudo encontrar la criatura" + ex);
                    }



                    return criatura1;

                }
            }

        }

        public string RecuperarInfoDelJugador2()
        {
            string criatura1 = "";
            string recuperarCriatura1 = "SELECT Criatura2 FROM Mesa";

            using (MySqlConnection conneccion = conexion.establecerConexion())
            {

                using (MySqlCommand comando = new MySqlCommand(recuperarCriatura1, conneccion))
                {

                    try
                    {
                        using (MySqlDataReader lector = comando.ExecuteReader())
                        {
                            if (lector.Read())
                            {
                                criatura1 = lector["Criatura2"].ToString();



                            }
                            return criatura1;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("No se pudo encontrar la criatura" + ex);
                    }



                    return criatura1;

                }
            }

        }



        public bool crearCriatura1(int vidaJ1, int vidaCJ1, int ataqueCJ1) {
            bool creoCriatura1 = false;
            string crearCriatura1 = vidaJ1.ToString() + "&" + vidaCJ1.ToString() + "&" + ataqueCJ1.ToString();
            string crearSalaQuery = "INSERT INTO Mesa (Criatura1)" +
               "VALUES (@criatura1)";

            using (MySqlConnection connection = conexion.establecerConexion())
            {
                using (MySqlCommand comandoCrearCriatura = new MySqlCommand(crearSalaQuery, connection))
                {


                    comandoCrearCriatura.Parameters.AddWithValue("@criatura1", crearCriatura1);
                    try
                    {
                        comandoCrearCriatura.ExecuteNonQuery();
                        creoCriatura1 = true;
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show("No se pudo crear la criatura: " + ex);

                    }
                }
            }
            return creoCriatura1;
        }



        public bool crearCriatura2(int vidaJ2, int vidaCJ2, int ataqueCJ2)
        {
            bool creoCriatura2 = false;
            string crearCriatura2 = vidaJ2.ToString() + "&" + vidaCJ2.ToString() + "&" + ataqueCJ2.ToString();
            string crearSalaQuery = "INSERT INTO Mesa (Criatura2)" +
               "VALUES (@criatura2)";

            using (MySqlConnection connection = conexion.establecerConexion())
            {
                using (MySqlCommand comandoCrearCriatura = new MySqlCommand(crearSalaQuery, connection))
                {


                    comandoCrearCriatura.Parameters.AddWithValue("@criatura1", crearCriatura1);
                    try
                    {
                        comandoCrearCriatura.ExecuteNonQuery();
                        creoCriatura2 = true;
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show("No se pudo crear la criatura: " + ex);

                    }
                }
            }
            return creoCriatura2;
        }

    

    }
}
