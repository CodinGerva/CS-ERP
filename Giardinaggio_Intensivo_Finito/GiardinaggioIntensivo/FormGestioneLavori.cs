using LogicalGiardinaggio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GiardinaggioIntensivo
{
    public partial class FormGestioneLavori : Form
    {
        Azienda aziendaPassata;
        List<Utensile> utensiliSelezionati = new List<Utensile>();
        public FormGestioneLavori(Azienda a1)
        {
            aziendaPassata = a1;
            InitializeComponent();
            dgvLavoriList.DataSource = typeof(List<Lavoro>);
            dgvLavoriList.DataSource = a1.LavoriProgrammati;
            dgvUtensiliList.DataSource = typeof(List<Utensile>);
            dgvUtensiliList.DataSource = a1.Utensili;
            cbProprietarioLavori.DataSource = a1.Clienti;
            cbProprietarioLavori.DisplayMember = "Cognome";
            cbLavoratori.DataSource = a1.Dipendenti;
            cbLavoratori.DisplayMember = "Cognome";
            cbUtensile.DataSource = a1.Utensili;
            cbUtensile.DisplayMember = "Nome";
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAggiungiNewLavoratore_Click(object sender, EventArgs e)
        {
            aziendaPassata.LavoriProgrammati.Add(new Lavoro(Int32.Parse(tbPrezzoLavoro.Text), Int32.Parse(tbOreLavoro.Text), new DateTime(dtpLavori.Value.Year, dtpLavori.Value.Month, dtpLavori.Value.Day), aziendaPassata.Clienti[cbProprietarioLavori.SelectedIndex], aziendaPassata.Dipendenti[cbLavoratori.SelectedIndex], utensiliSelezionati));
            dgvLavoriList.DataSource = typeof(List<Lavoro>);
            dgvLavoriList.DataSource = aziendaPassata.LavoriProgrammati;
            utensiliSelezionati.Clear();
            aziendaPassata.Dipendenti[cbLavoratori.SelectedIndex].Ore += Int32.Parse(tbOreLavoro.Text);
        }

        private void cbUtensile_SelectedIndexChanged(object sender, EventArgs e)
        {
            utensiliSelezionati.Add(aziendaPassata.Utensili[cbUtensile.SelectedIndex]);
        }

        private void btnAggiungiGiardino_Click(object sender, EventArgs e)
        {
            aziendaPassata.Utensili.Add(new Utensile(Int32.Parse(tbPrezzoUtensile.Text), tbNomeUtensile.Text, tbCondizioniUtensile.Text));
            cbUtensile.DataSource = aziendaPassata.Utensili;
            cbUtensile.DisplayMember = "Nome";
            dgvUtensiliList.DataSource = typeof(List<Utensile>);
            dgvUtensiliList.DataSource = aziendaPassata.Utensili;
        }
    }
}
