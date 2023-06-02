namespace finalproje
{
    partial class Form5
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
            mySqlDataAdapter1 = new MySql.Data.MySqlClient.MySqlDataAdapter();
            mySqlDataAdapter2 = new MySql.Data.MySqlClient.MySqlDataAdapter();
            label2 = new Label();
            button1 = new Button();
            txtKullanici = new TextBox();
            txtSifre = new TextBox();
            comboBox1 = new ComboBox();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(263, 245);
            label1.Name = "label1";
            label1.Size = new Size(92, 20);
            label1.TabIndex = 0;
            label1.Text = "Kullanıcı Adı";
            // 
            // mySqlDataAdapter1
            // 
            mySqlDataAdapter1.DeleteCommand = null;
            mySqlDataAdapter1.InsertCommand = null;
            mySqlDataAdapter1.SelectCommand = null;
            mySqlDataAdapter1.UpdateCommand = null;
            // 
            // mySqlDataAdapter2
            // 
            mySqlDataAdapter2.DeleteCommand = null;
            mySqlDataAdapter2.InsertCommand = null;
            mySqlDataAdapter2.SelectCommand = null;
            mySqlDataAdapter2.UpdateCommand = null;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(263, 298);
            label2.Name = "label2";
            label2.Size = new Size(39, 20);
            label2.TabIndex = 1;
            label2.Text = "Şifre";
            // 
            // button1
            // 
            button1.Location = new Point(367, 388);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 2;
            button1.Text = "Giriş Yap";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // txtKullanici
            // 
            txtKullanici.Location = new Point(367, 243);
            txtKullanici.Name = "txtKullanici";
            txtKullanici.Size = new Size(125, 27);
            txtKullanici.TabIndex = 4;
            // 
            // txtSifre
            // 
            txtSifre.Location = new Point(367, 291);
            txtSifre.Name = "txtSifre";
            txtSifre.Size = new Size(125, 27);
            txtSifre.TabIndex = 5;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Sınav Kağıtları", "Personel Evrakları", "Öğrenci Evrakları", "Muhasebe Evrakları", "Bölüm Evrakları" });
            comboBox1.Location = new Point(367, 343);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 6;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(263, 351);
            label3.Name = "label3";
            label3.Size = new Size(77, 20);
            label3.TabIndex = 7;
            label3.Text = "İşlem Türü";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.uu_logo;
            pictureBox1.Location = new Point(274, 28);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(196, 181);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Cyan;
            ClientSize = new Size(753, 450);
            Controls.Add(pictureBox1);
            Controls.Add(label3);
            Controls.Add(comboBox1);
            Controls.Add(txtSifre);
            Controls.Add(txtKullanici);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Form5";
            Text = "Giriş Ekranı";
            Load += Form5_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private MySql.Data.MySqlClient.MySqlDataAdapter mySqlDataAdapter1;
        private MySql.Data.MySqlClient.MySqlDataAdapter mySqlDataAdapter2;
        private Label label2;
        private Button button1;
        private TextBox txtKullanici;
        private TextBox txtSifre;
        private ComboBox comboBox1;
        private Label label3;
        private PictureBox pictureBox1;
    }
}