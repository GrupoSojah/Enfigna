using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnfignaServidor.Modelo
{
    internal class hechizo: Carta
    {
        public int efecto;

        
        public hechizo(int numeroDecarta, string nombre, int costeMana, Image imagenCarta, int efecto) : base(numeroDecarta, nombre, costeMana, imagenCarta)
        {
            this.efecto = efecto;
        }

        public int RealizarEfecto()
        {
            int a = 0;

            switch (efecto) {
                case 1:
                    //Daño Oponente;
                    a = 20;
                    break;
                case 2:
                    //Subir estadistica.
                    a = 20;
                    break;
                case 3:
                    //Curarse
                    a = 30;
                    break;
            }
            return a;
        }
        }
}
