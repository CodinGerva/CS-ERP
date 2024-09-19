using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LogicalGiardinaggio;

namespace GiardinaggioIntensivo
{
    public partial class FormLavoratori : Form
    {
        Azienda aziendaPassata;
        public FormLavoratori(Azienda a1)
        {
            aziendaPassata = a1;
            InitializeComponent();
            dgvLavoratori.DataSource = typeof(List<Lavoratore>);
            dgvLavoratori.DataSource = a1.Dipendenti;
            lbBestNome.Text = a1.BestLavoratore().Nome;
            lbBestCognome.Text = a1.BestLavoratore().Cognome;
            lbBestOreLavorate.Text = a1.BestLavoratore().Ore.ToString();
        }

        private void pnlLavoratoriView_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void lbBestCognome_Click(object sender, EventArgs e)
        {

        }

        private void btnAggiungiNewLavoratore_Click(object sender, EventArgs e)
        {
            aziendaPassata.Dipendenti.Add(new Lavoratore(tbNomeNewLavoratore.Text, tbCognomeNewLavoratore.Text, tbIndirizzoNewLavoratore.Text, tbTelefonoNewLavoratore.Text, Int32.Parse(tbStipendio.Text), 0));
            dgvLavoratori.DataSource = typeof(List<Lavoratore>);
            dgvLavoratori.DataSource = aziendaPassata.Dipendenti;
        }

        
    }
}
