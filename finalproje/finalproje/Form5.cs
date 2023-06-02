using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace finalproje
{
    public partial class Form5 : Form
    {
        MySqlConnection con;
        MySqlCommand cmd;
        MySqlDataReader dr;

        public Form5()
        {
            InitializeComponent();
            con = new MySqlConnection("Server=172.21.54.3;Database=Grup9-2023;Uid=Grup9-2023;Pwd=NyP:974.cc;");
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            string user = txtKullanici.Text;
            string pass = txtSifre.Text;
            cmd = new MySqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM Kullanici where usr='" + txtKullanici.Text + "' AND pwd='" + txtSifre.Text + "'";
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                MessageBox.Show("Giriş Başarılı.");
            }
            else
            {
                MessageBox.Show("Hatalı Kullanıcı Adı veya Şifre Girdiniz.");
                Application.Exit();
            }

            if (comboBox1.SelectedIndex == 0)
            {
                Form1 form1 = new Form1();
                form1.Show();
                this.Hide();
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                Form2 form2 = new Form2();
                form2.Show();
                this.Hide();
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                Form4 form4 = new Form4();
                form4.Show();
                this.Hide();
            }
            else if (comboBox1.SelectedIndex == 3)
            {
                Form3 form3 = new Form3();
                form3.Show();
                this.Hide();
            }
            else if (comboBox1.SelectedIndex == 4)
            {
                Form6 form6 = new Form6();
                form6.Show();
                this.Hide();
            }
            else if (comboBox1.SelectedIndex == null)
            {
                MessageBox.Show("İşlem Türünü Seçiniz");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
