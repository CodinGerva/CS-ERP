using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalGiardinaggio
{
    public class Lavoro
    {
        private Cliente proprietarioGiardino;
        private Lavoratore lavoratoreGiardino;
        private List<Utensile> utensiliRichiesti;
        private int prezzo, oreRichieste;
        DateTime dataLavoro;
        public Lavoro(int prezzo, int oreRichieste, DateTime dataLavoro, Cliente proprietarioGiardino, Lavoratore lavoratoreGiardino, List<Utensile> utensiliRichiesti)
        {
            this.proprietarioGiardino = proprietarioGiardino;
            this.lavoratoreGiardino = lavoratoreGiardino;
            this.utensiliRichiesti = utensiliRichiesti;
            this.prezzo = prezzo;
            this.oreRichieste = oreRichieste;
            this.dataLavoro = dataLavoro;
        }

        public int Prezzo { get => prezzo; set => prezzo = value; }
        public int Ore { get => oreRichieste; set => oreRichieste = value; }
        public DateTime Data { get => dataLavoro; set => dataLavoro = value; }

        public string Cliente { get => proprietarioGiardino.Cognome; }

        public string Lavoratore { get => lavoratoreGiardino.Cognome; }

        [Browsable(false)] public Cliente Proprietario { get => proprietarioGiardino; set => proprietarioGiardino = value; }
        [Browsable(false)] public Lavoratore LavoratoreGiardino{ get => lavoratoreGiardino; set => lavoratoreGiardino = value; }

        [Browsable(false)] public String WriteProprietario { get => proprietarioGiardino.Cognome;}
        [Browsable(false)] public String WriteLavoratoreGiardino { get => lavoratoreGiardino.Cognome;}
        [Browsable(false)] public String WriteData { get => dataLavoro.Day.ToString() + "-" + dataLavoro.Month.ToString() + "-" + dataLavoro.Year.ToString(); }
        [Browsable(false)] public String WriteUtensili { get => string.Join(" & ", UtensiliRichiesti.Select(utensile => utensile.Nome)); }
        public List<Utensile> UtensiliRichiesti { get => utensiliRichiesti; set => utensiliRichiesti = value; }
    }
}
