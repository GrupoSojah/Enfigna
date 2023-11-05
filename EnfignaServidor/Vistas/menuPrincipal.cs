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
    public partial class menuPrincipal : Form
    {
   
        static conexionBD conexion = new conexionBD();
        Jugador usuarioActual = new Jugador();
        jugadorDAO DAOdeJugador = new jugadorDAO(conexion);


        public menuPrincipal(Jugador usuario)
        {
            InitializeComponent();
            this.usuarioActual = usuario;

            usuarioActual = DAOdeJugador.recuperarDatosdelUsuario();

            labelusuario.Text = usuarioActual.usuario;
            labelDinero.Text = usuarioActual.dinero.ToString();
            labelHalo.Text = usuarioActual.halo.ToString() ;
        }

        private void button_mazo_Click(object sender, EventArgs e)
        {

        }

        private void button_tienda_Click(object sender, EventArgs e)
        {
            Tienda PantallaTienda = new Tienda();

            PantallaTienda.Show();

            this.Close();
        }

        private void button_play_Click(object sender, EventArgs e)
        {
            modalidad pantallSeleccionarModo = new modalidad();

            pantallSeleccionarModo.Show();

            this.Close();
        }
    }
}
