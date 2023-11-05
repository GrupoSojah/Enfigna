using EnfignaServidor.DAO;
using EnfignaServidor.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnfignaServidor.Vistas
{
    public partial class registro : Form
    {

        public registro()
        {

            InitializeComponent();
            /*
            jugadorDAO mostrar = new jugadorDAO(conexion);

            mostrar.mostrarUsuarios(dgvUsuarios);
            */
        }


        private void buttonEntrarJuego_Click(object sender, EventArgs e)
        {

            using (conexionBD conexion = new conexionBD())
            {
                jugadorDAO daoDeJugador = new jugadorDAO(conexion);

                if (daoDeJugador.entrarJuego(inputUsuario, inputPassword))
                {
                    Jugador usuario = daoDeJugador.recuperarDatosdelUsuario();

                    menuPrincipal menu = new menuPrincipal(usuario);
                    menu.Show();

                    this.Close();
                }
                else
                {
                    MessageBox.Show("No se pudo iniciar sesión");
                }
            }
        }
    }
}

/*
private void buttonCrearCuenta_Click(object sender, EventArgs e)
{
   jugadorDAO insertaJugador = new jugadorDAO(conexion);
   int halo = 1500;

   insertaJugador.CrearCuenta(inputUsuario, inputPassword, halo);
}

private void dgvUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
{

}
*/
