namespace GiardinaggioIntensivo
{
    partial class FormLavoratori
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLavoratori));
            pnlLavoratoriView = new Panel();
            dgvLavoratori = new DataGridView();
            panel1 = new Panel();
            label3 = new Label();
            label2 = new Label();
            panel4 = new Panel();
            lbOrario2 = new Label();
            lborarioLunVen = new Label();
            panel2 = new Panel();
            lbBestOreLavorateText = new Label();
            panel3 = new Panel();
            lbBestOreLavorate = new Label();
            lbBestCognome = new Label();
            lbBestNome = new Label();
            pictureBox1 = new PictureBox();
            lbIntestazioneOrari = new Label();
            label1 = new Label();
            panel5 = new Panel();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            lbNomeNewLavoratore = new Label();
            tbIndirizzoNewLavoratore = new TextBox();
            tbCognomeNewLavoratore = new TextBox();
            tbStipendio = new TextBox();
            tbTelefonoNewLavoratore = new TextBox();
            tbNomeNewLavoratore = new TextBox();
            btnAggiungiNewLavoratore = new Button();
            lbNuovoLavoratore = new Label();
            pnlLavoratoriView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLavoratori).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // pnlLavoratoriView
            // 
            pnlLavoratoriView.BackColor = Color.FromArgb(54, 70, 121);
            pnlLavoratoriView.Controls.Add(dgvLavoratori);
            pnlLavoratoriView.Location = new Point(12, 1);
            pnlLavoratoriView.Name = "pnlLavoratoriView";
            pnlLavoratoriView.Size = new Size(463, 340);
            pnlLavoratoriView.TabIndex = 0;
            pnlLavoratoriView.Paint += pnlLavoratoriView_Paint;
            // 
            // dgvLavoratori
            // 
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(54, 70, 121);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(64, 80, 131);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dgvLavoratori.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvLavoratori.Anchor = AnchorStyles.None;
            dgvLavoratori.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvLavoratori.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvLavoratori.BackgroundColor = Color.FromArgb(69, 91, 189);
            dgvLavoratori.BorderStyle = BorderStyle.None;
            dgvLavoratori.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvLavoratori.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(28, 92, 155);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.Window;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvLavoratori.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvLavoratori.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(8, 72, 135);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.ButtonHighlight;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvLavoratori.DefaultCellStyle = dataGridViewCellStyle3;
            dgvLavoratori.GridColor = Color.FromArgb(69, 91, 189);
            dgvLavoratori.Location = new Point(14, 20);
            dgvLavoratori.Margin = new Padding(3, 2, 3, 2);
            dgvLavoratori.MultiSelect = false;
            dgvLavoratori.Name = "dgvLavoratori";
            dgvLavoratori.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(8, 72, 135);
            dataGridViewCellStyle4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.Window;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvLavoratori.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvLavoratori.RowHeadersVisible = false;
            dgvLavoratori.RowHeadersWidth = 60;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(8, 72, 135);
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(8, 72, 135);
            dgvLavoratori.RowsDefaultCellStyle = dataGridViewCellStyle5;
            dgvLavoratori.RowTemplate.Height = 29;
            dgvLavoratori.ScrollBars = ScrollBars.Vertical;
            dgvLavoratori.Size = new Size(436, 303);
            dgvLavoratori.TabIndex = 3;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(54, 70, 121);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(lbOrario2);
            panel1.Controls.Add(lborarioLunVen);
            panel1.Location = new Point(12, 394);
            panel1.Name = "panel1";
            panel1.Size = new Size(214, 140);
            panel1.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(0, 126, 250);
            label3.Location = new Point(64, 109);
            label3.Name = "label3";
            label3.Size = new Size(67, 25);
            label3.TabIndex = 5;
            label3.Text = "chiuso";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(69, 91, 189);
            label2.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(0, 126, 250);
            label2.Location = new Point(51, 84);
            label2.Name = "label2";
            label2.Size = new Size(99, 25);
            label2.TabIndex = 4;
            label2.Text = "Domenica";
            label2.Click += label2_Click;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(0, 126, 250);
            panel4.Location = new Point(7, 68);
            panel4.Name = "panel4";
            panel4.Size = new Size(199, 5);
            panel4.TabIndex = 3;
            // 
            // lbOrario2
            // 
            lbOrario2.AutoSize = true;
            lbOrario2.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lbOrario2.ForeColor = Color.FromArgb(0, 126, 250);
            lbOrario2.Location = new Point(37, 35);
            lbOrario2.Name = "lbOrario2";
            lbOrario2.Size = new Size(127, 25);
            lbOrario2.TabIndex = 1;
            lbOrario2.Text = "10:00 - 18:00 ";
            // 
            // lborarioLunVen
            // 
            lborarioLunVen.AutoSize = true;
            lborarioLunVen.BackColor = Color.FromArgb(69, 91, 189);
            lborarioLunVen.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lborarioLunVen.ForeColor = Color.FromArgb(0, 126, 250);
            lborarioLunVen.Location = new Point(26, 8);
            lborarioLunVen.Name = "lborarioLunVen";
            lborarioLunVen.Size = new Size(146, 25);
            lborarioLunVen.TabIndex = 0;
            lborarioLunVen.Text = "Lunedì - Sabato";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(54, 70, 121);
            panel2.Controls.Add(lbBestOreLavorateText);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(lbBestOreLavorate);
            panel2.Controls.Add(lbBestCognome);
            panel2.Controls.Add(lbBestNome);
            panel2.Controls.Add(pictureBox1);
            panel2.Location = new Point(239, 394);
            panel2.Name = "panel2";
            panel2.Size = new Size(236, 143);
            panel2.TabIndex = 2;
            // 
            // lbBestOreLavorateText
            // 
            lbBestOreLavorateText.AutoSize = true;
            lbBestOreLavorateText.BackColor = Color.FromArgb(69, 91, 189);
            lbBestOreLavorateText.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lbBestOreLavorateText.ForeColor = Color.FromArgb(0, 126, 250);
            lbBestOreLavorateText.Location = new Point(128, 84);
            lbBestOreLavorateText.Name = "lbBestOreLavorateText";
            lbBestOreLavorateText.Size = new Size(49, 25);
            lbBestOreLavorateText.TabIndex = 14;
            lbBestOreLavorateText.Text = "Ore:";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(0, 126, 250);
            panel3.Location = new Point(117, 15);
            panel3.Name = "panel3";
            panel3.Size = new Size(5, 115);
            panel3.TabIndex = 2;
            // 
            // lbBestOreLavorate
            // 
            lbBestOreLavorate.AutoSize = true;
            lbBestOreLavorate.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            lbBestOreLavorate.ForeColor = Color.FromArgb(0, 126, 250);
            lbBestOreLavorate.Location = new Point(175, 76);
            lbBestOreLavorate.Name = "lbBestOreLavorate";
            lbBestOreLavorate.Size = new Size(52, 37);
            lbBestOreLavorate.TabIndex = 3;
            lbBestOreLavorate.Text = "int";
            // 
            // lbBestCognome
            // 
            lbBestCognome.AutoSize = true;
            lbBestCognome.BackColor = Color.FromArgb(69, 91, 189);
            lbBestCognome.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lbBestCognome.ForeColor = Color.FromArgb(0, 126, 250);
            lbBestCognome.Location = new Point(128, 44);
            lbBestCognome.Name = "lbBestCognome";
            lbBestCognome.Size = new Size(92, 25);
            lbBestCognome.TabIndex = 2;
            lbBestCognome.Text = "cognome";
            lbBestCognome.Click += lbBestCognome_Click;
            // 
            // lbBestNome
            // 
            lbBestNome.AutoSize = true;
            lbBestNome.BackColor = Color.FromArgb(69, 91, 189);
            lbBestNome.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lbBestNome.ForeColor = Color.FromArgb(0, 126, 250);
            lbBestNome.Location = new Point(128, 16);
            lbBestNome.Name = "lbBestNome";
            lbBestNome.Size = new Size(61, 25);
            lbBestNome.TabIndex = 1;
            lbBestNome.Text = "nome";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(69, 91, 189);
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(108, 137);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // lbIntestazioneOrari
            // 
            lbIntestazioneOrari.AutoSize = true;
            lbIntestazioneOrari.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lbIntestazioneOrari.ForeColor = Color.FromArgb(0, 126, 250);
            lbIntestazioneOrari.Location = new Point(76, 359);
            lbIntestazioneOrari.Name = "lbIntestazioneOrari";
            lbIntestazioneOrari.Size = new Size(106, 32);
            lbIntestazioneOrari.TabIndex = 3;
            lbIntestazioneOrari.Text = "Orari⏰";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(0, 126, 250);
            label1.Location = new Point(251, 365);
            label1.Name = "label1";
            label1.Size = new Size(208, 25);
            label1.TabIndex = 4;
            label1.Text = "Impiegato del Mese\U0001f947";
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(54, 70, 121);
            panel5.Controls.Add(label7);
            panel5.Controls.Add(label6);
            panel5.Controls.Add(label5);
            panel5.Controls.Add(label4);
            panel5.Controls.Add(lbNomeNewLavoratore);
            panel5.Controls.Add(tbIndirizzoNewLavoratore);
            panel5.Controls.Add(tbCognomeNewLavoratore);
            panel5.Controls.Add(tbStipendio);
            panel5.Controls.Add(tbTelefonoNewLavoratore);
            panel5.Controls.Add(tbNomeNewLavoratore);
            panel5.Controls.Add(btnAggiungiNewLavoratore);
            panel5.Location = new Point(487, 32);
            panel5.Name = "panel5";
            panel5.Size = new Size(250, 502);
            panel5.TabIndex = 5;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.FromArgb(69, 91, 189);
            label7.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.FromArgb(0, 126, 250);
            label7.Location = new Point(30, 330);
            label7.Name = "label7";
            label7.Size = new Size(103, 25);
            label7.TabIndex = 13;
            label7.Text = "Stipendio:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.FromArgb(69, 91, 189);
            label6.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.FromArgb(0, 126, 250);
            label6.Location = new Point(30, 257);
            label6.Name = "label6";
            label6.Size = new Size(173, 25);
            label6.TabIndex = 12;
            label6.Text = "Numero Telefono:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.FromArgb(69, 91, 189);
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(0, 126, 250);
            label5.Location = new Point(30, 179);
            label5.Name = "label5";
            label5.Size = new Size(95, 25);
            label5.TabIndex = 11;
            label5.Text = "Indirizzo:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(69, 91, 189);
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(0, 126, 250);
            label4.Location = new Point(30, 102);
            label4.Name = "label4";
            label4.Size = new Size(104, 25);
            label4.TabIndex = 10;
            label4.Text = "Cognome:";
            // 
            // lbNomeNewLavoratore
            // 
            lbNomeNewLavoratore.AutoSize = true;
            lbNomeNewLavoratore.BackColor = Color.FromArgb(69, 91, 189);
            lbNomeNewLavoratore.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lbNomeNewLavoratore.ForeColor = Color.FromArgb(0, 126, 250);
            lbNomeNewLavoratore.Location = new Point(32, 26);
            lbNomeNewLavoratore.Name = "lbNomeNewLavoratore";
            lbNomeNewLavoratore.Size = new Size(71, 25);
            lbNomeNewLavoratore.TabIndex = 9;
            lbNomeNewLavoratore.Text = "Nome:";
            // 
            // tbIndirizzoNewLavoratore
            // 
            tbIndirizzoNewLavoratore.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tbIndirizzoNewLavoratore.ForeColor = Color.FromArgb(0, 126, 250);
            tbIndirizzoNewLavoratore.Location = new Point(30, 217);
            tbIndirizzoNewLavoratore.Name = "tbIndirizzoNewLavoratore";
            tbIndirizzoNewLavoratore.Size = new Size(173, 29);
            tbIndirizzoNewLavoratore.TabIndex = 5;
            // 
            // tbCognomeNewLavoratore
            // 
            tbCognomeNewLavoratore.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            tbCognomeNewLavoratore.ForeColor = Color.FromArgb(0, 126, 250);
            tbCognomeNewLavoratore.Location = new Point(30, 139);
            tbCognomeNewLavoratore.Name = "tbCognomeNewLavoratore";
            tbCognomeNewLavoratore.Size = new Size(191, 29);
            tbCognomeNewLavoratore.TabIndex = 4;
            // 
            // tbStipendio
            // 
            tbStipendio.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            tbStipendio.ForeColor = Color.FromArgb(0, 126, 250);
            tbStipendio.Location = new Point(30, 368);
            tbStipendio.Name = "tbStipendio";
            tbStipendio.Size = new Size(104, 39);
            tbStipendio.TabIndex = 3;
            // 
            // tbTelefonoNewLavoratore
            // 
            tbTelefonoNewLavoratore.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tbTelefonoNewLavoratore.ForeColor = Color.FromArgb(0, 126, 250);
            tbTelefonoNewLavoratore.Location = new Point(30, 294);
            tbTelefonoNewLavoratore.Name = "tbTelefonoNewLavoratore";
            tbTelefonoNewLavoratore.Size = new Size(191, 29);
            tbTelefonoNewLavoratore.TabIndex = 2;
            // 
            // tbNomeNewLavoratore
            // 
            tbNomeNewLavoratore.BackColor = Color.White;
            tbNomeNewLavoratore.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            tbNomeNewLavoratore.ForeColor = Color.FromArgb(0, 126, 250);
            tbNomeNewLavoratore.Location = new Point(30, 63);
            tbNomeNewLavoratore.Name = "tbNomeNewLavoratore";
            tbNomeNewLavoratore.Size = new Size(191, 29);
            tbNomeNewLavoratore.TabIndex = 1;
            // 
            // btnAggiungiNewLavoratore
            // 
            btnAggiungiNewLavoratore.AutoEllipsis = true;
            btnAggiungiNewLavoratore.BackColor = Color.FromArgb(69, 91, 189);
            btnAggiungiNewLavoratore.Cursor = Cursors.Hand;
            btnAggiungiNewLavoratore.FlatStyle = FlatStyle.Flat;
            btnAggiungiNewLavoratore.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnAggiungiNewLavoratore.ForeColor = SystemColors.Control;
            btnAggiungiNewLavoratore.Location = new Point(70, 425);
            btnAggiungiNewLavoratore.Name = "btnAggiungiNewLavoratore";
            btnAggiungiNewLavoratore.Size = new Size(108, 33);
            btnAggiungiNewLavoratore.TabIndex = 0;
            btnAggiungiNewLavoratore.Text = "Assumi";
            btnAggiungiNewLavoratore.UseVisualStyleBackColor = false;
            btnAggiungiNewLavoratore.Click += btnAggiungiNewLavoratore_Click;
            // 
            // lbNuovoLavoratore
            // 
            lbNuovoLavoratore.AutoSize = true;
            lbNuovoLavoratore.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lbNuovoLavoratore.ForeColor = Color.FromArgb(0, 126, 250);
            lbNuovoLavoratore.Location = new Point(503, -6);
            lbNuovoLavoratore.Name = "lbNuovoLavoratore";
            lbNuovoLavoratore.Size = new Size(228, 32);
            lbNuovoLavoratore.TabIndex = 8;
            lbNuovoLavoratore.Text = "Nuovo Lavoratore:";
            // 
            // FormLavoratori
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 51, 73);
            ClientSize = new Size(749, 549);
            Controls.Add(lbNuovoLavoratore);
            Controls.Add(panel5);
            Controls.Add(label1);
            Controls.Add(lbIntestazioneOrari);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(pnlLavoratoriView);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormLavoratori";
            Text = "FormLavoratori";
            pnlLavoratoriView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvLavoratori).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlLavoratoriView;
        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Label lbBestCognome;
        private Label lbBestNome;
        private Panel panel3;
        private Label label2;
        private Panel panel4;
        private Label lbOrario2;
        private Label lborarioLunVen;
        private Label lbIntestazioneOrari;
        private Label label1;
        private Label label3;
        private DataGridView dgvLavoratori;
        private Panel panel5;
        private Button btnAggiungiNewLavoratore;
        private Label lbNuovoLavoratore;
        private TextBox tbIndirizzoNewLavoratore;
        private TextBox tbCognomeNewLavoratore;
        private TextBox tbStipendio;
        private TextBox tbTelefonoNewLavoratore;
        private TextBox tbNomeNewLavoratore;
        private Label label5;
        private Label label4;
        private Label lbNomeNewLavoratore;
        private Label label7;
        private Label label6;
        private Label lbBestOreLavorate;
        private Label lbBestOreLavorateText;
    }
}