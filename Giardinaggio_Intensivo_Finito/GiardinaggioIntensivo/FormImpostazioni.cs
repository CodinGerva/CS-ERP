using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LogicalGiardinaggio;

namespace GiardinaggioIntensivo
{
    public partial class FormImpostazioni : Form
    {
        Azienda aziendaPassata;
        Label labelPassata;
        Panel pannelloPassato;
        public FormImpostazioni(Azienda a1, Label nomeAzienda, Panel pannelloLaterale)
        {
            pannelloPassato = pannelloLaterale;
            labelPassata = nomeAzienda;
            aziendaPassata = a1;
            InitializeComponent();
            lbNomeAziendaImpostazioni.Text = a1.Nome;
        }

        private void btnRinominaAzienda_Click(object sender, EventArgs e)
        {
            aziendaPassata.Nome = tbNuovoNomeAzienda.Text;
            labelPassata.Text = tbNuovoNomeAzienda.Text;
            lbNomeAziendaImpostazioni.Text = tbNuovoNomeAzienda.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (ColorDialog colorDialog = new ColorDialog())
            {
                DialogResult result = colorDialog.ShowDialog();

                if (result == DialogResult.OK)
                {
                    Color selectedColor = colorDialog.Color;
                    pannelloPassato.BackColor = selectedColor;
                }
            }
        }

        private void btnCambiaColore_Click(object sender, EventArgs e)
        {
            Color coloreBase = Color.FromArgb(24, 30, 54);
            pannelloPassato.BackColor = coloreBase;
        }

        
        //SCRITTURA SU FILE DI TUTTI I DATI
        private void btnSalvaModifiche_Click(object sender, EventArgs e)
        {
            using (StreamWriter swClienti = new StreamWriter(Application.StartupPath + "\\Dataset\\Clienti.txt"))
            {
                foreach(Cliente cl in aziendaPassata.Clienti)
                {
                    swClienti.WriteLine(cl.Nome);
                    swClienti.WriteLine(cl.Cognome);
                    swClienti.WriteLine(cl.Indirizzo);
                    swClienti.WriteLine(cl.Telefono);
                    swClienti.WriteLine(cl.WriteGiardinoCliente);
                }
            }
            using (StreamWriter swLavoratori = new StreamWriter(Application.StartupPath + "\\Dataset\\Lavoratori.txt"))
            {
                foreach (Lavoratore wor in aziendaPassata.Dipendenti)
                {
                    swLavoratori.WriteLine(wor.Nome);
                    swLavoratori.WriteLine(wor.Cognome);
                    swLavoratori.WriteLine(wor.Indirizzo);
                    swLavoratori.WriteLine(wor.Telefono);
                    swLavoratori.WriteLine(wor.Stipendio);
                    swLavoratori.WriteLine(wor.Ore);
                }
            }
            using (StreamWriter swGiardini = new StreamWriter(Application.StartupPath + "\\Dataset\\Giardini.txt"))
            {
                foreach (Giardino gr in aziendaPassata.Giardini)
                {
                    swGiardini.WriteLine(gr.Posizione_X);
                    swGiardini.WriteLine(gr.Posizione_Y);
                    swGiardini.WriteLine(gr.Lunghezza);
                    swGiardini.WriteLine(gr.Altezza);
                    swGiardini.WriteLine(gr.Condizioni);
                    swGiardini.WriteLine(gr.Indirizzo);
                }
            }
            using (StreamWriter swLavori = new StreamWriter(Application.StartupPath + "\\Dataset\\Lavori.txt"))
            {
                foreach (Lavoro lv in aziendaPassata.LavoriProgrammati)
                {
                    swLavori.WriteLine(lv.Prezzo);
                    swLavori.WriteLine(lv.Ore);
                    swLavori.WriteLine(lv.WriteData);
                    swLavori.WriteLine(lv.WriteProprietario);
                    swLavori.WriteLine(lv.WriteLavoratoreGiardino);
                    swLavori.WriteLine(lv.WriteUtensili);
                }
            }
            using (StreamWriter swUtensili = new StreamWriter(Application.StartupPath + "\\Dataset\\Utensili.txt"))
            {
                foreach (Utensile ut in aziendaPassata.Utensili)
                {              
                    swUtensili.WriteLine(ut.Prezzo);
                    swUtensili.WriteLine(ut.Condizioni);
                    swUtensili.WriteLine(ut.Nome);
                }   
            }
        }
    }
}
