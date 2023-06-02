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
    public partial class Form4 : Form
    {
        MySqlConnection conn = new MySqlConnection("Server=172.21.54.3;Database=Grup9-2023;Uid=Grup9-2023;Pwd=NyP:974.cc;");
        MySqlCommand cmd;
        MySqlDataAdapter adapter;
        DataTable dt;
        public Form4()
        {
            InitializeComponent();
        }
        void VeriGetir()
        {
            dt = new DataTable();
            conn.Open();
            adapter = new MySqlDataAdapter("SELECT *FROM ogrenci_evraklari", conn);
            adapter.Fill(dt);
            dgwListe.DataSource = dt;
            conn.Close();
        }
        private void Form4_Load(object sender, EventArgs e)
        {
            VeriGetir();
        }

        private void dgwListe_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtOgrenciID.Text = dgwListe.CurrentRow.Cells[0].Value.ToString();
                txtEvrakID.Text = dgwListe.CurrentRow.Cells[1].Value.ToString();
                txtOgrenciYas.Text = dgwListe.CurrentRow.Cells[3].Value.ToString();
                cmbOgrenciBolum.Text = dgwListe.CurrentRow.Cells[4].Value.ToString();
                txtogrenciİsim.Text = dgwListe.CurrentRow.Cells[2].Value.ToString();
                txtOgrenciAdres.Text = dgwListe.CurrentRow.Cells[5].Value.ToString();

            }
            catch
            {

            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            string sql = "INSERT INTO ogrenci_evraklari(Evrak_ID,OgrenciAdi,OgrenciYas,OgrenciBolum,Ogrenci_Adres)" +
    "VALUES (@evrakid,@ograd,@ogryas,@ogrbolum,@ogradres)";
            cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@evrakid", txtEvrakID.Text);
            cmd.Parameters.AddWithValue("@ograd", txtogrenciİsim.Text);
            cmd.Parameters.AddWithValue("@ogryas", txtOgrenciYas.Text);
            cmd.Parameters.AddWithValue("@ogrbolum", cmbOgrenciBolum.Text);
            cmd.Parameters.AddWithValue("@ogradres", txtOgrenciAdres.Text);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            VeriGetir();
            MessageBox.Show("Veri Eklendi");
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            string sql = "DELETE FROM ogrenci_evraklari WHERE Ogrenci_ID=@id";
            cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@id", txtOgrenciID.Text);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            VeriGetir();
            MessageBox.Show("Kayıt Silindi");
        }

        private void btnDegistir_Click(object sender, EventArgs e)
        {
            string sql = "UPDATE ogrenci_evraklari " +
    "SET Evrak_ID=@evrakid,OgrenciAdi=@ograd,OgrenciYas=@ogryas,OgrenciBolum=@ogrbolum,Ogrenci_Adres=@ogradres" +
    " WHERE Ogrenci_ID=@id";
            cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@evrakid", txtEvrakID.Text);
            cmd.Parameters.AddWithValue("@ograd", txtogrenciİsim.Text);
            cmd.Parameters.AddWithValue("@ogryas", txtOgrenciYas.Text);
            cmd.Parameters.AddWithValue("@ogrbolum", cmbOgrenciBolum.Text);
            cmd.Parameters.AddWithValue("@ogradres", txtOgrenciAdres.Text);
            cmd.Parameters.AddWithValue("@id", Convert.ToInt32(txtOgrenciID.Text));
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            VeriGetir();
            MessageBox.Show("Kayıt güncellendi.");
        }

        private void txtAra_TextChanged(object sender, EventArgs e)
        {
            DataView dv = dt.DefaultView;
            dv.RowFilter = "OgrenciAdi LIKE '" + txtAra.Text + "%'";
            dgwListe.DataSource = dv;
        }
    }

}
