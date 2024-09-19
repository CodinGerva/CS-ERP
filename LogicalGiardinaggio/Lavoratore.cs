using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace LogicalGiardinaggio
{
    public class Lavoratore : Persona
    {
        private int stipendio, oreLavorateSettimanali;
        private Lavoro lavoroAttuale;
        private List<Lavoro> storicoLavoriEseguiti;

        public Lavoratore(string nome, string cognome, string indirizzo, string numeroTelefono, int stipendio, int oreLavorateSettimanali) 
            : base(nome, cognome, indirizzo, numeroTelefono)
        {
            this.stipendio = stipendio;
            this.oreLavorateSettimanali = oreLavorateSettimanali;
            this.storicoLavoriEseguiti = new List<Lavoro>();
        }

        public int Stipendio { get => stipendio; set => stipendio = value; }
        public int Ore { get => oreLavorateSettimanali; set => oreLavorateSettimanali = value; }
    }
}
