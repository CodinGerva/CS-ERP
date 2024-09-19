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
    public partial class ForrmStarter : Form
    {
        public ForrmStarter(Azienda a1)
        {
            InitializeComponent();
            dgvProssimiLavori.DataSource = typeof(List<Lavoro>);
            dgvProssimiLavori.DataSource = a1.getLavoriProssimi();
            lbFatturatoPlus.Text = "+" + a1.Guadagno();
            lbFatturatoMinus.Text = "-" + a1.SpeseTot();
            dgvRecensioni.DataSource = typeof(List<Recensione>);
            dgvRecensioni.DataSource = Azienda.getRecensioni();
        }

        private void ForrmStarter_Load(object sender, EventArgs e)
        {

        }
    }
}
