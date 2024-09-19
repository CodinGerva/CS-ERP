using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LogicalGiardinaggio;

namespace GiardinaggioIntensivo
{
    public partial class FormClienti : Form
    {
        Azienda aziendaPassata;
        public FormClienti(Azienda a1)
        {
            aziendaPassata = a1;
            InitializeComponent();
            dgvClientiList.DataSource = typeof(List<Cliente>);
            dgvClientiList.DataSource = a1.Clienti;
            dgvGiardiniList.DataSource = typeof(List<Giardino>);
            dgvGiardiniList.DataSource = a1.Giardini;
            cbSelectGiardini.DataSource = a1.Giardini;
            cbSelectGiardini.DisplayMember = "Indirizzo";
        }

        private void FormClienti_Load(object sender, EventArgs e)
        {

        }

        private void btnAggiungiNewLavoratore_Click(object sender, EventArgs e)
        {
            aziendaPassata.Clienti.Add(new Cliente(tbNomeCliente.Text, tbCognomeCliente.Text, tbIndirizzoCliente.Text, tbTelefonoCliente.Text, aziendaPassata.Giardini[cbSelectGiardini.SelectedIndex]));
            dgvClientiList.DataSource = typeof(List<Cliente>);
            dgvClientiList.DataSource = aziendaPassata.Clienti;

        }

        private void btnAggiungiGiardino_Click(object sender, EventArgs e)
        {
            aziendaPassata.Giardini.Add(new Giardino((int)udPosizioneX.Value, (int)udPosizioneY.Value, (int)udDimensioniX.Value, (int)udDimensioniY.Value, tbCondizioniNewGiardino.Text, tbIndirizzoNewGiardino.Text));
            dgvGiardiniList.DataSource = typeof(List<Giardino>);
            dgvGiardiniList.DataSource = aziendaPassata.Giardini;
            cbSelectGiardini.DataSource = aziendaPassata.Giardini;
            cbSelectGiardini.DisplayMember = "Indirizzo";
        }
    }
}
