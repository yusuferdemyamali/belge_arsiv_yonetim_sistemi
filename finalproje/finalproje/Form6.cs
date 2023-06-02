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
    public partial class Form6 : Form
    {
        MySqlConnection conn = new MySqlConnection("Server=172.21.54.3;Database=Grup9-2023;Uid=Grup9-2023;Pwd=NyP:974.cc;");
        MySqlCommand cmd;
        MySqlDataAdapter adapter;
        DataTable dt;
        public Form6()
        {
            InitializeComponent();
        }
        void VeriGetir()
        {
            dt = new DataTable();
            conn.Open();
            adapter = new MySqlDataAdapter("SELECT *FROM bolum_evraklari", conn);
            adapter.Fill(dt);
            dgwListe.DataSource = dt;
            conn.Close();
        }
        private void Form6_Load(object sender, EventArgs e)
        {
            VeriGetir();
        }

        private void dgwListe_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtBolumID.Text = dgwListe.CurrentRow.Cells[0].Value.ToString();
                txtPersİsim.Text = dgwListe.CurrentRow.Cells[1].Value.ToString();
                txtEvrakTuru.Text = dgwListe.CurrentRow.Cells[3].Value.ToString();
                txtEvrakID.Text = dgwListe.CurrentRow.Cells[4].Value.ToString();
                txtEvrakAd.Text = dgwListe.CurrentRow.Cells[2].Value.ToString();

            }
            catch
            {

            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            string sql = "INSERT INTO bolum_evraklari(Personel_Isim,Evrak_Adi,Evrak_Turu,Evrak_ID)" +
    "VALUES (@persad,@evrakadi,@evrakturu,@evrakid)";
            cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@persad", txtPersİsim.Text);
            cmd.Parameters.AddWithValue("@evrakadi", txtEvrakAd.Text);
            cmd.Parameters.AddWithValue("@evrakturu", txtEvrakTuru.Text);
            cmd.Parameters.AddWithValue("@evrakid", txtEvrakID.Text);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            VeriGetir();
            MessageBox.Show("Veri Eklendi");
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            string sql = "DELETE FROM bolum_evraklari WHERE ID=@id";
            cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@id", txtBolumID.Text);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            VeriGetir();
            MessageBox.Show("Kayıt Silindi");
        }

        private void btnDegistir_Click(object sender, EventArgs e)
        {
            string sql = "UPDATE bolum_evraklari " +
    "SET ID=@id,Personel_Isim=@persad,Evrak_Adi=@evrakadi,Evrak_ID=@evrakid" +
    " WHERE ID=@id";
            cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@persad", txtPersİsim.Text);
            cmd.Parameters.AddWithValue("@evrakadi", txtEvrakAd.Text);
            cmd.Parameters.AddWithValue("@evrakid", txtEvrakID.Text);
            cmd.Parameters.AddWithValue("@id", Convert.ToInt32(txtBolumID.Text));
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            VeriGetir();
            MessageBox.Show("Kayıt güncellendi.");
        }

        private void txtAra_TextChanged(object sender, EventArgs e)
        {
            DataView dv = dt.DefaultView;
            dv.RowFilter = "Evrak_Adi LIKE '" + txtAra.Text + "%'";
            dgwListe.DataSource = dv;
        }
    }
}
