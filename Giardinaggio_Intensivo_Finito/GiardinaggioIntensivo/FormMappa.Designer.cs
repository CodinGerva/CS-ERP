namespace GiardinaggioIntensivo
{
    partial class FormMappa
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMappa));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            panel1 = new Panel();
            panel2 = new Panel();
            dgvDestinazioniMappa = new DataGridView();
            panel3 = new Panel();
            lbDestinazioniMappe = new Label();
            panel4 = new Panel();
            panel5 = new Panel();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDestinazioniMappa).BeginInit();
            panel3.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(54, 70, 121);
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.Location = new Point(12, 9);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(552, 505);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(54, 70, 121);
            panel2.Controls.Add(dgvDestinazioniMappa);
            panel2.Location = new Point(10, 78);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(136, 451);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint;
            // 
            // dgvDestinazioniMappa
            // 
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(54, 70, 121);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(64, 80, 131);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dgvDestinazioniMappa.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvDestinazioniMappa.Anchor = AnchorStyles.None;
            dgvDestinazioniMappa.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDestinazioniMappa.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvDestinazioniMappa.BackgroundColor = Color.FromArgb(69, 91, 189);
            dgvDestinazioniMappa.BorderStyle = BorderStyle.None;
            dgvDestinazioniMappa.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvDestinazioniMappa.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(28, 92, 155);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.Window;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvDestinazioniMappa.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvDestinazioniMappa.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(8, 72, 135);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.ButtonHighlight;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvDestinazioniMappa.DefaultCellStyle = dataGridViewCellStyle3;
            dgvDestinazioniMappa.GridColor = Color.FromArgb(69, 91, 189);
            dgvDestinazioniMappa.Location = new Point(10, 23);
            dgvDestinazioniMappa.Margin = new Padding(3, 2, 3, 2);
            dgvDestinazioniMappa.MultiSelect = false;
            dgvDestinazioniMappa.Name = "dgvDestinazioniMappa";
            dgvDestinazioniMappa.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(8, 72, 135);
            dataGridViewCellStyle4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.Window;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvDestinazioniMappa.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvDestinazioniMappa.RowHeadersVisible = false;
            dgvDestinazioniMappa.RowHeadersWidth = 60;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(8, 72, 135);
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(8, 72, 135);
            dgvDestinazioniMappa.RowsDefaultCellStyle = dataGridViewCellStyle5;
            dgvDestinazioniMappa.RowTemplate.Height = 29;
            dgvDestinazioniMappa.ScrollBars = ScrollBars.Vertical;
            dgvDestinazioniMappa.Size = new Size(115, 407);
            dgvDestinazioniMappa.TabIndex = 2;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(54, 70, 121);
            panel3.Controls.Add(lbDestinazioniMappe);
            panel3.Location = new Point(10, 2);
            panel3.Margin = new Padding(3, 2, 3, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(136, 36);
            panel3.TabIndex = 2;
            // 
            // lbDestinazioniMappe
            // 
            lbDestinazioniMappe.AutoSize = true;
            lbDestinazioniMappe.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lbDestinazioniMappe.ForeColor = Color.FromArgb(0, 126, 250);
            lbDestinazioniMappe.Location = new Point(4, 7);
            lbDestinazioniMappe.Name = "lbDestinazioniMappe";
            lbDestinazioniMappe.Size = new Size(121, 25);
            lbDestinazioniMappe.TabIndex = 0;
            lbDestinazioniMappe.Text = "Destinazioni";
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(0, 126, 250);
            panel4.Location = new Point(10, 57);
            panel4.Margin = new Padding(3, 2, 3, 2);
            panel4.Name = "panel4";
            panel4.Size = new Size(136, 4);
            panel4.TabIndex = 2;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(54, 70, 121);
            panel5.Controls.Add(panel1);
            panel5.Location = new Point(163, 2);
            panel5.Name = "panel5";
            panel5.Size = new Size(574, 527);
            panel5.TabIndex = 3;
            // 
            // FormMappa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 51, 73);
            ClientSize = new Size(749, 549);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormMappa";
            Text = "FormMappa";
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDestinazioniMappa).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel5.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Label lbDestinazioniMappe;
        private Panel panel4;
        private DataGridView dgvDestinazioniMappa;
        private Panel panel5;
    }
}