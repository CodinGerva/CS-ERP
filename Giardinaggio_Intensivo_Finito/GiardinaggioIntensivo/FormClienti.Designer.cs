namespace GiardinaggioIntensivo
{
    partial class FormClienti
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
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle13 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle14 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle15 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle16 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle17 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle18 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle19 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle20 = new DataGridViewCellStyle();
            panel1 = new Panel();
            dgvClientiList = new DataGridView();
            panel2 = new Panel();
            dgvGiardiniList = new DataGridView();
            panel3 = new Panel();
            btnAggiungiNewLavoratore = new Button();
            tbTelefonoCliente = new TextBox();
            tbIndirizzoCliente = new TextBox();
            tbNomeCliente = new TextBox();
            label8 = new Label();
            cbSelectGiardini = new ComboBox();
            label7 = new Label();
            label5 = new Label();
            label4 = new Label();
            tbCognomeCliente = new TextBox();
            label6 = new Label();
            panel4 = new Panel();
            label16 = new Label();
            label15 = new Label();
            label14 = new Label();
            label9 = new Label();
            udPosizioneY = new NumericUpDown();
            udPosizioneX = new NumericUpDown();
            udDimensioniY = new NumericUpDown();
            udDimensioniX = new NumericUpDown();
            btnAggiungiGiardino = new Button();
            label11 = new Label();
            tbCondizioniNewGiardino = new TextBox();
            label13 = new Label();
            tbIndirizzoNewGiardino = new TextBox();
            label12 = new Label();
            label10 = new Label();
            lbNomeNewLavoratore = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvClientiList).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvGiardiniList).BeginInit();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)udPosizioneY).BeginInit();
            ((System.ComponentModel.ISupportInitialize)udPosizioneX).BeginInit();
            ((System.ComponentModel.ISupportInitialize)udDimensioniY).BeginInit();
            ((System.ComponentModel.ISupportInitialize)udDimensioniX).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(54, 70, 121);
            panel1.Controls.Add(dgvClientiList);
            panel1.Location = new Point(12, 34);
            panel1.Name = "panel1";
            panel1.Size = new Size(460, 225);
            panel1.TabIndex = 0;
            // 
            // dgvClientiList
            // 
            dataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = Color.FromArgb(54, 70, 121);
            dataGridViewCellStyle11.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle11.SelectionBackColor = Color.FromArgb(64, 80, 131);
            dataGridViewCellStyle11.SelectionForeColor = Color.White;
            dgvClientiList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle11;
            dgvClientiList.Anchor = AnchorStyles.None;
            dgvClientiList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvClientiList.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvClientiList.BackgroundColor = Color.FromArgb(69, 91, 189);
            dgvClientiList.BorderStyle = BorderStyle.None;
            dgvClientiList.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvClientiList.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle12.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = Color.FromArgb(28, 92, 155);
            dataGridViewCellStyle12.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle12.ForeColor = SystemColors.Window;
            dataGridViewCellStyle12.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = Color.White;
            dataGridViewCellStyle12.WrapMode = DataGridViewTriState.True;
            dgvClientiList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12;
            dgvClientiList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle13.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.BackColor = Color.FromArgb(8, 72, 135);
            dataGridViewCellStyle13.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle13.ForeColor = SystemColors.ButtonHighlight;
            dataGridViewCellStyle13.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = DataGridViewTriState.False;
            dgvClientiList.DefaultCellStyle = dataGridViewCellStyle13;
            dgvClientiList.GridColor = Color.FromArgb(69, 91, 189);
            dgvClientiList.Location = new Point(13, 15);
            dgvClientiList.Margin = new Padding(3, 2, 3, 2);
            dgvClientiList.MultiSelect = false;
            dgvClientiList.Name = "dgvClientiList";
            dgvClientiList.ReadOnly = true;
            dataGridViewCellStyle14.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.BackColor = Color.FromArgb(8, 72, 135);
            dataGridViewCellStyle14.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle14.ForeColor = SystemColors.Window;
            dataGridViewCellStyle14.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = DataGridViewTriState.True;
            dgvClientiList.RowHeadersDefaultCellStyle = dataGridViewCellStyle14;
            dgvClientiList.RowHeadersVisible = false;
            dgvClientiList.RowHeadersWidth = 60;
            dataGridViewCellStyle15.BackColor = Color.FromArgb(8, 72, 135);
            dataGridViewCellStyle15.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle15.SelectionBackColor = Color.FromArgb(8, 72, 135);
            dgvClientiList.RowsDefaultCellStyle = dataGridViewCellStyle15;
            dgvClientiList.RowTemplate.Height = 29;
            dgvClientiList.ScrollBars = ScrollBars.Vertical;
            dgvClientiList.Size = new Size(434, 198);
            dgvClientiList.TabIndex = 3;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(54, 70, 121);
            panel2.Controls.Add(dgvGiardiniList);
            panel2.Location = new Point(12, 300);
            panel2.Name = "panel2";
            panel2.Size = new Size(385, 237);
            panel2.TabIndex = 1;
            // 
            // dgvGiardiniList
            // 
            dataGridViewCellStyle16.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle16.BackColor = Color.FromArgb(54, 70, 121);
            dataGridViewCellStyle16.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle16.SelectionBackColor = Color.FromArgb(64, 80, 131);
            dataGridViewCellStyle16.SelectionForeColor = Color.White;
            dgvGiardiniList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle16;
            dgvGiardiniList.Anchor = AnchorStyles.None;
            dgvGiardiniList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvGiardiniList.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvGiardiniList.BackgroundColor = Color.FromArgb(69, 91, 189);
            dgvGiardiniList.BorderStyle = BorderStyle.None;
            dgvGiardiniList.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvGiardiniList.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle17.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle17.BackColor = Color.FromArgb(28, 92, 155);
            dataGridViewCellStyle17.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle17.ForeColor = SystemColors.Window;
            dataGridViewCellStyle17.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle17.SelectionForeColor = Color.White;
            dataGridViewCellStyle17.WrapMode = DataGridViewTriState.True;
            dgvGiardiniList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
            dgvGiardiniList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle18.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle18.BackColor = Color.FromArgb(8, 72, 135);
            dataGridViewCellStyle18.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle18.ForeColor = SystemColors.ButtonHighlight;
            dataGridViewCellStyle18.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle18.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle18.WrapMode = DataGridViewTriState.False;
            dgvGiardiniList.DefaultCellStyle = dataGridViewCellStyle18;
            dgvGiardiniList.GridColor = Color.FromArgb(69, 91, 189);
            dgvGiardiniList.Location = new Point(14, 15);
            dgvGiardiniList.Margin = new Padding(3, 2, 3, 2);
            dgvGiardiniList.MultiSelect = false;
            dgvGiardiniList.Name = "dgvGiardiniList";
            dgvGiardiniList.ReadOnly = true;
            dataGridViewCellStyle19.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle19.BackColor = Color.FromArgb(8, 72, 135);
            dataGridViewCellStyle19.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle19.ForeColor = SystemColors.Window;
            dataGridViewCellStyle19.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle19.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle19.WrapMode = DataGridViewTriState.True;
            dgvGiardiniList.RowHeadersDefaultCellStyle = dataGridViewCellStyle19;
            dgvGiardiniList.RowHeadersVisible = false;
            dgvGiardiniList.RowHeadersWidth = 60;
            dataGridViewCellStyle20.BackColor = Color.FromArgb(8, 72, 135);
            dataGridViewCellStyle20.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle20.SelectionBackColor = Color.FromArgb(8, 72, 135);
            dgvGiardiniList.RowsDefaultCellStyle = dataGridViewCellStyle20;
            dgvGiardiniList.RowTemplate.Height = 29;
            dgvGiardiniList.ScrollBars = ScrollBars.Vertical;
            dgvGiardiniList.Size = new Size(354, 209);
            dgvGiardiniList.TabIndex = 3;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(54, 70, 121);
            panel3.Controls.Add(btnAggiungiNewLavoratore);
            panel3.Controls.Add(tbTelefonoCliente);
            panel3.Controls.Add(tbIndirizzoCliente);
            panel3.Controls.Add(tbNomeCliente);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(cbSelectGiardini);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(tbCognomeCliente);
            panel3.Controls.Add(label6);
            panel3.Location = new Point(490, 34);
            panel3.Name = "panel3";
            panel3.Size = new Size(247, 225);
            panel3.TabIndex = 2;
            // 
            // btnAggiungiNewLavoratore
            // 
            btnAggiungiNewLavoratore.AutoEllipsis = true;
            btnAggiungiNewLavoratore.BackColor = Color.FromArgb(69, 91, 189);
            btnAggiungiNewLavoratore.Cursor = Cursors.Hand;
            btnAggiungiNewLavoratore.FlatStyle = FlatStyle.Flat;
            btnAggiungiNewLavoratore.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnAggiungiNewLavoratore.ForeColor = SystemColors.Control;
            btnAggiungiNewLavoratore.Location = new Point(67, 186);
            btnAggiungiNewLavoratore.Name = "btnAggiungiNewLavoratore";
            btnAggiungiNewLavoratore.Size = new Size(108, 33);
            btnAggiungiNewLavoratore.TabIndex = 27;
            btnAggiungiNewLavoratore.Text = "Inserisci";
            btnAggiungiNewLavoratore.UseVisualStyleBackColor = false;
            btnAggiungiNewLavoratore.Click += btnAggiungiNewLavoratore_Click;
            // 
            // tbTelefonoCliente
            // 
            tbTelefonoCliente.BackColor = Color.White;
            tbTelefonoCliente.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            tbTelefonoCliente.ForeColor = Color.FromArgb(0, 126, 250);
            tbTelefonoCliente.Location = new Point(103, 124);
            tbTelefonoCliente.Name = "tbTelefonoCliente";
            tbTelefonoCliente.Size = new Size(133, 25);
            tbTelefonoCliente.TabIndex = 26;
            // 
            // tbIndirizzoCliente
            // 
            tbIndirizzoCliente.BackColor = Color.White;
            tbIndirizzoCliente.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            tbIndirizzoCliente.ForeColor = Color.FromArgb(0, 126, 250);
            tbIndirizzoCliente.Location = new Point(103, 89);
            tbIndirizzoCliente.Name = "tbIndirizzoCliente";
            tbIndirizzoCliente.Size = new Size(133, 25);
            tbIndirizzoCliente.TabIndex = 25;
            // 
            // tbNomeCliente
            // 
            tbNomeCliente.BackColor = Color.White;
            tbNomeCliente.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            tbNomeCliente.ForeColor = Color.FromArgb(0, 126, 250);
            tbNomeCliente.Location = new Point(84, 19);
            tbNomeCliente.Name = "tbNomeCliente";
            tbNomeCliente.Size = new Size(152, 25);
            tbNomeCliente.TabIndex = 24;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.FromArgb(69, 91, 189);
            label8.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.FromArgb(0, 126, 250);
            label8.Location = new Point(7, 155);
            label8.Name = "label8";
            label8.Size = new Size(90, 25);
            label8.TabIndex = 23;
            label8.Text = "Giardino";
            // 
            // cbSelectGiardini
            // 
            cbSelectGiardini.FormattingEnabled = true;
            cbSelectGiardini.Location = new Point(103, 157);
            cbSelectGiardini.Name = "cbSelectGiardini";
            cbSelectGiardini.Size = new Size(133, 23);
            cbSelectGiardini.TabIndex = 22;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.FromArgb(69, 91, 189);
            label7.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.FromArgb(0, 126, 250);
            label7.Location = new Point(7, 124);
            label7.Name = "label7";
            label7.Size = new Size(89, 25);
            label7.TabIndex = 21;
            label7.Text = "Telefono";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.FromArgb(69, 91, 189);
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(0, 126, 250);
            label5.Location = new Point(7, 89);
            label5.Name = "label5";
            label5.Size = new Size(90, 25);
            label5.TabIndex = 19;
            label5.Text = "Indirizzo";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(69, 91, 189);
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(0, 126, 250);
            label4.Location = new Point(7, 54);
            label4.Name = "label4";
            label4.Size = new Size(104, 25);
            label4.TabIndex = 17;
            label4.Text = "Cognome:";
            // 
            // tbCognomeCliente
            // 
            tbCognomeCliente.BackColor = Color.White;
            tbCognomeCliente.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            tbCognomeCliente.ForeColor = Color.FromArgb(0, 126, 250);
            tbCognomeCliente.Location = new Point(117, 54);
            tbCognomeCliente.Name = "tbCognomeCliente";
            tbCognomeCliente.Size = new Size(119, 25);
            tbCognomeCliente.TabIndex = 16;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.FromArgb(69, 91, 189);
            label6.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.FromArgb(0, 126, 250);
            label6.Location = new Point(7, 19);
            label6.Name = "label6";
            label6.Size = new Size(71, 25);
            label6.TabIndex = 15;
            label6.Text = "Nome:";
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(54, 70, 121);
            panel4.Controls.Add(label16);
            panel4.Controls.Add(label15);
            panel4.Controls.Add(label14);
            panel4.Controls.Add(label9);
            panel4.Controls.Add(udPosizioneY);
            panel4.Controls.Add(udPosizioneX);
            panel4.Controls.Add(udDimensioniY);
            panel4.Controls.Add(udDimensioniX);
            panel4.Controls.Add(btnAggiungiGiardino);
            panel4.Controls.Add(label11);
            panel4.Controls.Add(tbCondizioniNewGiardino);
            panel4.Controls.Add(label13);
            panel4.Controls.Add(tbIndirizzoNewGiardino);
            panel4.Controls.Add(label12);
            panel4.Controls.Add(label10);
            panel4.Location = new Point(414, 300);
            panel4.Name = "panel4";
            panel4.Size = new Size(323, 237);
            panel4.TabIndex = 3;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.BackColor = Color.FromArgb(69, 91, 189);
            label16.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label16.ForeColor = Color.FromArgb(0, 126, 250);
            label16.Location = new Point(227, 56);
            label16.Name = "label16";
            label16.Size = new Size(29, 25);
            label16.TabIndex = 46;
            label16.Text = "Y:";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.BackColor = Color.FromArgb(69, 91, 189);
            label15.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label15.ForeColor = Color.FromArgb(0, 126, 250);
            label15.Location = new Point(124, 56);
            label15.Name = "label15";
            label15.Size = new Size(29, 25);
            label15.TabIndex = 45;
            label15.Text = "X:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = Color.FromArgb(69, 91, 189);
            label14.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label14.ForeColor = Color.FromArgb(0, 126, 250);
            label14.Location = new Point(227, 11);
            label14.Name = "label14";
            label14.Size = new Size(29, 25);
            label14.TabIndex = 44;
            label14.Text = "Y:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.FromArgb(69, 91, 189);
            label9.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.FromArgb(0, 126, 250);
            label9.Location = new Point(126, 11);
            label9.Name = "label9";
            label9.Size = new Size(29, 25);
            label9.TabIndex = 43;
            label9.Text = "X:";
            // 
            // udPosizioneY
            // 
            udPosizioneY.BorderStyle = BorderStyle.None;
            udPosizioneY.Location = new Point(264, 59);
            udPosizioneY.Maximum = new decimal(new int[] { 400, 0, 0, 0 });
            udPosizioneY.Name = "udPosizioneY";
            udPosizioneY.Size = new Size(48, 19);
            udPosizioneY.TabIndex = 42;
            udPosizioneY.TextAlign = HorizontalAlignment.Center;
            // 
            // udPosizioneX
            // 
            udPosizioneX.BorderStyle = BorderStyle.None;
            udPosizioneX.Location = new Point(161, 59);
            udPosizioneX.Maximum = new decimal(new int[] { 500, 0, 0, 0 });
            udPosizioneX.Name = "udPosizioneX";
            udPosizioneX.Size = new Size(48, 19);
            udPosizioneX.TabIndex = 41;
            udPosizioneX.TextAlign = HorizontalAlignment.Center;
            // 
            // udDimensioniY
            // 
            udDimensioniY.BorderStyle = BorderStyle.None;
            udDimensioniY.Location = new Point(264, 14);
            udDimensioniY.Name = "udDimensioniY";
            udDimensioniY.Size = new Size(48, 19);
            udDimensioniY.TabIndex = 40;
            udDimensioniY.TextAlign = HorizontalAlignment.Center;
            // 
            // udDimensioniX
            // 
            udDimensioniX.BorderStyle = BorderStyle.None;
            udDimensioniX.Location = new Point(160, 14);
            udDimensioniX.Name = "udDimensioniX";
            udDimensioniX.Size = new Size(48, 19);
            udDimensioniX.TabIndex = 39;
            udDimensioniX.TextAlign = HorizontalAlignment.Center;
            // 
            // btnAggiungiGiardino
            // 
            btnAggiungiGiardino.AutoEllipsis = true;
            btnAggiungiGiardino.BackColor = Color.FromArgb(69, 91, 189);
            btnAggiungiGiardino.Cursor = Cursors.Hand;
            btnAggiungiGiardino.FlatStyle = FlatStyle.Flat;
            btnAggiungiGiardino.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnAggiungiGiardino.ForeColor = SystemColors.Control;
            btnAggiungiGiardino.Location = new Point(92, 191);
            btnAggiungiGiardino.Name = "btnAggiungiGiardino";
            btnAggiungiGiardino.Size = new Size(146, 33);
            btnAggiungiGiardino.TabIndex = 38;
            btnAggiungiGiardino.Text = "Inserisci";
            btnAggiungiGiardino.UseVisualStyleBackColor = false;
            btnAggiungiGiardino.Click += btnAggiungiGiardino_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.FromArgb(69, 91, 189);
            label11.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = Color.FromArgb(0, 126, 250);
            label11.Location = new Point(7, 143);
            label11.Name = "label11";
            label11.Size = new Size(90, 25);
            label11.TabIndex = 31;
            label11.Text = "Indirizzo";
            // 
            // tbCondizioniNewGiardino
            // 
            tbCondizioniNewGiardino.BackColor = Color.White;
            tbCondizioniNewGiardino.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            tbCondizioniNewGiardino.ForeColor = Color.FromArgb(0, 126, 250);
            tbCondizioniNewGiardino.Location = new Point(124, 102);
            tbCondizioniNewGiardino.Name = "tbCondizioniNewGiardino";
            tbCondizioniNewGiardino.Size = new Size(188, 25);
            tbCondizioniNewGiardino.TabIndex = 37;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.FromArgb(69, 91, 189);
            label13.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label13.ForeColor = Color.FromArgb(0, 126, 250);
            label13.Location = new Point(7, 11);
            label13.Name = "label13";
            label13.Size = new Size(112, 25);
            label13.TabIndex = 28;
            label13.Text = "Dimensioni";
            // 
            // tbIndirizzoNewGiardino
            // 
            tbIndirizzoNewGiardino.BackColor = Color.White;
            tbIndirizzoNewGiardino.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            tbIndirizzoNewGiardino.ForeColor = Color.FromArgb(0, 126, 250);
            tbIndirizzoNewGiardino.Location = new Point(103, 143);
            tbIndirizzoNewGiardino.Name = "tbIndirizzoNewGiardino";
            tbIndirizzoNewGiardino.Size = new Size(209, 25);
            tbIndirizzoNewGiardino.TabIndex = 36;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.FromArgb(69, 91, 189);
            label12.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label12.ForeColor = Color.FromArgb(0, 126, 250);
            label12.Location = new Point(7, 56);
            label12.Name = "label12";
            label12.Size = new Size(96, 25);
            label12.TabIndex = 30;
            label12.Text = "Posizione";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.FromArgb(69, 91, 189);
            label10.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = Color.FromArgb(0, 126, 250);
            label10.Location = new Point(7, 102);
            label10.Name = "label10";
            label10.Size = new Size(108, 25);
            label10.TabIndex = 32;
            label10.Text = "Condizioni";
            // 
            // lbNomeNewLavoratore
            // 
            lbNomeNewLavoratore.AutoSize = true;
            lbNomeNewLavoratore.BackColor = Color.FromArgb(69, 91, 189);
            lbNomeNewLavoratore.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lbNomeNewLavoratore.ForeColor = Color.FromArgb(0, 126, 250);
            lbNomeNewLavoratore.Location = new Point(12, 272);
            lbNomeNewLavoratore.Name = "lbNomeNewLavoratore";
            lbNomeNewLavoratore.Size = new Size(146, 25);
            lbNomeNewLavoratore.TabIndex = 10;
            lbNomeNewLavoratore.Text = "Elenco Giardini";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(69, 91, 189);
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(0, 126, 250);
            label1.Location = new Point(12, 6);
            label1.Name = "label1";
            label1.Size = new Size(131, 25);
            label1.TabIndex = 11;
            label1.Text = "Elenco Clienti";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(69, 91, 189);
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(0, 126, 250);
            label2.Location = new Point(545, 6);
            label2.Name = "label2";
            label2.Size = new Size(139, 25);
            label2.TabIndex = 12;
            label2.Text = "Nuovo Cliente";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(69, 91, 189);
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(0, 126, 250);
            label3.Location = new Point(497, 272);
            label3.Name = "label3";
            label3.Size = new Size(156, 25);
            label3.TabIndex = 13;
            label3.Text = "Nuovo Giardino";
            // 
            // FormClienti
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 51, 73);
            ClientSize = new Size(749, 549);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lbNomeNewLavoratore);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormClienti";
            Text = "FormClienti";
            Load += FormClienti_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvClientiList).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvGiardiniList).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)udPosizioneY).EndInit();
            ((System.ComponentModel.ISupportInitialize)udPosizioneX).EndInit();
            ((System.ComponentModel.ISupportInitialize)udDimensioniY).EndInit();
            ((System.ComponentModel.ISupportInitialize)udDimensioniX).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Label lbNomeNewLavoratore;
        private Label label1;
        private Label label2;
        private Label label3;
        private DataGridView dgvClientiList;
        private DataGridView dgvGiardiniList;
        private Label label7;
        private Label label5;
        private Label label4;
        private TextBox tbCognomeCliente;
        private Label label6;
        private TextBox tbTelefonoCliente;
        private TextBox tbIndirizzoCliente;
        private TextBox tbNomeCliente;
        private Label label8;
        private ComboBox cbSelectGiardini;
        private Button btnAggiungiNewLavoratore;
        private Button btnAggiungiGiardino;
        private Label label11;
        private TextBox tbCondizioniNewGiardino;
        private Label label13;
        private TextBox tbIndirizzoNewGiardino;
        private Label label12;
        private Label label10;
        private NumericUpDown udPosizioneY;
        private NumericUpDown udPosizioneX;
        private NumericUpDown udDimensioniY;
        private NumericUpDown udDimensioniX;
        private Label label16;
        private Label label15;
        private Label label14;
        private Label label9;
    }
}