namespace finalproje
{
    partial class Form3
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
            txtAlınanMal = new TextBox();
            label7 = new Label();
            txtfaturaID = new TextBox();
            label6 = new Label();
            btnSil = new Button();
            btnDegistir = new Button();
            btnEkle = new Button();
            label3 = new Label();
            txtAlınanAdet = new TextBox();
            label2 = new Label();
            txtAra = new TextBox();
            label1 = new Label();
            dgwListe = new DataGridView();
            dateAlınanTarih = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)dgwListe).BeginInit();
            SuspendLayout();
            // 
            // txtAlınanMal
            // 
            txtAlınanMal.Location = new Point(444, 275);
            txtAlınanMal.Name = "txtAlınanMal";
            txtAlınanMal.Size = new Size(151, 27);
            txtAlınanMal.TabIndex = 36;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(302, 278);
            label7.Name = "label7";
            label7.Size = new Size(117, 20);
            label7.TabIndex = 35;
            label7.Text = "Satın Alınan Mal";
            // 
            // txtfaturaID
            // 
            txtfaturaID.Enabled = false;
            txtfaturaID.Location = new Point(103, 275);
            txtfaturaID.Name = "txtfaturaID";
            txtfaturaID.Size = new Size(156, 27);
            txtfaturaID.TabIndex = 34;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(8, 278);
            label6.Name = "label6";
            label6.Size = new Size(68, 20);
            label6.TabIndex = 33;
            label6.Text = "Fatura ID";
            // 
            // btnSil
            // 
            btnSil.Image = Properties.Resources.uu_logo;
            btnSil.Location = new Point(737, 366);
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
            btnDegistir.Location = new Point(518, 366);
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
            btnEkle.Location = new Point(302, 366);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(135, 103);
            btnEkle.TabIndex = 30;
            btnEkle.Text = "Ekle";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(941, 278);
            label3.Name = "label3";
            label3.Size = new Size(116, 20);
            label3.TabIndex = 24;
            label3.Text = "Satın Alım Tarihi";
            // 
            // txtAlınanAdet
            // 
            txtAlınanAdet.Location = new Point(740, 275);
            txtAlınanAdet.Name = "txtAlınanAdet";
            txtAlınanAdet.Size = new Size(156, 27);
            txtAlınanAdet.TabIndex = 23;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(636, 278);
            label2.Name = "label2";
            label2.Size = new Size(87, 20);
            label2.TabIndex = 22;
            label2.Text = "Alınan Adet";
            // 
            // txtAra
            // 
            txtAra.Location = new Point(122, 216);
            txtAra.Name = "txtAra";
            txtAra.Size = new Size(1079, 27);
            txtAra.TabIndex = 21;
            txtAra.TextChanged += txtAra_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(44, 216);
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
            // dateAlınanTarih
            // 
            dateAlınanTarih.Format = DateTimePickerFormat.Short;
            dateAlınanTarih.ImeMode = ImeMode.NoControl;
            dateAlınanTarih.Location = new Point(1063, 273);
            dateAlınanTarih.Name = "dateAlınanTarih";
            dateAlınanTarih.Size = new Size(138, 27);
            dateAlınanTarih.TabIndex = 37;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Cyan;
            ClientSize = new Size(1230, 574);
            Controls.Add(dateAlınanTarih);
            Controls.Add(txtAlınanMal);
            Controls.Add(label7);
            Controls.Add(txtfaturaID);
            Controls.Add(label6);
            Controls.Add(btnSil);
            Controls.Add(btnDegistir);
            Controls.Add(btnEkle);
            Controls.Add(label3);
            Controls.Add(txtAlınanAdet);
            Controls.Add(label2);
            Controls.Add(txtAra);
            Controls.Add(label1);
            Controls.Add(dgwListe);
            Name = "Form3";
            Text = "Muhasebe Evrakları";
            Load += Form3_Load;
            ((System.ComponentModel.ISupportInitialize)dgwListe).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtAlınanMal;
        private Label label7;
        private TextBox txtfaturaID;
        private Label label6;
        private Button btnSil;
        private Button btnDegistir;
        private Button btnEkle;
        private Label label3;
        private TextBox txtAlınanAdet;
        private Label label2;
        private TextBox txtAra;
        private Label label1;
        private DataGridView dgwListe;
        private DateTimePicker dateAlınanTarih;
    }
}