using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnfignaServidor.Modelo
{
    internal class criatura: Carta
    {
        public int daño;
        public int salud;
        public bool accion;

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


    }
}
