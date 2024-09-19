using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalGiardinaggio
{
    public class Persona
    {
        String nome, cognome, indirizzo, numeroTelefono;

        public Persona(string nome, string cognome, string indirizzo, string numeroTelefono)
        {
            this.nome = nome;
            this.cognome = cognome;
            this.indirizzo = indirizzo;
            this.numeroTelefono = numeroTelefono;
        }

        public string Nome { get => nome; set => nome = value; }
        public string Cognome { get => cognome; set => cognome = value; }
        public string Indirizzo { get => indirizzo; set => indirizzo = value; }
        public string Telefono { get => numeroTelefono; set => numeroTelefono = value; }



    }
}