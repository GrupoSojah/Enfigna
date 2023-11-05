using EnfignaServidor.DAO;
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
    public partial class crearSala : Form
    {
        private string nombreMazo;
        ArrayList cartasDelJugador = new ArrayList();
        cartaDAO gestionCartas = new cartaDAO();
        public crearSala(string NombreDemazo)
        {
            InitializeComponent();
            this.nombreMazo = NombreDemazo;

        }

        private void buton_CrearSala_Load(object sender, EventArgs e)
        {

        }


        private void buttonCrearSala_Click(object sender, EventArgs e)
        {
            cartasDelJugador = gestionCartas.recuperarCartasDelJugador(nombreMazo);


            //jugadorCreador.CrearSala(textBoxNombreSala, textBoxContaseña);

        }

        private void checkBox_privada_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_privada.Checked)
            {
                textBoxContaseña.Visible = true;
            }
            else
            {
                textBoxContaseña.Visible = false;
                textBoxContaseña.Text = "";
            }
        }

        private void textBoxNombreSala_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
