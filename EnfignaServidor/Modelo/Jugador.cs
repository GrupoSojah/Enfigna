using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnfignaServidor.Modelo
{
    public class Jugador
    {
        public string usuario;
        public int dinero;
        public int halo;

        public Jugador()
        {
            
        }

        public Jugador(string usuario, int dinero, int halo)
        {
            this.usuario = usuario;
            this.dinero = dinero;
            this.halo = halo;
        }
    }
}
