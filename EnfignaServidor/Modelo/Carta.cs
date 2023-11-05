using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnfignaServidor.Modelo
{
    internal abstract class Carta
    {

        public int numeroDeCarta;
        public string nombre = "";
        public int costeMana;
        public Image? imagenCarta = null;
       
        
        
        
        public Carta() { }

        public Carta(int numeroDecarta, string nombre, int costeMana, Image imagenCarta)
        {
            this.costeMana = costeMana;
            this.nombre = nombre;
            this.numeroDeCarta = numeroDecarta;
            this.imagenCarta = imagenCarta;
        }


        public 






    }
}
