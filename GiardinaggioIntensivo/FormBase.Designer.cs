namespace GiardinaggioIntensivo
{
    partial class formHome
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formHome));
            pnlLateraleBase = new Panel();
            button6 = new Button();
            btnImpostazioni = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            btnLavoratori = new Button();
            panel2 = new Panel();
            lbSlogan = new Label();
            lbNomeAziendaMenu = new Label();
            pbLogo = new PictureBox();
            btnClose = new Button();
            lbTitoloPagina = new Label();
            pnlFormLoader = new Panel();
            pnlLateraleBase.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbLogo).BeginInit();
            SuspendLayout();
            // 
            // pnlLateraleBase
            // 
            pnlLateraleBase.BackColor = Color.FromArgb(24, 30, 54);
            pnlLateraleBase.Controls.Add(button6);
            pnlLateraleBase.Controls.Add(btnImpostazioni);
            pnlLateraleBase.Controls.Add(button4);
            pnlLateraleBase.Controls.Add(button3);
            pnlLateraleBase.Controls.Add(button2);
            pnlLateraleBase.Controls.Add(button1);
            pnlLateraleBase.Controls.Add(btnLavoratori);
            pnlLateraleBase.Controls.Add(panel2);
            pnlLateraleBase.Dock = DockStyle.Left;
            pnlLateraleBase.Location = new Point(0, 0);
            pnlLateraleBase.Name = "pnlLateraleBase";
            pnlLateraleBase.Size = new Size(186, 586);
            pnlLateraleBase.TabIndex = 0;
            pnlLateraleBase.Paint += panel1_Paint_1;
            // 
            // button6
            // 
            button6.Dock = DockStyle.Top;
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button6.ForeColor = Color.FromArgb(0, 126, 250);
            button6.Image = (Image)resources.GetObject("button6.Image");
            button6.ImageAlign = ContentAlignment.MiddleLeft;
            button6.Location = new Point(0, 312);
            button6.Name = "button6";
            button6.Size = new Size(186, 42);
            button6.TabIndex = 3;
            button6.Text = "Mappa";
            button6.TextImageRelation = TextImageRelation.TextBeforeImage;
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // btnImpostazioni
            // 
            btnImpostazioni.Dock = DockStyle.Bottom;
            btnImpostazioni.FlatAppearance.BorderSize = 0;
            btnImpostazioni.FlatStyle = FlatStyle.Flat;
            btnImpostazioni.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnImpostazioni.ForeColor = Color.FromArgb(0, 126, 250);
            btnImpostazioni.Image = (Image)resources.GetObject("btnImpostazioni.Image");
            btnImpostazioni.ImageAlign = ContentAlignment.MiddleRight;
            btnImpostazioni.Location = new Point(0, 544);
            btnImpostazioni.Name = "btnImpostazioni";
            btnImpostazioni.Size = new Size(186, 42);
            btnImpostazioni.TabIndex = 2;
            btnImpostazioni.Text = "Impostazioni";
            btnImpostazioni.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnImpostazioni.UseVisualStyleBackColor = true;
            btnImpostazioni.Click += btnImpostazioni_Click;
            // 
            // button4
            // 
            button4.Dock = DockStyle.Top;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button4.ForeColor = Color.FromArgb(0, 126, 250);
            button4.Image = (Image)resources.GetObject("button4.Image");
            button4.ImageAlign = ContentAlignment.MiddleLeft;
            button4.Location = new Point(0, 270);
            button4.Name = "button4";
            button4.Size = new Size(186, 42);
            button4.TabIndex = 2;
            button4.Text = "Lavori";
            button4.TextImageRelation = TextImageRelation.TextBeforeImage;
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.Dock = DockStyle.Top;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = Color.FromArgb(0, 126, 250);
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(0, 228);
            button3.Name = "button3";
            button3.Size = new Size(186, 42);
            button3.TabIndex = 1;
            button3.Text = "Clienti";
            button3.TextImageRelation = TextImageRelation.TextBeforeImage;
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Dock = DockStyle.Top;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.FromArgb(0, 126, 250);
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(0, 186);
            button2.Name = "button2";
            button2.Size = new Size(186, 42);
            button2.TabIndex = 1;
            button2.Text = "Lavoratori";
            button2.TextImageRelation = TextImageRelation.TextBeforeImage;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.FromArgb(0, 126, 250);
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(-3, 198);
            button1.Name = "button1";
            button1.Size = new Size(186, 42);
            button1.TabIndex = 1;
            button1.Text = "Lavoratori";
            button1.TextImageRelation = TextImageRelation.TextBeforeImage;
            button1.UseVisualStyleBackColor = true;
            // 
            // btnLavoratori
            // 
            btnLavoratori.Dock = DockStyle.Top;
            btnLavoratori.FlatAppearance.BorderSize = 0;
            btnLavoratori.FlatStyle = FlatStyle.Flat;
            btnLavoratori.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnLavoratori.ForeColor = Color.FromArgb(0, 126, 250);
            btnLavoratori.Image = (Image)resources.GetObject("btnLavoratori.Image");
            btnLavoratori.ImageAlign = ContentAlignment.MiddleLeft;
            btnLavoratori.Location = new Point(0, 144);
            btnLavoratori.Name = "btnLavoratori";
            btnLavoratori.Size = new Size(186, 42);
            btnLavoratori.TabIndex = 1;
            btnLavoratori.Text = "Homepage";
            btnLavoratori.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnLavoratori.UseVisualStyleBackColor = true;
            btnLavoratori.Click += btnLavoratori_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(lbSlogan);
            panel2.Controls.Add(lbNomeAziendaMenu);
            panel2.Controls.Add(pbLogo);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(186, 144);
            panel2.TabIndex = 0;
            // 
            // lbSlogan
            // 
            lbSlogan.AutoSize = true;
            lbSlogan.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            lbSlogan.ForeColor = Color.FromArgb(0, 126, 250);
            lbSlogan.Location = new Point(9, 121);
            lbSlogan.Name = "lbSlogan";
            lbSlogan.Size = new Size(172, 13);
            lbSlogan.TabIndex = 2;
            lbSlogan.Text = "Una nuova casa, a casa tua.";
            // 
            // lbNomeAziendaMenu
            // 
            lbNomeAziendaMenu.AutoSize = true;
            lbNomeAziendaMenu.BackColor = Color.Transparent;
            lbNomeAziendaMenu.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbNomeAziendaMenu.ForeColor = Color.Goldenrod;
            lbNomeAziendaMenu.Location = new Point(28, 94);
            lbNomeAziendaMenu.Name = "lbNomeAziendaMenu";
            lbNomeAziendaMenu.Size = new Size(132, 20);
            lbNomeAziendaMenu.TabIndex = 1;
            lbNomeAziendaMenu.Text = "Golden Garden";
            // 
            // pbLogo
            // 
            pbLogo.Anchor = AnchorStyles.None;
            pbLogo.Image = (Image)resources.GetObject("pbLogo.Image");
            pbLogo.ImageLocation = "";
            pbLogo.InitialImage = (Image)resources.GetObject("pbLogo.InitialImage");
            pbLogo.Location = new Point(47, 12);
            pbLogo.Name = "pbLogo";
            pbLogo.Size = new Size(93, 72);
            pbLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pbLogo.TabIndex = 0;
            pbLogo.TabStop = false;
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClose.BackColor = Color.FromArgb(56, 61, 83);
            btnClose.Cursor = Cursors.Hand;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.ForeColor = SystemColors.ButtonFace;
            btnClose.Location = new Point(901, 0);
            btnClose.Margin = new Padding(2);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(50, 21);
            btnClose.TabIndex = 2;
            btnClose.Text = "X";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // lbTitoloPagina
            // 
            lbTitoloPagina.AutoSize = true;
            lbTitoloPagina.BackColor = Color.Transparent;
            lbTitoloPagina.Font = new Font("Segoe UI Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbTitoloPagina.ForeColor = Color.FromArgb(112, 144, 228);
            lbTitoloPagina.Location = new Point(192, -3);
            lbTitoloPagina.Name = "lbTitoloPagina";
            lbTitoloPagina.Size = new Size(75, 30);
            lbTitoloPagina.TabIndex = 8;
            lbTitoloPagina.Text = "Home";
            lbTitoloPagina.TextAlign = ContentAlignment.MiddleCenter;
            lbTitoloPagina.Click += lbTitoloPagina_Click;
            // 
            // pnlFormLoader
            // 
            pnlFormLoader.Dock = DockStyle.Bottom;
            pnlFormLoader.Location = new Point(186, 30);
            pnlFormLoader.Name = "pnlFormLoader";
            pnlFormLoader.Size = new Size(765, 556);
            pnlFormLoader.TabIndex = 9;
            // 
            // formHome
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 51, 73);
            ClientSize = new Size(951, 586);
            Controls.Add(pnlFormLoader);
            Controls.Add(lbTitoloPagina);
            Controls.Add(btnClose);
            Controls.Add(pnlLateraleBase);
            FormBorderStyle = FormBorderStyle.None;
            Name = "formHome";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "mmm,,";
            Load += formHome_Load;
            pnlLateraleBase.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlLateraleBase;
        private Panel panel2;
        private PictureBox pbLogo;
        private Label lbNomeAziendaMenu;
        private Label lbSlogan;
        private Button btnImpostazioni;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private Button btnLavoratori;
        private Button btnClose;
        private Button button6;
        private Label lbTitoloPagina;
        private Panel pnlFormLoader;
    }
}