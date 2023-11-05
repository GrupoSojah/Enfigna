using EnfignaServidor.Modelo;
using EnfignaServidor.Vistas;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnfignaServidor.DAO
{
    internal class jugadorDAO
    {
        public conexionBD conexion = new conexionBD();
        public string nombreUsuario;

        public jugadorDAO(conexionBD conexion)
        {
            this.conexion = conexion;
        }



        public bool entrarJuego(TextBox usuario, TextBox contraseña)
        {
            bool accesoPermitido = false;

            string validacionInicioSesionQUERY = "SELECT COUNT(*) FROM jugador WHERE usuario = @usuario AND contrasenia = @contraseña";

            using (MySqlConnection connection = conexion.establecerConexion())
            {
                using (MySqlCommand comandoValidacion = new MySqlCommand(validacionInicioSesionQUERY, connection))
                {
                    comandoValidacion.Parameters.AddWithValue("@usuario", usuario.Text);
                    comandoValidacion.Parameters.AddWithValue("@contraseña", contraseña.Text);

                    try
                    {
                        int count = Convert.ToInt32(comandoValidacion.ExecuteScalar());

                        if (count > 0)
                        {
                            accesoPermitido = true;
                            nombreUsuario = usuario.Text;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("No se pudo iniciar sesión, error: " + ex);
                    }
                }
            }
            return accesoPermitido;
        }


        public Jugador recuperarDatosdelUsuario()
        {
            Jugador usuario = new Jugador();
       
            string recuperarDatosQuery = "SELECT * FROM jugador WHERE Usuario = @usuario";

            using (MySqlConnection connection = conexion.establecerConexion())
            {
                using (MySqlCommand comandoRecuperar = new MySqlCommand(recuperarDatosQuery, connection))
                {
                    comandoRecuperar.Parameters.AddWithValue("@usuario", nombreUsuario);

                    try
                    {
                        using (MySqlDataReader lector = comandoRecuperar.ExecuteReader())
                        {
                            if (lector.Read())
                            {
                                usuario.usuario = lector["Usuario"].ToString();
                                usuario.dinero = Convert.ToInt32(lector["Dinero"]);
                                usuario.halo = Convert.ToInt32(lector["Halo"]);

                                MessageBox.Show("Usuario: " + usuario.usuario + "\nDinero: " + usuario.dinero + "\nHalo: " + usuario.halo, "Resultados de la consulta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            return usuario;
                        }
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show("Error al recuperar datos del usuario. Código de error: " + ex.Number + "\nMensaje de error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return null;
                    }
                }
            }
        }


        public bool CrearSala(TextBox nombreSala,TextBox contraseña,Jugador usuario) {

            bool insertaSala = false;

                string crearSalaQuery = "";

            if (contraseña.Text == "") {
                crearSalaQuery = "INSERT INTO partida (usuarioCreador, Nombrepartida, tipoPartida)" +
                "VALUES (@usuario, @nombresala, @contraseña, @tipoPartida)";
            } else { 
                crearSalaQuery = "INSERT INTO partida (usuarioCreador, Nombrepartida,Contraseñapartida, tipoPartida)" +
                "VALUES (@usuario, @nombresala, @contraseña, @tipoPartida)";
            }

            using (MySqlConnection connection = conexion.establecerConexion()) {
                using (MySqlCommand comandoCrearSala = new MySqlCommand(crearSalaQuery, connection)) {

                    comandoCrearSala.Parameters.AddWithValue("@usuario", usuario.usuario);
                    comandoCrearSala.Parameters.AddWithValue("@nombresala", nombreSala.Text);
                    comandoCrearSala.Parameters.AddWithValue("@tipoPartida", contraseña.Text == "" ? "Publica" : "Privada");
                    if (contraseña.Text != "") {
                        comandoCrearSala.Parameters.AddWithValue("@contraseña", contraseña.Text);
                    }

                    try {
                       comandoCrearSala.ExecuteNonQuery();
                        insertaSala = true;
                    }
                    catch (MySqlException ex) {
                        MessageBox.Show("No se pudo insertar Correctamente en la base de datos, error: " + ex);
                    
                    }
                }
            }
            return insertaSala;
        }



        public int recuperarIDUsuario(Jugador player)
        {
            int idUsuario = -1;

            string recuperarUsuarioQuery = "SELECT idUsuario FROM usuario WHERE usuario = @usuario";

            using (MySqlConnection connection = conexion.establecerConexion())
            {
                using (MySqlCommand comandoIdUsuario = new MySqlCommand(recuperarUsuarioQuery, connection))
                {
                    comandoIdUsuario.Parameters.AddWithValue("@usuario", player.usuario);

                    try
                    {
                        using (MySqlDataReader lector = comandoIdUsuario.ExecuteReader())
                        {
                            if (lector.Read())
                            {
                                idUsuario = lector.GetInt32("idUsuario");
                            }
                        }
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show("Ocurrió un error al recuperar el ID del usuario: " + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            return idUsuario;
        }



        /*
        public void CrearCuenta(TextBox usuario, TextBox password, int halo)
        {
            try
            {
                string crearCuentaQuery = "INSERT INTO usuario (usuario, password, halo) VALUES (@usuario, @password, @halo)";
                using (MySqlCommand comando = new MySqlCommand(crearCuentaQuery, conexion.establecerConexion())
                { 
                    comando.Parameters.AddWithValue("@usuario", usuario.Text);
                    comando.Parameters.AddWithValue("@password", password.Text);
                    comando.Parameters.AddWithValue("@halo", halo);

                    comando.ExecuteNonQuery();

                    MessageBox.Show("Cuenta creada exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al crear la cuenta: " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        */

        /*
        public void mostrarUsuarios(DataGridView tablausuarios)
        {

            try
            {
                conexionBD conexion = new conexionBD();

                string MostrarQuery = "select * From usuario ";

                tablausuarios.DataSource = null;
                MySqlDataAdapter adaptador = new MySqlDataAdapter(MostrarQuery, conexion.establecerConexion());
                DataTable dt = new DataTable();
                adaptador.Fill(dt);

                tablausuarios.DataSource= dt;

                conexion.cerrarConexion();


            }
            catch (Exception ex)
            {
                MessageBox.Show("kliao Feo malo no se muestran los usuarios , error:" + ex.ToString());
            }
        }
        */

    }
}
