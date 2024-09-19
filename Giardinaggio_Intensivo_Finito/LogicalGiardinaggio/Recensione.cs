using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalGiardinaggio
{
    public class Recensione
    {
        private int stelle;
        private string commento_servizio, nome;

        public Recensione(int stelle, string commento_servizio, string nome)
        {
            this.stelle = stelle;
            this.commento_servizio = commento_servizio;
            this.nome = nome;
        }

        public string DisegnaStelle()
        {
            string s = "";
            for(int i = 0; i < stelle; i++)
            {
                s += "⭐";
            }

            return s;   
        }

        public string Stelle { get => DisegnaStelle(); }
        public string Commento { get => commento_servizio; set => commento_servizio = value; }
        public string Nome { get => nome; set => nome = value; }
    }
}