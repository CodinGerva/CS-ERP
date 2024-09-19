using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace LogicalGiardinaggio
{
    public class Azienda
    {
        String nome, indirizzo;
        List<Lavoratore> dipendenti;
        List<Lavoro> lavoriProgrammati;
        List<Cliente> clienti;
        List<Giardino> giardini;
        List<Utensile> utensili;
        bool usato = false;

        public Azienda(string nome, string indirizzo)
        {
            this.nome = nome;
            this.indirizzo = indirizzo;
            this.dipendenti = new List<Lavoratore>();
            this.lavoriProgrammati = new List<Lavoro>();
            this.clienti = new List<Cliente>(); 
            this.giardini = new List<Giardino>();   
            this.utensili = new List<Utensile>();
        }


        public string Nome { get => nome; set => nome = value; }
        public string Indirizzo { get => indirizzo; set => indirizzo = value; }
        public List<Lavoratore> Dipendenti { get => dipendenti; set => dipendenti = value; }
        public List<Lavoro> LavoriProgrammati { get => lavoriProgrammati; set => lavoriProgrammati = value; }
        public List<Cliente> Clienti { get => clienti; set => clienti = value; }
        public List<Giardino> Giardini { get => giardini; set => giardini = value; }
        public List<Utensile> Utensili { get => utensili; set => utensili = value; }

        public static List<Recensione> getRecensioni()
        {
            List<Recensione> recensioni = new List<Recensione>();
            recensioni.Add(new Recensione(4, "Precisi", "Roberto"));
            recensioni.Add(new Recensione(5, "Ottimo", "Antonio"));
            recensioni.Add(new Recensione(5, "Ottimo", "Mario"));
            recensioni.Add(new Recensione(4, "Bravi", "Inird"));
            recensioni.Add(new Recensione(2, "Pessimo", "Paolo"));
            recensioni.Add(new Recensione(5, "Ottimo", "Marco"));
            recensioni.Add(new Recensione(3, "Poca pulizia", "Benedetta"));
            recensioni.Add(new Recensione(5, "Bravissimi", "Francesca"));

            return recensioni;
        }

        public List<Lavoro> getLavoriProssimi()
        {
            List<Lavoro> lProssimi = new List<Lavoro>();
            foreach (Lavoro l in lavoriProgrammati)
            {
                if (l.Data.CompareTo(DateTime.Now) > 0 && !lProssimi.Contains(l))
                {
                    lProssimi.Add(l);
                }
            }
            return lProssimi;
        }

        public List<Giardino> getProssimiGiardini()
        {
            List<Giardino> prossimi = new List<Giardino>();
            foreach(Lavoro lv in getLavoriProssimi())
            {
                prossimi.Add(lv.Proprietario.GiardinoCliente);
            }
            return prossimi;
        }

        public List<Lavoro> getLavoriPassati()
        {
            List<Lavoro> lProssimi = new List<Lavoro>();
            foreach (Lavoro l in lavoriProgrammati)
            {
                if (l.Data.CompareTo(DateTime.Now) < 0 && !lProssimi.Contains(l))
                {
                    lProssimi.Add(l);
                }
            }
            return lProssimi;
        }

        public int Guadagno()
        {
            int entrate = 0;
            foreach (Lavoro l_temp in getLavoriPassati())
            {
                entrate += l_temp.Prezzo;
            }
            return entrate;
        }

        public int SpeseTot()
        {
            int spese = 0;
            foreach(Lavoratore lav in dipendenti)
            {
                spese += lav.Stipendio;
            }
            foreach(Utensile ut in utensili)
            {
                spese += ut.Prezzo;
            }
            return spese;
        }

        public List<Giardino> GetProssimiGiardini()
        {
            List<Giardino> giardiniHardCoded = new List<Giardino>();
            foreach(Lavoro l in getLavoriProssimi())
            {
                giardiniHardCoded.Add(l.Proprietario.GiardinoCliente);
            }
            return giardiniHardCoded;
        }

        public List<Giardino> GetGiardiniOrdinati()
        {
            var giardini = GetProssimiGiardini();
            var permutazioni = GeneraPermutazioni(giardini);
            var minimaSomma = double.MaxValue;
            List<Giardino> sequenzaMinima = null;

            foreach (var sequenza in permutazioni)
            {
                double somma = CalcolaSommaDistanze(sequenza);

                if (somma < minimaSomma)
                {
                    minimaSomma = somma;
                    sequenzaMinima = sequenza;
                }
            }

            return sequenzaMinima;
        }

        public List<List<Giardino>> GeneraPermutazioni(List<Giardino> giardini)
        {
            var permutazioni = new List<List<Giardino>>();
            GeneraPermutazioniRicorsivo(giardini.Count, giardini, permutazioni);
            return permutazioni;
        }

        private void GeneraPermutazioniRicorsivo(int n, List<Giardino> giardini, List<List<Giardino>> permutazioni)
        {
            if (n == 1)
            {
                permutazioni.Add(new List<Giardino>(giardini));
            }
            else
            {
                for (int i = 0; i < n - 1; i++)
                {
                    GeneraPermutazioniRicorsivo(n - 1, giardini, permutazioni);
                    if (n % 2 == 0)
                        Scambia(giardini, i, n - 1);
                    else
                        Scambia(giardini, 0, n - 1);
                }
                GeneraPermutazioniRicorsivo(n - 1, giardini, permutazioni);
            }
        }

        private void Scambia(List<Giardino> giardini, int i, int j)
        {
            Giardino temp = giardini[i];
            giardini[i] = giardini[j];
            giardini[j] = temp;
        }

        private double CalcolaSommaDistanze(List<Giardino> sequenza)
        {
            double somma = 0.0;

            for (int i = 0; i < sequenza.Count - 1; i++)
            {
                somma += CalcolaDistanza(sequenza[i], sequenza[i + 1]);
            }

            return somma;
        }

        public double CalcolaDistanza(Giardino g1, Giardino g2)
        {
            return Math.Sqrt(Math.Pow((g1.Posizione_X - g2.Posizione_X), 2) + Math.Pow((g1.Posizione_Y - g2.Posizione_Y),2));
        }
        

        public void getLavoratoriSampleData()
        {
            foreach(Lavoro lv in this.LavoriProgrammati)
            {
                if (!dipendenti.Contains(lv.LavoratoreGiardino))
                {
                    dipendenti.Add(lv.LavoratoreGiardino);
                }
            }

        }
        
        public Lavoratore BestLavoratore()
        {
            Lavoratore migliore = dipendenti[0];
            foreach(Lavoratore worker in Dipendenti)
            {
                if(worker.Ore > migliore.Ore)
                {
                    migliore = worker; 
                }
            }
            return migliore;
        }

        public void getClientiSampleData()
        {
            foreach (Lavoro lv in this.lavoriProgrammati)
            {
                if (!clienti.Contains(lv.Proprietario))
                {
                    clienti.Add(lv.Proprietario);
                }
            }

        }

        public void getSampleDataGiardini() 
        {
            foreach(Cliente cl in clienti)
            {
                if (!giardini.Contains(cl.GiardinoCliente))
                {
                    giardini.Add(cl.GiardinoCliente);
                }
                
            }
        }


        public void getUtensili()
        {
            foreach (Lavoro lv in lavoriProgrammati)
            {
                foreach (Utensile uten in lv.UtensiliRichiesti)
                {
                    if (!Utensili.Contains(uten))
                    {
                        Utensili.Add(uten);
                    }
                }
            }
        }

        


    }
}
