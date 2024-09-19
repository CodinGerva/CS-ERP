using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LogicalGiardinaggio;

namespace GiardinaggioIntensivo
{
    public partial class FormMappa : Form
    {
        Azienda aziendaPassata;
        public FormMappa(Azienda a1)
        {
            aziendaPassata = a1;
            InitializeComponent();
            dgvDestinazioniMappa.AutoGenerateColumns = false;
            dgvDestinazioniMappa.DataSource = typeof(List<Giardino>);
            dgvDestinazioniMappa.DataSource = a1.GetGiardiniOrdinati();
            var addressColumn = new DataGridViewTextBoxColumn();
            addressColumn.DataPropertyName = "Indirizzo";
            addressColumn.HeaderText = "Indirizzi";
            dgvDestinazioniMappa.Columns.Add(addressColumn);

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            var g = e.Graphics;

            List<Point> puntiDaDisegnare = new List<Point>();

            foreach (Giardino giar in aziendaPassata.GetGiardiniOrdinati())
            {
                puntiDaDisegnare.Add(new Point(giar.Posizione_X, giar.Posizione_Y));
            }

            Pen pen = new Pen(Color.Turquoise, 5);
            Pen pen2 = new Pen(Color.DarkBlue, 10);

            foreach (Point p1 in puntiDaDisegnare)
            {
                g.DrawEllipse(pen2, p1.X, p1.Y, 15, 15);
            }

            for (int i = 0; i < puntiDaDisegnare.Count - 1; i++)
            {

                g.DrawLine(pen, puntiDaDisegnare[i], puntiDaDisegnare[i + 1]);
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
