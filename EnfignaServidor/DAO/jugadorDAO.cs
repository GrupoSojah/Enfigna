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

        /*
        public void CrearSala(TextBox nombreSala,TextBox contraseña) {
            Jugador usuario = new Jugador();
            crearSala sala = new crearSala();

            string crearSalaQuery = "";

            if (contraseña.Text == "") {
                crearSalaQuery = "INSERT INTO partida (usuarioCreador, Nombrepartida, tipoPartida)" +
                "VALUES ('" + usuario.usuario + "', '" + nombreSala.Text + "','" + "Publica" + "')";
            } else { 
                crearSalaQuery = "INSERT INTO partida (usuarioCreador, Nombrepartida,Contraseñapartida, tipoPartida)" +
                "VALUES ('" + usuario.usuario + "','"+contraseña.Text+"', '" + nombreSala.Text + "','" + "Privada" + "')";
            }

            try {

                MySqlCommand comandoCrearSala = new MySqlCommand(crearSalaQuery, conexion.establecerConexion());

                MySqlDataReader lector = comandoCrearSala.ExecuteReader();

                if (lector.Read())
                {
                    idUsuario = lector.GetInt32("idUsuario");
                }

                conexion.cerrarConexion();
            }
            catch (Exception ex) {
                MessageBox.Show("No se creo la sala, error:" + ex);

            }
        }

       */


        /*
        public int recuperarIDUsuario()
        {
            conexionBD conexion = new conexionBD();
            Jugador player = new Jugador();
            int idUsuario = 0;

            string recuperarUsuarioQuery = "SELECT idUsuario FROM usuario WHERE usuario = '" + player.usuario + "'";

            try { 
                MySqlCommand comandoIdUsuario = new MySqlCommand(recuperarUsuarioQuery, conexion.establecerConexion());

                MySqlDataReader lector = comandoIdUsuario.ExecuteReader();

                if (lector.Read()) {
                }
                conexion.cerrarConexion();
            }
            catch(Exception ex)
            {
                MessageBox.Show("La verda no funciona, error: "+ ex);
            }

            return idUsuario; 
        }
        */



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
