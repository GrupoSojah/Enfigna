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
    public partial class modalidad : Form
    {
        private Jugador usuarioActual;
        private string nombreMazo;
        public modalidad(Jugador usuario, string mazo)
        {
            InitializeComponent();
            this.usuarioActual = usuario;
            this.nombreMazo = mazo;

            labelUsuario.Text = usuario.usuario.ToString();
        }

        private void button_Crear_Click(object sender, EventArgs e)
        {
            crearSala pantallaCrearSala = new crearSala();

            pantallaCrearSala.Show();

            this.Close();
        }

        private void button_Unirse_Click(object sender, EventArgs e)
        {
            UnirseAsala pantallaUnirseAsala = new UnirseAsala();

            pantallaUnirseAsala.Show();

            this.Close();
        }
    }
}
