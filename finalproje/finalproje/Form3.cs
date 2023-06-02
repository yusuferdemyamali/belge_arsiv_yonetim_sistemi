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
    public partial class Form3 : Form
    {
        MySqlConnection conn = new MySqlConnection("Server=172.21.54.3;Database=Grup9-2023;Uid=Grup9-2023;Pwd=NyP:974.cc;");
        MySqlCommand cmd;
        MySqlDataAdapter adapter;
        DataTable dt;
        public Form3()
        {
            InitializeComponent();
        }

        void VeriGetir()
        {
            dt = new DataTable();
            conn.Open();
            adapter = new MySqlDataAdapter("SELECT *FROM muhasebe_evraklari", conn);
            adapter.Fill(dt);
            dgwListe.DataSource = dt;
            conn.Close();
        }
        private void Form3_Load(object sender, EventArgs e)
        {
            VeriGetir();
        }

        private void dgwListe_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtfaturaID.Text = dgwListe.CurrentRow.Cells[0].Value.ToString();
                txtAlınanMal.Text = dgwListe.CurrentRow.Cells[1].Value.ToString();
                dateAlınanTarih.Text = dgwListe.CurrentRow.Cells[3].Value.ToString();
                txtAlınanAdet.Text = dgwListe.CurrentRow.Cells[2].Value.ToString();

            }
            catch
            {

            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            string sql = "INSERT INTO muhasebe_evraklari(AlinanMal,Alinan_Adet,SatinAlim_Tarih)" +
    "VALUES (@alınanmal,@alınanadet,@alımtarih)";
            cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@alınanmal", txtAlınanMal.Text);
            cmd.Parameters.AddWithValue("@alınanadet", txtAlınanAdet.Text);
            cmd.Parameters.AddWithValue("@alımtarih", dateAlınanTarih.Text);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            VeriGetir();
            MessageBox.Show("Veri Eklendi");
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            string sql = "DELETE FROM muhasebe_evraklari WHERE Fatura_ID=@faturaid";
            cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@faturaid", txtfaturaID.Text);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            VeriGetir();
            MessageBox.Show("Kayıt Silindi");
        }

        private void btnDegistir_Click(object sender, EventArgs e)
        {
            string sql = "UPDATE muhasebe_evraklari " +
    "SET AlinanMal=@alınanmal,Alinan_Adet=@alınanadet,SatinAlim_Tarih=@alımtarih" +
    " WHERE Fatura_ID=@faturaid";
            cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@alınanmal", txtAlınanMal.Text);
            cmd.Parameters.AddWithValue("@alınanadet", txtAlınanAdet.Text);
            cmd.Parameters.AddWithValue("@alımtarih", dateAlınanTarih.Text);
            cmd.Parameters.AddWithValue("@faturaid", Convert.ToInt32(txtfaturaID.Text));
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            VeriGetir();
            MessageBox.Show("Kayıt güncellendi.");
        }

        private void txtAra_TextChanged(object sender, EventArgs e)
        {
            DataView dv = dt.DefaultView;
            dv.RowFilter = "SatınAlınanMal LIKE '" + txtAra.Text + "%'";
            dgwListe.DataSource = dv;
        }
    }
}
