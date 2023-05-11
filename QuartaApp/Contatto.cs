using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuartaApp
{
    internal class Contatto
    {
        public string nome;
        public string cognome;
        public string telefono;
        public string email;
        public DateTime creazione = DateTime.Now;
    }

    class foglia
    {
        public int lunghezza;
        public int larghezza;
        public int colore;
        public int clorofilla;
    }

    class albero
    {
        public string nome;
        public DateTime piantato;
        public int altezza;
        public foglia[] fogliame;

        public int quanteFoglie()
        {
            return fogliame.Length;
        }

        public int anelli()
        {
            int adesso = DateTime.Now.Year;
            int anni = adesso - piantato.Year;
            return anni;
        }
    }

    public class ruota
    {
        public int diametro;
        public bool bucata;
        public int pressione;
    }

    public class bici
    {
        public int colore;
        public int taglia;
        public ruota[] ruote;
    }



}
