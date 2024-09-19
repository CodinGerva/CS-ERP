using LogicalGiardinaggio;
using System.Diagnostics;
using System.Security.Cryptography;

namespace GiardinaggioIntensivo
{
    public partial class formHome : Form
    {
        Azienda a1 = new Azienda("Golden Garden", "Via Dalmio Giardino 12");
        public formHome()
        {
            CaricamentoDatiEsempio();
            InitializeComponent();
            this.pnlFormLoader.Controls.Clear();
            ForrmStarter home1 = new ForrmStarter(a1) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.pnlFormLoader.Controls.Add(home1);
            home1.Show();
        }

        public void CaricamentoDatiEsempio()
        {
            StreamReader srLavoratori = new StreamReader(Application.StartupPath + "//Dataset//Lavoratori.txt");
            List<String> toLoadDatiLavoratori = new List<String>(srLavoratori.ReadToEnd().Split("\n"));
            for (int i = 0; i < toLoadDatiLavoratori.Count - 6; i += 6)
            {
                a1.Dipendenti.Add(new Lavoratore(toLoadDatiLavoratori[i], toLoadDatiLavoratori[i+ 1], toLoadDatiLavoratori[i+2], toLoadDatiLavoratori[i+3], Int32.Parse(toLoadDatiLavoratori[i+4]), Int32.Parse(toLoadDatiLavoratori[i+5])));
            }

            StreamReader srGiardini = new StreamReader(Application.StartupPath + "//Dataset//Giardini.txt");
            List<String> toLoadDatiGiardini = new List<String>((srGiardini.ReadToEnd()).Split("\n"));
            for (int i = 0; i < toLoadDatiGiardini.Count - 6; i += 6)
            {
                a1.Giardini.Add(new Giardino(Int32.Parse(toLoadDatiGiardini[i]), Int32.Parse(toLoadDatiGiardini[i + 1]), Int32.Parse(toLoadDatiGiardini[i + 2]), Int32.Parse(toLoadDatiGiardini[i + 3]), (toLoadDatiGiardini[i + 4]), toLoadDatiGiardini[i + 5]));
            }

            StreamReader srClienti = new StreamReader(Application.StartupPath + "//Dataset//Clienti.txt");
            List<String> toLoadDatiClienti = new List<String>(srClienti.ReadToEnd().Split("\n"));
            for(int i = 0; i <  toLoadDatiClienti.Count - 5; i += 5)
            {
                a1.Clienti.Add(new Cliente(toLoadDatiClienti[i], toLoadDatiClienti[i+1], toLoadDatiClienti[i+2], toLoadDatiClienti[i+3], a1.Giardini[i / 5]));
            }

            StreamReader srUtensili = new StreamReader(Application.StartupPath + "//Dataset//Utensili.txt");
            List<String> toLoadDatiUtensili = new List<String>(srUtensili.ReadToEnd().Split("\n"));
            for (int i = 0; i < toLoadDatiUtensili.Count - 3; i += 3)
            {
                a1.Utensili.Add(new Utensile(Int32.Parse(toLoadDatiUtensili[i]), toLoadDatiUtensili[i + 1], toLoadDatiUtensili[i + 2]));
            }

            StreamReader srLavori = new StreamReader(Application.StartupPath + "//Dataset//Lavori.txt");
            List<String> toLoadDatiLavori = new List<String>(srLavori.ReadToEnd().Split("\n"));
            for (int i = 0; i < toLoadDatiLavori.Count - 6; i += 6)
            {
                string[] utensiliNomi = toLoadDatiLavori[i + 5].Split(" & ");

                List<Utensile> utensiliRichiesti = new List<Utensile>();

                foreach (string nomeUtensile in utensiliNomi)
                {
                    Utensile utensileCorrispondente = a1.Utensili.Find(u => u.Nome == nomeUtensile);

                    if (utensileCorrispondente != null)
                    {
                        utensiliRichiesti.Add(utensileCorrispondente);
                    }
                }
                a1.LavoriProgrammati.Add(new Lavoro(Int32.Parse(toLoadDatiLavori[i]), Int32.Parse(toLoadDatiLavori[i+1]), DateTime.Parse(toLoadDatiLavori[i+2]), a1.Clienti.Find(c => c.Cognome == toLoadDatiLavori[i+3]), a1.Dipendenti.Find(l => l.Cognome == toLoadDatiLavori[i+4]), utensiliRichiesti));

            }

            srLavoratori.Dispose();
            srGiardini.Dispose();
            srClienti.Dispose();
            srUtensili.Dispose();
            srLavori.Dispose();


        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void formHome_Load(object sender, EventArgs e)
        {

        }

        private void pnLavoriProssimi_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pnContainerBilancio_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lbFatturatoPlus_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.pnlFormLoader.Controls.Clear();
            FormMappa mappa = new FormMappa(a1) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.pnlFormLoader.Controls.Add(mappa);
            mappa.Show();
            lbTitoloPagina.Text = "Mappa";
        }

        private void btnLavoratori_Click(object sender, EventArgs e)
        {
            this.pnlFormLoader.Controls.Clear();
            ForrmStarter home1 = new ForrmStarter(a1) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.pnlFormLoader.Controls.Add(home1);
            home1.Show();
            lbTitoloPagina.Text = "Home";
        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.pnlFormLoader.Controls.Clear();
            FormLavoratori home1 = new FormLavoratori(a1) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.pnlFormLoader.Controls.Add(home1);
            home1.Show();
            lbTitoloPagina.Text = "Gestione Lavoratori";
        }

        private void lbTitoloPagina_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.pnlFormLoader.Controls.Clear();
            FormClienti home1 = new FormClienti(a1) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.pnlFormLoader.Controls.Add(home1);
            home1.Show();
            lbTitoloPagina.Text = "Gestione Clienti E Giardini";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.pnlFormLoader.Controls.Clear();
            FormGestioneLavori home1 = new FormGestioneLavori(a1) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.pnlFormLoader.Controls.Add(home1);
            home1.Show();
            lbTitoloPagina.Text = "Gestione Lavori E Utensili";
        }

        private void btnImpostazioni_Click(object sender, EventArgs e)
        {
            this.pnlFormLoader.Controls.Clear();
            FormImpostazioni home1 = new FormImpostazioni(a1, lbNomeAziendaMenu, pnlLateraleBase) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.pnlFormLoader.Controls.Add(home1);
            home1.Show();
            lbTitoloPagina.Text = "Gestione Lavori E Utensili";
        }
    }
}