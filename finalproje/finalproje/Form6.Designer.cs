namespace finalproje
{
    partial class Form6
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
            txtPersİsim = new TextBox();
            label7 = new Label();
            txtBolumID = new TextBox();
            label6 = new Label();
            btnSil = new Button();
            btnDegistir = new Button();
            btnEkle = new Button();
            txtEvrakTuru = new TextBox();
            txtEvrakID = new TextBox();
            label4 = new Label();
            label3 = new Label();
            txtEvrakAd = new TextBox();
            label2 = new Label();
            txtAra = new TextBox();
            label1 = new Label();
            dgwListe = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgwListe).BeginInit();
            SuspendLayout();
            // 
            // txtPersİsim
            // 
            txtPersİsim.Location = new Point(419, 251);
            txtPersİsim.Name = "txtPersİsim";
            txtPersİsim.Size = new Size(151, 27);
            txtPersİsim.TabIndex = 36;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(318, 258);
            label7.Name = "label7";
            label7.Size = new Size(95, 20);
            label7.TabIndex = 35;
            label7.Text = "Personel İsim";
            // 
            // txtBolumID
            // 
            txtBolumID.Enabled = false;
            txtBolumID.Location = new Point(116, 251);
            txtBolumID.Name = "txtBolumID";
            txtBolumID.Size = new Size(156, 27);
            txtBolumID.TabIndex = 34;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 258);
            label6.Name = "label6";
            label6.Size = new Size(24, 20);
            label6.TabIndex = 33;
            label6.Text = "ID";
            // 
            // btnSil
            // 
            btnSil.Image = Properties.Resources.uu_logo;
            btnSil.Location = new Point(789, 391);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(135, 103);
            btnSil.TabIndex = 32;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click;
            // 
            // btnDegistir
            // 
            btnDegistir.Image = Properties.Resources.uu_logo;
            btnDegistir.Location = new Point(570, 391);
            btnDegistir.Name = "btnDegistir";
            btnDegistir.Size = new Size(135, 103);
            btnDegistir.TabIndex = 31;
            btnDegistir.Text = "Değiştir";
            btnDegistir.UseVisualStyleBackColor = true;
            btnDegistir.Click += btnDegistir_Click;
            // 
            // btnEkle
            // 
            btnEkle.Image = Properties.Resources.uu_logo;
            btnEkle.Location = new Point(354, 391);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(135, 103);
            btnEkle.TabIndex = 30;
            btnEkle.Text = "Ekle";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // txtEvrakTuru
            // 
            txtEvrakTuru.Location = new Point(1060, 251);
            txtEvrakTuru.Name = "txtEvrakTuru";
            txtEvrakTuru.Size = new Size(156, 27);
            txtEvrakTuru.TabIndex = 28;
            // 
            // txtEvrakID
            // 
            txtEvrakID.Location = new Point(116, 299);
            txtEvrakID.Name = "txtEvrakID";
            txtEvrakID.Size = new Size(156, 27);
            txtEvrakID.TabIndex = 26;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 302);
            label4.Name = "label4";
            label4.Size = new Size(63, 20);
            label4.TabIndex = 25;
            label4.Text = "Evrak ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(956, 256);
            label3.Name = "label3";
            label3.Size = new Size(77, 20);
            label3.TabIndex = 24;
            label3.Text = "Evrak Türü";
            // 
            // txtEvrakAd
            // 
            txtEvrakAd.Location = new Point(735, 255);
            txtEvrakAd.Name = "txtEvrakAd";
            txtEvrakAd.Size = new Size(156, 27);
            txtEvrakAd.TabIndex = 23;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(631, 258);
            label2.Name = "label2";
            label2.Size = new Size(71, 20);
            label2.TabIndex = 22;
            label2.Text = "Evrak Adı";
            // 
            // txtAra
            // 
            txtAra.Location = new Point(116, 214);
            txtAra.Name = "txtAra";
            txtAra.Size = new Size(1100, 27);
            txtAra.TabIndex = 21;
            txtAra.TextChanged += txtAra_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 217);
            label1.Name = "label1";
            label1.Size = new Size(32, 20);
            label1.TabIndex = 20;
            label1.Text = "Ara";
            // 
            // dgwListe
            // 
            dgwListe.AllowUserToAddRows = false;
            dgwListe.AllowUserToDeleteRows = false;
            dgwListe.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgwListe.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwListe.Location = new Point(12, 12);
            dgwListe.Name = "dgwListe";
            dgwListe.ReadOnly = true;
            dgwListe.RowHeadersWidth = 51;
            dgwListe.RowTemplate.Height = 29;
            dgwListe.Size = new Size(1216, 188);
            dgwListe.TabIndex = 19;
            dgwListe.CellEnter += dgwListe_CellEnter;
            // 
            // Form6
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Cyan;
            ClientSize = new Size(1230, 574);
            Controls.Add(txtPersİsim);
            Controls.Add(label7);
            Controls.Add(txtBolumID);
            Controls.Add(label6);
            Controls.Add(btnSil);
            Controls.Add(btnDegistir);
            Controls.Add(btnEkle);
            Controls.Add(txtEvrakTuru);
            Controls.Add(txtEvrakID);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtEvrakAd);
            Controls.Add(label2);
            Controls.Add(txtAra);
            Controls.Add(label1);
            Controls.Add(dgwListe);
            Name = "Form6";
            Text = "Bölüm Evrakları";
            Load += Form6_Load;
            ((System.ComponentModel.ISupportInitialize)dgwListe).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtPersİsim;
        private Label label7;
        private TextBox txtBolumID;
        private Label label6;
        private Button btnSil;
        private Button btnDegistir;
        private Button btnEkle;
        private TextBox txtEvrakTuru;
        private TextBox txtEvrakID;
        private Label label4;
        private Label label3;
        private TextBox txtEvrakAd;
        private Label label2;
        private TextBox txtAra;
        private Label label1;
        private DataGridView dgwListe;
    }
}