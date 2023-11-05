using EnfignaServidor.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace EnfignaServidor.Modelo
{
    internal class criatura: Carta
    {
        public int daño;
        public int salud;
        public bool accion;
        public criatura() { }

        public criatura(int numeroDecarta, string nombre, int costeMana, Image imagen, int Daño, int Salud) : base(numeroDecarta, nombre, costeMana, imagen)
        {
            this.daño = Daño;
            this.salud = Salud;
        }

        public int Ataque()
        {
            return this.daño;
        }

        public void Defender(int daño)
        {

            this.salud -= daño;
        }

        public void curar(int cantidadARegenera)
        {

            this.salud += cantidadARegenera;

        }
        public void AumentoDeAtaque(int aumentoDeAtaque)
        {

            this.daño += aumentoDeAtaque;
        }

        public void rellenarImageneCriatura(int idRecuperadoCarta, criatura CartaCriatura)
        {

            switch (idRecuperadoCarta)
            {
                case 1:
                    
                    imagenCarta = Resources.carta_criatura_evil_mom_;
                    break;
                case 2:
                    imagenCarta = Resources.carta_criatura_fortune_;
                    break;
                case 3:
                    imagenCarta = Resources.carta_hechizo_magacian_;
                    break;
                case 4:
                    imagenCarta = Resources.carta_hechizo_The_Hermit_;
                    break;
                case 5:
                    imagenCarta = Resources.carta_criatura_emperor_;
                    break;
                case 6:
                    imagenCarta = Resources.carta_criatura_empress_;
                    break;
                case 7:
                    imagenCarta = Resources.carta_hechizo_justice_;
                    break;
                case 8:
                    imagenCarta = Resources.carta_criatura_woman_;
                    break;
                case 9:
                    imagenCarta = Resources.carta_criatura_Death_;
                    break;
                case 10:
                    imagenCarta = Resources.carta_hechizo_stab_;
                    break;
                case 11:
                    imagenCarta = Resources.carta_criatura_Solar_;
                    break;
                case 12:
                    imagenCarta = Resources.carta_criatura_Golden_;
                    break;
            }
        }
    }
}
