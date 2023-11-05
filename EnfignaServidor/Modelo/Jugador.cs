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
        public int mana;
        public int vida; 

        ArrayList Mazo = new ArrayList();
        ArrayList manoPropia = new ArrayList();

        public Jugador()
        {

        }

        public Jugador(string usuario, int dinero, int halo, ArrayList mazo, ArrayList ManoPropia, int mana, int vida)
        {
            this.usuario = usuario;
            this.dinero = dinero;
            this.vida = vida;
            this.halo = halo;
            this.Mazo = mazo;
            this.manoPropia = ManoPropia;
            this.mana = mana;
        }



        public void repartirManoInicial() {

            for (int i = 0; i < 5; i++)
            {
                manoPropia.Add(Mazo[i]);
                Mazo.RemoveAt(i);
            }
        
        }

        public void repartirMano() {
            manoPropia.Add(Mazo[0]);
            Mazo.RemoveAt(0);
        }

        public void RecivirDaño(int daño) {
            vida -= daño;
        }

        public void RegenerarMana() {
            mana++;
        
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