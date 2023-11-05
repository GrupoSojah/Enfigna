using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnfignaServidor.Modelo
{
    internal class Mesa
    {
        int idMesa;
        // se guarda, la vida del jugador, la vida de la criatura y el ataque de la criatura en ese orden especifico
        Jugador j1 = new Jugador();
        Jugador j2 = new Jugador();
        criatura cj1 = new criatura();
        criatura cj2 = new criatura();
        public Mesa(Jugador jugador1, Jugador jugador2, criatura criaturaJugador1, criatura criaturaJugador2)
        {
            j1 = jugador1;
            j2 = jugador2;
            cj1 = criaturaJugador1;
            cj2 = criaturaJugador2;
        }
        public string invocoarCriaturaJugador1(int vidaJugador, int atauqeCriatura, int vidaCriatura) {
            string criatura1 = vidaJugador.ToString() + "&" + atauqeCriatura.ToString() + "&" + vidaCriatura.ToString();
            return criatura1;
        }

        public string invocoarCriaturaJugador2(int vidaJugador, int atauqeCriatura, int vidaCriatura)
        {
            string criatura2 = vidaJugador.ToString() + "&" + atauqeCriatura.ToString() + "&" + vidaCriatura.ToString();
            return criatura2;
        }

        public void RecuperarInfoJ1(string info) {
            string[] parametros = info.Split('&');
            if (parametros.Length == 2)
            {
                j1.vida = Convert.ToInt32(parametros[0]);
                cj1.salud = Convert.ToInt32(parametros[2]);
            }
        
        }

        public string Criatura1ContraCriatura2(string info) {
            string[] parametros = info.Split('&');
            
            if (parametros.Length == 2)
            {
                cj2.Defender(Convert.ToInt32(parametros[1]));
                 string criatura2 = j2.vida.ToString() + "&" + cj2.daño.ToString() + "&" + cj2.salud.ToString();
                return criatura2;
            }
            return info;
        }
        public string Criatura2ContraCriatura1(string info)
        {
            string[] parametros = info.Split('&');

            if (parametros.Length == 2)
            {
                cj2.Defender(Convert.ToInt32(parametros[1]));
                string criatura1 = j1.vida.ToString() + "&" + cj1.daño.ToString() + "&" + cj1.salud.ToString();
                return criatura1;
            }
            return info;
        }

        public string Criatura1ContraJugador2(string info) {

            string[] parametros = info.Split('&');

            if (parametros.Length == 2)
            {
                cj2.Defender(Convert.ToInt32(parametros[1]));
                string criatura1 = j2.vida.ToString() + "&" + cj2.daño.ToString() + "&" + cj2.salud.ToString();
                return criatura1;
            }
            return info;
        }

    }
}
