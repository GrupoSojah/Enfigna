using EnfignaServidor.Modelo;
using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace EnfignaServidor.DAO
{
    internal class cartaDAO
    {
        conexionBD conexion = new conexionBD();
        
        //recuperaIdMazos por id de jugador

        public ArrayList recuperarMazos(int idJugador)
        {
            ArrayList mazosRecuperados = new ArrayList();

            string recuperarMazosQuery = "SELECT m.* FROM mazo AS m \r\n" +
                "INNER JOIN jugador_has_mazo AS jhm ON m.idMazo = jhm.Mazo_idMazo\r\n" +
                "INNER JOIN jugador AS j ON j.idJugador = jhm.Jugador_idJugador\r\n" +
                "WHERE j.idJugador = @idJugador";

            using (MySqlConnection connection = conexion.establecerConexion())
            {
                using (MySqlCommand comandoRecuperarMazos = new MySqlCommand(recuperarMazosQuery, connection))
                {
                    comandoRecuperarMazos.Parameters.AddWithValue("@idJugador", idJugador);

                    try
                    {
                        using (MySqlDataReader lector = comandoRecuperarMazos.ExecuteReader())
                        {
                            while (lector.Read())
                            {
                                string nombreID = lector["nombre"].ToString();

                                mazosRecuperados.Add(nombreID);

                            }
                        }
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show("Error al recuperar mazos: " + ex.Message);
                    }
                }
            }
            return mazosRecuperados;
        }

        //recuperaCartasDeLosMazos
        public ArrayList recuperarCartasDelJugador(string Nombremazo) { 
            ArrayList cartasRecuperadas = new ArrayList();

            string recuperarCartasQuery = "SELECT c.* FROM carta AS c  " +
                "INNER JOIN carta_has_mazo AS chm on c.numeroDeCarta = chm.Carta_numeroDeCarta " +
                "INNER JOIN  mazo AS m ON chm.Mazo_idMazo = m.idMazo  " +
                "INNER JOIN jugador_has_mazo AS jhm on m.idMazo = jhm.Mazo_idMazo " +
                "INNER JOIN jugador as j ON j.idJugador = " + " jhm.Jugador_idJugador " +
                "WHERE m.nombre = @nombreMazo";

            using (MySqlConnection connection = conexion.establecerConexion()) {
                using (MySqlCommand comandoRecuperarCartas = new MySqlCommand(recuperarCartasQuery, connection)) {
                    comandoRecuperarCartas.Parameters.AddWithValue("@nombreMazo", Nombremazo);

                    try
                    {
                        using (MySqlDataReader lector = comandoRecuperarCartas.ExecuteReader())
                        {
                            while (lector.Read()) {
                                if (lector["Tipo"] == "Criatura")
                                {
                                    

                                    criatura cartaCriatura = new criatura(Convert.ToInt32(lector["numeroCarta"]), lector["nombre"].ToString(), Convert.ToInt32(lector["coste"]), imagen: null, Convert.ToInt32(lector["Ataque"]), Convert.ToInt32(lector["Vida"]));


                                    cartasRecuperadas.Add(cartaCriatura);
                                }
                                else {
                                    //incorporar la iamgen tambien, no se como hacerlo.
                                    hechizo cartaHechizo = new hechizo(Convert.ToInt32(lector["numeroCarta"]), lector["nombre"].ToString(), Convert.ToInt32(lector["coste"]), null, Convert.ToInt32(lector["Efecto"]));

                                    cartasRecuperadas.Add(cartaHechizo);
                                
                                }
                            }
                        }

                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show("Nose pudo obtener las cartas del usuario, error:" + ex);
                    }
                }
            }
            return cartasRecuperadas;
        }  
    }
}