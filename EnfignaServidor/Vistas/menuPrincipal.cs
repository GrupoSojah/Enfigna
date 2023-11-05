using EnfignaServidor.DAO;
using EnfignaServidor.Modelo;
using System;
using System.Collections;
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

        string seleccion = "";
        static conexionBD conexion = new conexionBD();
        jugadorDAO DAOdeJugador = new jugadorDAO(conexion);
        private Jugador usuarioActual;
        cartaDAO gestionCartas = new cartaDAO();


        public menuPrincipal(Jugador usuario)
        {
            InitializeComponent();
            this.usuarioActual = usuario;

            int idUsuario = DAOdeJugador.recuperarIDUsuario(usuarioActual);

            labelusuario.Text = this.usuarioActual.usuario;
            labelDinero.Text = this.usuarioActual.dinero.ToString();
            labelHalo.Text = this.usuarioActual.halo.ToString();

            ArrayList mazosCombobox = new ArrayList();

            mazosCombobox = gestionCartas.recuperarMazos(idUsuario);

            comboBoxMazos.Items.AddRange(mazosCombobox.ToArray());

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
            seleccion = comboBoxMazos.SelectedItem.ToString();

            modalidad pantallSeleccionarModo = new modalidad(usuarioActual, seleccion);

            pantallSeleccionarModo.Show();
            this.Close();
        }
    }
}
