namespace finalproje
{
    partial class Form4
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
            btnSil = new Button();
            btnDegistir = new Button();
            btnEkle = new Button();
            dgwListe = new DataGridView();
            cmbOgrenciBolum = new ComboBox();
            txtAra = new TextBox();
            txtEvrakID = new TextBox();
            txtOgrenciAdres = new TextBox();
            txtOgrenciID = new TextBox();
            txtOgrenciYas = new TextBox();
            txtogrenciİsim = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgwListe).BeginInit();
            SuspendLayout();
            // 
            // btnSil
            // 
            btnSil.Image = Properties.Resources.uu_logo;
            btnSil.Location = new Point(763, 380);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(135, 103);
            btnSil.TabIndex = 35;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click;
            // 
            // btnDegistir
            // 
            btnDegistir.Image = Properties.Resources.uu_logo;
            btnDegistir.Location = new Point(544, 380);
            btnDegistir.Name = "btnDegistir";
            btnDegistir.Size = new Size(135, 103);
            btnDegistir.TabIndex = 34;
            btnDegistir.Text = "Değiştir";
            btnDegistir.UseVisualStyleBackColor = true;
            btnDegistir.Click += btnDegistir_Click;
            // 
            // btnEkle
            // 
            btnEkle.Image = Properties.Resources.uu_logo;
            btnEkle.Location = new Point(328, 380);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(135, 103);
            btnEkle.TabIndex = 33;
            btnEkle.Text = "Ekle";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // dgwListe
            // 
            dgwListe.AllowUserToAddRows = false;
            dgwListe.AllowUserToDeleteRows = false;
            dgwListe.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgwListe.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwListe.Location = new Point(7, 34);
            dgwListe.Name = "dgwListe";
            dgwListe.ReadOnly = true;
            dgwListe.RowHeadersWidth = 51;
            dgwListe.RowTemplate.Height = 29;
            dgwListe.Size = new Size(1216, 188);
            dgwListe.TabIndex = 32;
            dgwListe.CellEnter += dgwListe_CellEnter;
            // 
            // cmbOgrenciBolum
            // 
            cmbOgrenciBolum.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbOgrenciBolum.FormattingEnabled = true;
            cmbOgrenciBolum.Items.AddRange(new object[] { "ybs", "uti", "işletme" });
            cmbOgrenciBolum.Location = new Point(1067, 279);
            cmbOgrenciBolum.Name = "cmbOgrenciBolum";
            cmbOgrenciBolum.Size = new Size(151, 28);
            cmbOgrenciBolum.TabIndex = 31;
            // 
            // txtAra
            // 
            txtAra.Location = new Point(124, 239);
            txtAra.Name = "txtAra";
            txtAra.Size = new Size(1099, 27);
            txtAra.TabIndex = 30;
            txtAra.TextChanged += txtAra_TextChanged;
            // 
            // txtEvrakID
            // 
            txtEvrakID.Location = new Point(377, 280);
            txtEvrakID.Name = "txtEvrakID";
            txtEvrakID.Size = new Size(125, 27);
            txtEvrakID.TabIndex = 29;
            // 
            // txtOgrenciAdres
            // 
            txtOgrenciAdres.Location = new Point(124, 319);
            txtOgrenciAdres.Name = "txtOgrenciAdres";
            txtOgrenciAdres.Size = new Size(125, 27);
            txtOgrenciAdres.TabIndex = 28;
            // 
            // txtOgrenciID
            // 
            txtOgrenciID.Location = new Point(124, 276);
            txtOgrenciID.Name = "txtOgrenciID";
            txtOgrenciID.Size = new Size(125, 27);
            txtOgrenciID.TabIndex = 27;
            // 
            // txtOgrenciYas
            // 
            txtOgrenciYas.Location = new Point(824, 280);
            txtOgrenciYas.Name = "txtOgrenciYas";
            txtOgrenciYas.Size = new Size(125, 27);
            txtOgrenciYas.TabIndex = 26;
            // 
            // txtogrenciİsim
            // 
            txtogrenciİsim.Location = new Point(591, 280);
            txtogrenciİsim.Name = "txtogrenciİsim";
            txtogrenciİsim.Size = new Size(125, 27);
            txtogrenciİsim.TabIndex = 25;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(7, 242);
            label7.Name = "label7";
            label7.Size = new Size(32, 20);
            label7.TabIndex = 24;
            label7.Text = "Ara";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(278, 283);
            label6.Name = "label6";
            label6.Size = new Size(63, 20);
            label6.TabIndex = 23;
            label6.Text = "Evrak ID";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 326);
            label5.Name = "label5";
            label5.Size = new Size(47, 20);
            label5.TabIndex = 22;
            label5.Text = "Adres";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(986, 282);
            label4.Name = "label4";
            label4.Size = new Size(52, 20);
            label4.TabIndex = 21;
            label4.Text = "Bölüm";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(7, 279);
            label3.Name = "label3";
            label3.Size = new Size(80, 20);
            label3.TabIndex = 20;
            label3.Text = "Öğrenci ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(755, 283);
            label2.Name = "label2";
            label2.Size = new Size(30, 20);
            label2.TabIndex = 19;
            label2.Text = "Yaş";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(533, 283);
            label1.Name = "label1";
            label1.Size = new Size(36, 20);
            label1.TabIndex = 18;
            label1.Text = "İsim";
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Cyan;
            ClientSize = new Size(1230, 574);
            Controls.Add(btnSil);
            Controls.Add(btnDegistir);
            Controls.Add(btnEkle);
            Controls.Add(dgwListe);
            Controls.Add(cmbOgrenciBolum);
            Controls.Add(txtAra);
            Controls.Add(txtEvrakID);
            Controls.Add(txtOgrenciAdres);
            Controls.Add(txtOgrenciID);
            Controls.Add(txtOgrenciYas);
            Controls.Add(txtogrenciİsim);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form4";
            Text = "Öğrenci Evrakları";
            Load += Form4_Load;
            ((System.ComponentModel.ISupportInitialize)dgwListe).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSil;
        private Button btnDegistir;
        private Button btnEkle;
        private DataGridView dgwListe;
        private ComboBox cmbOgrenciBolum;
        private TextBox txtAra;
        private TextBox txtEvrakID;
        private TextBox txtOgrenciAdres;
        private TextBox txtOgrenciID;
        private TextBox txtOgrenciYas;
        private TextBox txtogrenciİsim;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}