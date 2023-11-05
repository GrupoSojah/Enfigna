using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnfignaServidor.DAO
{
    internal class mazoDAO
    {
        conexionBD conexion = new conexionBD();

        public int IDMazoDeJugador(int jugador)
        {

            int idmazo = -1;


            string recuperarIdMazoQuery = "SELECT Mazo_idMazo FROM jugador_has_nazo WHERE Jugador_idJugador = @idJugador";


            using (MySqlConnection connection = conexion.establecerConexion())
            {

                using (MySqlCommand comandoidMazoJugador = new MySqlCommand(recuperarIdMazoQuery, connection))
                {

                    //Incluir parametros
                    comandoidMazoJugador.Parameters.AddWithValue("@idJugador", jugador);

                    try
                    {
                        using (MySqlDataReader lector = comandoidMazoJugador.ExecuteReader())
                        {

                            if (lector.Read())
                            {
                                idmazo = lector.GetInt32("Mazo_idMazo");
                            }
                        }
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show("No se recupero de manera correcta el idMazo" + ex);
                    }
                }

            }
            return idmazo;
        }
    }
}