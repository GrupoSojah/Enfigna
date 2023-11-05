using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace EnfignaServidor.Modelo
{
    public class Jugador
    {
        public string usuario;
        public int dinero;
        public int halo;

        ArrayList Mazo = new ArrayList();
        ArrayList manoPropia = new ArrayList();

        public Jugador()
        {

        }

        public Jugador(string usuario, int dinero, int halo, ArrayList mazo, ArrayList ManoPropia)
        {
            this.usuario = usuario;
            this.dinero = dinero;
            this.halo = halo;
            this.Mazo = mazo;
            this.manoPropia = ManoPropia;
        }

        public void mezclarMazo()
        {
            ArrayList mazoMezclado = Mazo;
            Mazo.Clear();

            for (int i = 0; i < Mazo.Count; i++)
            {
                Random numeroRandom = new Random();
                int a = numeroRandom.Next(mazoMezclado.Count + 1);

                Mazo.Add(mazoMezclado[a]);

                mazoMezclado.Remove(a);
            }
        }
    }
}