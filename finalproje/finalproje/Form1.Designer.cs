namespace finalproje
{
    partial class Form1
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
            dgwListe = new DataGridView();
            label1 = new Label();
            txtAra = new TextBox();
            txtAd = new TextBox();
            label2 = new Label();
            label3 = new Label();
            txtDers = new TextBox();
            label4 = new Label();
            txtNot = new TextBox();
            label5 = new Label();
            cmbBolum = new ComboBox();
            btnEkle = new Button();
            btnDegistir = new Button();
            btnSil = new Button();
            label6 = new Label();
            txtID = new TextBox();
            label7 = new Label();
            txtNo = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgwListe).BeginInit();
            SuspendLayout();
            // 
            // dgwListe
            // 
            dgwListe.AllowUserToAddRows = false;
            dgwListe.AllowUserToDeleteRows = false;
            dgwListe.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgwListe.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwListe.Location = new Point(2, 12);
            dgwListe.Name = "dgwListe";
            dgwListe.ReadOnly = true;
            dgwListe.RowHeadersWidth = 51;
            dgwListe.RowTemplate.Height = 29;
            dgwListe.Size = new Size(1216, 188);
            dgwListe.TabIndex = 0;
            dgwListe.CellEnter += dgwListe_CellEnter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 217);
            label1.Name = "label1";
            label1.Size = new Size(32, 20);
            label1.TabIndex = 1;
            label1.Text = "Ara";
            // 
            // txtAra
            // 
            txtAra.Location = new Point(106, 214);
            txtAra.Name = "txtAra";
            txtAra.Size = new Size(1100, 27);
            txtAra.TabIndex = 2;
            txtAra.TextChanged += txtAra_TextChanged;
            // 
            // txtAd
            // 
            txtAd.Location = new Point(708, 254);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(156, 27);
            txtAd.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(597, 257);
            label2.Name = "label2";
            label2.Size = new Size(88, 20);
            label2.TabIndex = 3;
            label2.Text = "Öğrenci Adı";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(930, 257);
            label3.Name = "label3";
            label3.Size = new Size(52, 20);
            label3.TabIndex = 5;
            label3.Text = "Bölüm";
            // 
            // txtDers
            // 
            txtDers.Location = new Point(106, 301);
            txtDers.Name = "txtDers";
            txtDers.Size = new Size(156, 27);
            txtDers.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(56, 304);
            label4.Name = "label4";
            label4.Size = new Size(39, 20);
            label4.TabIndex = 7;
            label4.Text = "Ders";
            // 
            // txtNot
            // 
            txtNot.Location = new Point(403, 301);
            txtNot.Name = "txtNot";
            txtNot.Size = new Size(156, 27);
            txtNot.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(350, 304);
            label5.Name = "label5";
            label5.Size = new Size(34, 20);
            label5.TabIndex = 9;
            label5.Text = "Not";
            // 
            // cmbBolum
            // 
            cmbBolum.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbBolum.FormattingEnabled = true;
            cmbBolum.Items.AddRange(new object[] { "ybs", "uti", "işletme" });
            cmbBolum.Location = new Point(1006, 254);
            cmbBolum.Name = "cmbBolum";
            cmbBolum.Size = new Size(151, 28);
            cmbBolum.TabIndex = 11;
            // 
            // btnEkle
            // 
            btnEkle.Image = Properties.Resources.uu_logo1;
            btnEkle.Location = new Point(326, 376);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(135, 103);
            btnEkle.TabIndex = 12;
            btnEkle.Text = "Ekle";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // btnDegistir
            // 
            btnDegistir.Image = Properties.Resources.uu_logo;
            btnDegistir.Location = new Point(566, 376);
            btnDegistir.Name = "btnDegistir";
            btnDegistir.Size = new Size(135, 103);
            btnDegistir.TabIndex = 13;
            btnDegistir.Text = "Değiştir";
            btnDegistir.UseVisualStyleBackColor = true;
            btnDegistir.Click += btnDegistir_Click;
            // 
            // btnSil
            // 
            btnSil.Image = Properties.Resources.uu_logo;
            btnSil.Location = new Point(805, 376);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(135, 103);
            btnSil.TabIndex = 14;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(15, 257);
            label6.Name = "label6";
            label6.Size = new Size(80, 20);
            label6.TabIndex = 15;
            label6.Text = "Öğrenci ID";
            label6.Click += label6_Click;
            // 
            // txtID
            // 
            txtID.Enabled = false;
            txtID.Location = new Point(106, 254);
            txtID.Name = "txtID";
            txtID.Size = new Size(156, 27);
            txtID.TabIndex = 16;
            txtID.TextChanged += txtID_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(299, 257);
            label7.Name = "label7";
            label7.Size = new Size(85, 20);
            label7.TabIndex = 17;
            label7.Text = "Öğrenci No";
            label7.Click += label7_Click;
            // 
            // txtNo
            // 
            txtNo.Location = new Point(403, 254);
            txtNo.Name = "txtNo";
            txtNo.Size = new Size(151, 27);
            txtNo.TabIndex = 18;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Cyan;
            ClientSize = new Size(1230, 574);
            Controls.Add(txtNo);
            Controls.Add(label7);
            Controls.Add(txtID);
            Controls.Add(label6);
            Controls.Add(btnSil);
            Controls.Add(btnDegistir);
            Controls.Add(btnEkle);
            Controls.Add(cmbBolum);
            Controls.Add(txtNot);
            Controls.Add(label5);
            Controls.Add(txtDers);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtAd);
            Controls.Add(label2);
            Controls.Add(txtAra);
            Controls.Add(label1);
            Controls.Add(dgwListe);
            Name = "Form1";
            Text = "Sınav Evrakları";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgwListe).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgwListe;
        private Label label1;
        private TextBox txtAra;
        private TextBox txtAd;
        private Label label2;
        private Label label3;
        private TextBox txtDers;
        private Label label4;
        private TextBox txtNot;
        private Label label5;
        private ComboBox cmbBolum;
        private Button btnEkle;
        private Button btnDegistir;
        private Button btnSil;
        private Label label6;
        private TextBox txtID;
        private Label label7;
        private TextBox txtNo;
    }
}