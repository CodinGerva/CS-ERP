using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalGiardinaggio
{
    public class Utensile
    {
        private int prezzo;
        private String condizioniOggetto, nome;

        public Utensile(int prezzo, string condizioniOggetto, string nome)
        {
            this.prezzo = prezzo;
            this.condizioniOggetto = condizioniOggetto;
            this.nome = nome;
        }

        public int Prezzo { get => prezzo; set => prezzo = value; }
        public string Condizioni { get => condizioniOggetto; set => condizioniOggetto = value; }
        public string Nome { get => nome; set => nome = value; }
    }
}