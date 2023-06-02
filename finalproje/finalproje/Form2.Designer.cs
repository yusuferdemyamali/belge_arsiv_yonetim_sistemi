namespace finalproje
{
    partial class Form2
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtpersonelİsim = new TextBox();
            txtPersonelYas = new TextBox();
            txtPersonelEvrakID = new TextBox();
            txtPersonelTelNo = new TextBox();
            txtPersonelID = new TextBox();
            txtAra = new TextBox();
            cmbPersonelBolum = new ComboBox();
            dgwListe = new DataGridView();
            btnSil = new Button();
            btnDegistir = new Button();
            btnEkle = new Button();
            ((System.ComponentModel.ISupportInitialize)dgwListe).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(656, 274);
            label1.Name = "label1";
            label1.Size = new Size(36, 20);
            label1.TabIndex = 0;
            label1.Text = "İsim";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(411, 320);
            label2.Name = "label2";
            label2.Size = new Size(30, 20);
            label2.TabIndex = 1;
            label2.Text = "Yaş";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(82, 274);
            label3.Name = "label3";
            label3.Size = new Size(63, 20);
            label3.TabIndex = 2;
            label3.Text = "Evrak ID";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(921, 273);
            label4.Name = "label4";
            label4.Size = new Size(111, 20);
            label4.TabIndex = 3;
            label4.Text = "Personel Bölüm";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(28, 320);
            label5.Name = "label5";
            label5.Size = new Size(117, 20);
            label5.TabIndex = 4;
            label5.Text = "Personel Telefon";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(358, 274);
            label6.Name = "label6";
            label6.Size = new Size(83, 20);
            label6.TabIndex = 5;
            label6.Text = "Personel ID";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(113, 229);
            label7.Name = "label7";
            label7.Size = new Size(32, 20);
            label7.TabIndex = 6;
            label7.Text = "Ara";
            // 
            // txtpersonelİsim
            // 
            txtpersonelİsim.Location = new Point(721, 271);
            txtpersonelİsim.Name = "txtpersonelİsim";
            txtpersonelİsim.Size = new Size(125, 27);
            txtpersonelİsim.TabIndex = 7;
            txtpersonelİsim.TextChanged += textBox1_TextChanged;
            // 
            // txtPersonelYas
            // 
            txtPersonelYas.Location = new Point(475, 313);
            txtPersonelYas.Name = "txtPersonelYas";
            txtPersonelYas.Size = new Size(125, 27);
            txtPersonelYas.TabIndex = 8;
            // 
            // txtPersonelEvrakID
            // 
            txtPersonelEvrakID.Location = new Point(169, 267);
            txtPersonelEvrakID.Name = "txtPersonelEvrakID";
            txtPersonelEvrakID.Size = new Size(125, 27);
            txtPersonelEvrakID.TabIndex = 9;
            txtPersonelEvrakID.TextChanged += textBox3_TextChanged;
            // 
            // txtPersonelTelNo
            // 
            txtPersonelTelNo.Location = new Point(169, 313);
            txtPersonelTelNo.Name = "txtPersonelTelNo";
            txtPersonelTelNo.Size = new Size(125, 27);
            txtPersonelTelNo.TabIndex = 10;
            txtPersonelTelNo.TextChanged += textBox4_TextChanged;
            // 
            // txtPersonelID
            // 
            txtPersonelID.Location = new Point(475, 271);
            txtPersonelID.Name = "txtPersonelID";
            txtPersonelID.Size = new Size(125, 27);
            txtPersonelID.TabIndex = 11;
            // 
            // txtAra
            // 
            txtAra.Location = new Point(169, 222);
            txtAra.Name = "txtAra";
            txtAra.Size = new Size(1020, 27);
            txtAra.TabIndex = 12;
            txtAra.TextChanged += txtAra_TextChanged;
            // 
            // cmbPersonelBolum
            // 
            cmbPersonelBolum.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPersonelBolum.FormattingEnabled = true;
            cmbPersonelBolum.Items.AddRange(new object[] { "ybs ", "uti", "işletme" });
            cmbPersonelBolum.Location = new Point(1038, 270);
            cmbPersonelBolum.Name = "cmbPersonelBolum";
            cmbPersonelBolum.Size = new Size(151, 28);
            cmbPersonelBolum.TabIndex = 13;
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
            dgwListe.TabIndex = 14;
            dgwListe.CellContentClick += dgwListe_CellContentClick;
            dgwListe.CellEnter += dgwListe_CellEnter;
            // 
            // btnSil
            // 
            btnSil.Image = Properties.Resources.uu_logo;
            btnSil.Location = new Point(771, 389);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(135, 103);
            btnSil.TabIndex = 17;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click;
            // 
            // btnDegistir
            // 
            btnDegistir.Image = Properties.Resources.uu_logo;
            btnDegistir.Location = new Point(531, 389);
            btnDegistir.Name = "btnDegistir";
            btnDegistir.Size = new Size(135, 103);
            btnDegistir.TabIndex = 16;
            btnDegistir.Text = "Değiştir";
            btnDegistir.UseVisualStyleBackColor = true;
            btnDegistir.Click += btnDegistir_Click;
            // 
            // btnEkle
            // 
            btnEkle.Image = Properties.Resources.uu_logo;
            btnEkle.Location = new Point(289, 389);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(135, 103);
            btnEkle.TabIndex = 15;
            btnEkle.Text = "Ekle";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Cyan;
            ClientSize = new Size(1230, 574);
            Controls.Add(btnSil);
            Controls.Add(btnDegistir);
            Controls.Add(btnEkle);
            Controls.Add(dgwListe);
            Controls.Add(cmbPersonelBolum);
            Controls.Add(txtAra);
            Controls.Add(txtPersonelID);
            Controls.Add(txtPersonelTelNo);
            Controls.Add(txtPersonelEvrakID);
            Controls.Add(txtPersonelYas);
            Controls.Add(txtpersonelİsim);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Personel Evrakları";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)dgwListe).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txtpersonelİsim;
        private TextBox txtPersonelYas;
        private TextBox txtPersonelEvrakID;
        private TextBox txtPersonelTelNo;
        private TextBox txtPersonelID;
        private TextBox txtAra;
        private ComboBox cmbPersonelBolum;
        private DataGridView dgwListe;
        private Button btnSil;
        private Button btnDegistir;
        private Button btnEkle;
    }
}