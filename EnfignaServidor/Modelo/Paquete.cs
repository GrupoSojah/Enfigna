using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnfignaServidor.Modelo
{
    internal class Paquete
    {
        List<Carta> Cartas = new List<Carta>();

        public Carta GeneradorCartas()
        {
            if (Cartas.Count == 0)
            {
                return null;
            }

            Random numeroRandomCarta = new Random();
            int randomNumero = numeroRandomCarta.Next(Cartas.Count);

            return Cartas[randomNumero];
        }
    }
}