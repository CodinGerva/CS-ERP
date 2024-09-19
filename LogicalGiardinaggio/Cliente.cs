using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalGiardinaggio
{
    public class Cliente : Persona
    {
        private Giardino giardinoCliente;

        public Cliente(string nome, string cognome, string indirizzo, string numeroTelefono, Giardino giardinoCliente) 
            : base(nome, cognome, indirizzo, numeroTelefono)
        {
            this.giardinoCliente = giardinoCliente;
        }


        [Browsable(false)] public Giardino GiardinoCliente { get => giardinoCliente; set => giardinoCliente = value; }
        [Browsable(false)] public String WriteGiardinoCliente { get => giardinoCliente.Indirizzo; }
    }
}
