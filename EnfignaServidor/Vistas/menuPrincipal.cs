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
        jugadorDAO DAOdeJugador = new jugadorDAO(conexion);
        private Jugador usuarioActual;


        public menuPrincipal(Jugador usuario)
        {
            InitializeComponent();
            this.usuarioActual = usuario;

            labelusuario.Text = this.usuarioActual.usuario;
            labelDinero.Text = this.usuarioActual.dinero.ToString();
            labelHalo.Text = this.usuarioActual.halo.ToString();
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
            modalidad pantallSeleccionarModo = new modalidad(usuarioActual);

            pantallSeleccionarModo.Show();
            this.Close();
        }
    }
}
