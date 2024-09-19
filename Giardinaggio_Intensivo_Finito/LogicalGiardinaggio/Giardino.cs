using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalGiardinaggio
{
    public class Giardino
    {
        int posizione_X, posizione_Y, lunghezza, altezza;
        String condizioni, indirizzo;

        public Giardino(int posizione_X, int posizione_Y, int lunghezza, int altezza, string condizioni, string indirizzo)
        {
            this.posizione_X = posizione_X;
            this.posizione_Y = posizione_Y;
            this.lunghezza = lunghezza;
            this.altezza = altezza;
            this.condizioni = condizioni;
            this.indirizzo = indirizzo;
        }
        [Browsable(false)] public int Posizione_X { get => posizione_X; set => posizione_X = value; }
        [Browsable(false)] public int Posizione_Y { get => posizione_Y; set => posizione_Y = value; }

        public int Lunghezza { get => lunghezza; set => lunghezza = value; }
        public int Altezza { get => altezza; set => altezza = value; }
        public string Condizioni { get => condizioni; set => condizioni = value; }
        public string Indirizzo { get => indirizzo; set => indirizzo = value; }
    }
}
