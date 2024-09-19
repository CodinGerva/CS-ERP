namespace GiardinaggioIntensivo
{
    partial class FormGestioneLavori
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
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            label3 = new Label();
            label2 = new Label();
            lbElencoLavori = new Label();
            lbElencoUtensili = new Label();
            panel4 = new Panel();
            tbPrezzoUtensile = new TextBox();
            btnAggiungiGiardino = new Button();
            label11 = new Label();
            tbCondizioniUtensile = new TextBox();
            label13 = new Label();
            tbNomeUtensile = new TextBox();
            label10 = new Label();
            panel3 = new Panel();
            cbUtensile = new ComboBox();
            cbLavoratori = new ComboBox();
            cbProprietarioLavori = new ComboBox();
            lbUtensile = new Label();
            dtpLavori = new DateTimePicker();
            btnAggiungiNewLavoratore = new Button();
            tbPrezzoLavoro = new TextBox();
            lbLavoratoreLavori = new Label();
            label7 = new Label();
            label5 = new Label();
            label4 = new Label();
            tbOreLavoro = new TextBox();
            label6 = new Label();
            panel2 = new Panel();
            dgvUtensiliList = new DataGridView();
            panel1 = new Panel();
            dgvLavoriList = new DataGridView();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUtensiliList).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLavoriList).BeginInit();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(69, 91, 189);
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(0, 126, 250);
            label3.Location = new Point(535, 338);
            label3.Name = "label3";
            label3.Size = new Size(159, 25);
            label3.TabIndex = 21;
            label3.Text = "Compra Utensile";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(69, 91, 189);
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(0, 126, 250);
            label2.Location = new Point(535, -1);
            label2.Name = "label2";
            label2.Size = new Size(140, 25);
            label2.TabIndex = 20;
            label2.Text = "Nuovo Lavoro";
            // 
            // lbElencoLavori
            // 
            lbElencoLavori.AutoSize = true;
            lbElencoLavori.BackColor = Color.FromArgb(69, 91, 189);
            lbElencoLavori.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lbElencoLavori.ForeColor = Color.FromArgb(0, 126, 250);
            lbElencoLavori.Location = new Point(12, -1);
            lbElencoLavori.Name = "lbElencoLavori";
            lbElencoLavori.Size = new Size(183, 25);
            lbElencoLavori.TabIndex = 19;
            lbElencoLavori.Text = "Elenco Lavori Totali";
            // 
            // lbElencoUtensili
            // 
            lbElencoUtensili.AutoSize = true;
            lbElencoUtensili.BackColor = Color.FromArgb(69, 91, 189);
            lbElencoUtensili.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lbElencoUtensili.ForeColor = Color.FromArgb(0, 126, 250);
            lbElencoUtensili.Location = new Point(12, 338);
            lbElencoUtensili.Name = "lbElencoUtensili";
            lbElencoUtensili.Size = new Size(141, 25);
            lbElencoUtensili.TabIndex = 18;
            lbElencoUtensili.Text = "Elenco Utensili";
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(54, 70, 121);
            panel4.Controls.Add(tbPrezzoUtensile);
            panel4.Controls.Add(btnAggiungiGiardino);
            panel4.Controls.Add(label11);
            panel4.Controls.Add(tbCondizioniUtensile);
            panel4.Controls.Add(label13);
            panel4.Controls.Add(tbNomeUtensile);
            panel4.Controls.Add(label10);
            panel4.Location = new Point(478, 366);
            panel4.Name = "panel4";
            panel4.Size = new Size(259, 174);
            panel4.TabIndex = 17;
            panel4.Paint += panel4_Paint;
            // 
            // tbPrezzoUtensile
            // 
            tbPrezzoUtensile.BackColor = Color.White;
            tbPrezzoUtensile.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            tbPrezzoUtensile.ForeColor = Color.FromArgb(0, 126, 250);
            tbPrezzoUtensile.Location = new Point(87, 65);
            tbPrezzoUtensile.Name = "tbPrezzoUtensile";
            tbPrezzoUtensile.Size = new Size(142, 25);
            tbPrezzoUtensile.TabIndex = 39;
            // 
            // btnAggiungiGiardino
            // 
            btnAggiungiGiardino.AutoEllipsis = true;
            btnAggiungiGiardino.BackColor = Color.FromArgb(69, 91, 189);
            btnAggiungiGiardino.Cursor = Cursors.Hand;
            btnAggiungiGiardino.FlatStyle = FlatStyle.Flat;
            btnAggiungiGiardino.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnAggiungiGiardino.ForeColor = SystemColors.Control;
            btnAggiungiGiardino.Location = new Point(48, 133);
            btnAggiungiGiardino.Name = "btnAggiungiGiardino";
            btnAggiungiGiardino.Size = new Size(146, 33);
            btnAggiungiGiardino.TabIndex = 38;
            btnAggiungiGiardino.Text = "Compra";
            btnAggiungiGiardino.UseVisualStyleBackColor = false;
            btnAggiungiGiardino.Click += btnAggiungiGiardino_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.FromArgb(69, 91, 189);
            label11.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = Color.FromArgb(0, 126, 250);
            label11.Location = new Point(9, 25);
            label11.Name = "label11";
            label11.Size = new Size(66, 25);
            label11.TabIndex = 31;
            label11.Text = "Nome";
            // 
            // tbCondizioniUtensile
            // 
            tbCondizioniUtensile.BackColor = Color.White;
            tbCondizioniUtensile.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            tbCondizioniUtensile.ForeColor = Color.FromArgb(0, 126, 250);
            tbCondizioniUtensile.Location = new Point(123, 102);
            tbCondizioniUtensile.Name = "tbCondizioniUtensile";
            tbCondizioniUtensile.Size = new Size(106, 25);
            tbCondizioniUtensile.TabIndex = 37;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.FromArgb(69, 91, 189);
            label13.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label13.ForeColor = Color.FromArgb(0, 126, 250);
            label13.Location = new Point(9, 65);
            label13.Name = "label13";
            label13.Size = new Size(72, 25);
            label13.TabIndex = 28;
            label13.Text = "Prezzo";
            // 
            // tbNomeUtensile
            // 
            tbNomeUtensile.BackColor = Color.White;
            tbNomeUtensile.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            tbNomeUtensile.ForeColor = Color.FromArgb(0, 126, 250);
            tbNomeUtensile.Location = new Point(81, 25);
            tbNomeUtensile.Name = "tbNomeUtensile";
            tbNomeUtensile.Size = new Size(148, 25);
            tbNomeUtensile.TabIndex = 36;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.FromArgb(69, 91, 189);
            label10.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = Color.FromArgb(0, 126, 250);
            label10.Location = new Point(9, 102);
            label10.Name = "label10";
            label10.Size = new Size(108, 25);
            label10.TabIndex = 32;
            label10.Text = "Condizioni";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(54, 70, 121);
            panel3.Controls.Add(cbUtensile);
            panel3.Controls.Add(cbLavoratori);
            panel3.Controls.Add(cbProprietarioLavori);
            panel3.Controls.Add(lbUtensile);
            panel3.Controls.Add(dtpLavori);
            panel3.Controls.Add(btnAggiungiNewLavoratore);
            panel3.Controls.Add(tbPrezzoLavoro);
            panel3.Controls.Add(lbLavoratoreLavori);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(tbOreLavoro);
            panel3.Controls.Add(label6);
            panel3.Location = new Point(478, 37);
            panel3.Name = "panel3";
            panel3.Size = new Size(259, 285);
            panel3.TabIndex = 16;
            // 
            // cbUtensile
            // 
            cbUtensile.FormattingEnabled = true;
            cbUtensile.Location = new Point(95, 193);
            cbUtensile.Name = "cbUtensile";
            cbUtensile.Size = new Size(152, 23);
            cbUtensile.TabIndex = 32;
            cbUtensile.SelectedIndexChanged += cbUtensile_SelectedIndexChanged;
            // 
            // cbLavoratori
            // 
            cbLavoratori.FormattingEnabled = true;
            cbLavoratori.Location = new Point(121, 159);
            cbLavoratori.Name = "cbLavoratori";
            cbLavoratori.Size = new Size(125, 23);
            cbLavoratori.TabIndex = 31;
            // 
            // cbProprietarioLavori
            // 
            cbProprietarioLavori.FormattingEnabled = true;
            cbProprietarioLavori.Location = new Point(134, 126);
            cbProprietarioLavori.Name = "cbProprietarioLavori";
            cbProprietarioLavori.Size = new Size(113, 23);
            cbProprietarioLavori.TabIndex = 30;
            // 
            // lbUtensile
            // 
            lbUtensile.AutoSize = true;
            lbUtensile.BackColor = Color.FromArgb(69, 91, 189);
            lbUtensile.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lbUtensile.ForeColor = Color.FromArgb(0, 126, 250);
            lbUtensile.Location = new Point(6, 191);
            lbUtensile.Name = "lbUtensile";
            lbUtensile.Size = new Size(83, 25);
            lbUtensile.TabIndex = 29;
            lbUtensile.Text = "Utensile";
            // 
            // dtpLavori
            // 
            dtpLavori.Location = new Point(66, 91);
            dtpLavori.Name = "dtpLavori";
            dtpLavori.Size = new Size(181, 23);
            dtpLavori.TabIndex = 28;
            // 
            // btnAggiungiNewLavoratore
            // 
            btnAggiungiNewLavoratore.AutoEllipsis = true;
            btnAggiungiNewLavoratore.BackColor = Color.FromArgb(69, 91, 189);
            btnAggiungiNewLavoratore.Cursor = Cursors.Hand;
            btnAggiungiNewLavoratore.FlatStyle = FlatStyle.Flat;
            btnAggiungiNewLavoratore.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnAggiungiNewLavoratore.ForeColor = SystemColors.Control;
            btnAggiungiNewLavoratore.Location = new Point(81, 238);
            btnAggiungiNewLavoratore.Name = "btnAggiungiNewLavoratore";
            btnAggiungiNewLavoratore.Size = new Size(108, 33);
            btnAggiungiNewLavoratore.TabIndex = 27;
            btnAggiungiNewLavoratore.Text = "Inserisci";
            btnAggiungiNewLavoratore.UseVisualStyleBackColor = false;
            btnAggiungiNewLavoratore.Click += btnAggiungiNewLavoratore_Click;
            // 
            // tbPrezzoLavoro
            // 
            tbPrezzoLavoro.BackColor = Color.White;
            tbPrezzoLavoro.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            tbPrezzoLavoro.ForeColor = Color.FromArgb(0, 126, 250);
            tbPrezzoLavoro.Location = new Point(95, 19);
            tbPrezzoLavoro.Name = "tbPrezzoLavoro";
            tbPrezzoLavoro.Size = new Size(152, 25);
            tbPrezzoLavoro.TabIndex = 24;
            // 
            // lbLavoratoreLavori
            // 
            lbLavoratoreLavori.AutoSize = true;
            lbLavoratoreLavori.BackColor = Color.FromArgb(69, 91, 189);
            lbLavoratoreLavori.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lbLavoratoreLavori.ForeColor = Color.FromArgb(0, 126, 250);
            lbLavoratoreLavori.Location = new Point(8, 157);
            lbLavoratoreLavori.Name = "lbLavoratoreLavori";
            lbLavoratoreLavori.Size = new Size(109, 25);
            lbLavoratoreLavori.TabIndex = 23;
            lbLavoratoreLavori.Text = "Lavoratore";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.FromArgb(69, 91, 189);
            label7.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.FromArgb(0, 126, 250);
            label7.Location = new Point(7, 124);
            label7.Name = "label7";
            label7.Size = new Size(121, 25);
            label7.TabIndex = 21;
            label7.Text = "Proprietario";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.FromArgb(69, 91, 189);
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(0, 126, 250);
            label5.Location = new Point(7, 89);
            label5.Name = "label5";
            label5.Size = new Size(53, 25);
            label5.TabIndex = 19;
            label5.Text = "Data";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(69, 91, 189);
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(0, 126, 250);
            label4.Location = new Point(7, 54);
            label4.Name = "label4";
            label4.Size = new Size(126, 25);
            label4.TabIndex = 17;
            label4.Text = "Ore Richieste";
            // 
            // tbOreLavoro
            // 
            tbOreLavoro.BackColor = Color.White;
            tbOreLavoro.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            tbOreLavoro.ForeColor = Color.FromArgb(0, 126, 250);
            tbOreLavoro.Location = new Point(150, 54);
            tbOreLavoro.Name = "tbOreLavoro";
            tbOreLavoro.Size = new Size(97, 25);
            tbOreLavoro.TabIndex = 16;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.FromArgb(69, 91, 189);
            label6.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.FromArgb(0, 126, 250);
            label6.Location = new Point(7, 19);
            label6.Name = "label6";
            label6.Size = new Size(72, 25);
            label6.TabIndex = 15;
            label6.Text = "Prezzo";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(54, 70, 121);
            panel2.Controls.Add(dgvUtensiliList);
            panel2.Location = new Point(12, 366);
            panel2.Name = "panel2";
            panel2.Size = new Size(446, 174);
            panel2.TabIndex = 15;
            // 
            // dgvUtensiliList
            // 
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(54, 70, 121);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(64, 80, 131);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dgvUtensiliList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvUtensiliList.Anchor = AnchorStyles.None;
            dgvUtensiliList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvUtensiliList.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvUtensiliList.BackgroundColor = Color.FromArgb(69, 91, 189);
            dgvUtensiliList.BorderStyle = BorderStyle.None;
            dgvUtensiliList.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvUtensiliList.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(28, 92, 155);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.Window;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvUtensiliList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvUtensiliList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(8, 72, 135);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.ButtonHighlight;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvUtensiliList.DefaultCellStyle = dataGridViewCellStyle3;
            dgvUtensiliList.GridColor = Color.FromArgb(69, 91, 189);
            dgvUtensiliList.Location = new Point(12, 10);
            dgvUtensiliList.Margin = new Padding(3, 2, 3, 2);
            dgvUtensiliList.MultiSelect = false;
            dgvUtensiliList.Name = "dgvUtensiliList";
            dgvUtensiliList.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(8, 72, 135);
            dataGridViewCellStyle4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.Window;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvUtensiliList.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvUtensiliList.RowHeadersVisible = false;
            dgvUtensiliList.RowHeadersWidth = 60;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(8, 72, 135);
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(8, 72, 135);
            dgvUtensiliList.RowsDefaultCellStyle = dataGridViewCellStyle5;
            dgvUtensiliList.RowTemplate.Height = 29;
            dgvUtensiliList.ScrollBars = ScrollBars.Vertical;
            dgvUtensiliList.Size = new Size(422, 156);
            dgvUtensiliList.TabIndex = 3;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(54, 70, 121);
            panel1.Controls.Add(dgvLavoriList);
            panel1.Location = new Point(12, 37);
            panel1.Name = "panel1";
            panel1.Size = new Size(446, 285);
            panel1.TabIndex = 14;
            // 
            // dgvLavoriList
            // 
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(54, 70, 121);
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(64, 80, 131);
            dataGridViewCellStyle6.SelectionForeColor = Color.White;
            dgvLavoriList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            dgvLavoriList.Anchor = AnchorStyles.None;
            dgvLavoriList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvLavoriList.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvLavoriList.BackgroundColor = Color.FromArgb(69, 91, 189);
            dgvLavoriList.BorderStyle = BorderStyle.None;
            dgvLavoriList.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvLavoriList.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = Color.FromArgb(28, 92, 155);
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = SystemColors.Window;
            dataGridViewCellStyle7.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = Color.White;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            dgvLavoriList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dgvLavoriList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = Color.FromArgb(8, 72, 135);
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = SystemColors.ButtonHighlight;
            dataGridViewCellStyle8.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.False;
            dgvLavoriList.DefaultCellStyle = dataGridViewCellStyle8;
            dgvLavoriList.GridColor = Color.FromArgb(69, 91, 189);
            dgvLavoriList.Location = new Point(12, 19);
            dgvLavoriList.Margin = new Padding(3, 2, 3, 2);
            dgvLavoriList.MultiSelect = false;
            dgvLavoriList.Name = "dgvLavoriList";
            dgvLavoriList.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = Color.FromArgb(8, 72, 135);
            dataGridViewCellStyle9.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle9.ForeColor = SystemColors.Window;
            dataGridViewCellStyle9.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.True;
            dgvLavoriList.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            dgvLavoriList.RowHeadersVisible = false;
            dgvLavoriList.RowHeadersWidth = 60;
            dataGridViewCellStyle10.BackColor = Color.FromArgb(8, 72, 135);
            dataGridViewCellStyle10.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle10.SelectionBackColor = Color.FromArgb(8, 72, 135);
            dgvLavoriList.RowsDefaultCellStyle = dataGridViewCellStyle10;
            dgvLavoriList.RowTemplate.Height = 29;
            dgvLavoriList.ScrollBars = ScrollBars.Vertical;
            dgvLavoriList.Size = new Size(422, 252);
            dgvLavoriList.TabIndex = 3;
            // 
            // FormGestioneLavori
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 51, 73);
            ClientSize = new Size(749, 549);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lbElencoLavori);
            Controls.Add(lbElencoUtensili);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormGestioneLavori";
            Text = "FormGestioneLavori";
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvUtensiliList).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvLavoriList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private Label label2;
        private Label lbElencoLavori;
        private Label lbElencoUtensili;
        private Panel panel4;
        private Button btnAggiungiGiardino;
        private Label label11;
        private TextBox tbCondizioniUtensile;
        private Label label13;
        private TextBox tbNomeUtensile;
        private Label label10;
        private Panel panel3;
        private Button btnAggiungiNewLavoratore;
        private TextBox tbPrezzoLavoro;
        private Label lbLavoratoreLavori;
        private Label label7;
        private Label label5;
        private Label label4;
        private TextBox tbOreLavoro;
        private Label label6;
        private Panel panel2;
        private DataGridView dgvUtensiliList;
        private Panel panel1;
        private DataGridView dgvLavoriList;
        private TextBox tbPrezzoUtensile;
        private DateTimePicker dtpLavori;
        private ComboBox cbUtensile;
        private ComboBox cbLavoratori;
        private ComboBox cbProprietarioLavori;
        private Label lbUtensile;
    }
}