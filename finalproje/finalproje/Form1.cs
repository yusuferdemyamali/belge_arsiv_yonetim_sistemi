using System.Data;
using MySql.Data.MySqlClient;

namespace finalproje
{
    public partial class Form1 : Form
    {
        MySqlConnection conn = new MySqlConnection("Server=172.21.54.3;Database=Grup9-2023;Uid=Grup9-2023;Pwd=NyP:974.cc;");
        MySqlCommand cmd;
        MySqlDataAdapter adapter;
        DataTable dt;
        public Form1()
        {
            InitializeComponent();
        }

        void VeriGetir()
        {
            dt = new DataTable();
            conn.Open();
            adapter = new MySqlDataAdapter("SELECT *FROM sinav_kagitlari", conn);
            adapter.Fill(dt);
            dgwListe.DataSource = dt;
            conn.Close();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            VeriGetir();
        }

        private void dgwListe_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtID.Text = dgwListe.CurrentRow.Cells[0].Value.ToString();
                txtNo.Text = dgwListe.CurrentRow.Cells[1].Value.ToString();
                txtAd.Text = dgwListe.CurrentRow.Cells[3].Value.ToString();
                cmbBolum.Text = dgwListe.CurrentRow.Cells[4].Value.ToString();
                txtDers.Text = dgwListe.CurrentRow.Cells[2].Value.ToString();
                txtNot.Text = dgwListe.CurrentRow.Cells[5].Value.ToString();

            }
            catch
            {

            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            string sql = "INSERT INTO sinav_kagitlari(OgrenciNo,DersAdi,OgrenciAdi,OgrenciBolum,OgrenciNot)" +
                "VALUES (@ogrno,@dersad,@ogrenciad,@bolum,@not)";
            cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@ogrno", txtNo.Text);
            cmd.Parameters.AddWithValue("@dersad", txtDers.Text);
            cmd.Parameters.AddWithValue("@ogrenciad", txtAd.Text);
            cmd.Parameters.AddWithValue("@bolum", cmbBolum.Text);
            cmd.Parameters.AddWithValue("@not", txtNot.Text);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            VeriGetir();
            MessageBox.Show("Veri Eklendi");
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            string sql = "DELETE FROM sinav_kagitlari WHERE Ogrenci_ID=@id";
            cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@id", txtID.Text);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            VeriGetir();
            MessageBox.Show("Kayýt Silindi");
        }

        private void btnDegistir_Click(object sender, EventArgs e)
        {
            string sql = "UPDATE sinav_kagitlari " +
                "SET OgrenciNo=@ogrno,DersAdi=@dersad,OgrenciAdi=@ogrenciad,OgrenciBolum=@bolum,OgrenciNot=@not" +
                " WHERE Ogrenci_ID=@id";
            cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@ogrno", txtNo.Text);
            cmd.Parameters.AddWithValue("@dersad", txtDers.Text);
            cmd.Parameters.AddWithValue("@ogrenciad", txtAd.Text);
            cmd.Parameters.AddWithValue("@bolum", cmbBolum.Text);
            cmd.Parameters.AddWithValue("@not", txtNot.Text);
            cmd.Parameters.AddWithValue("@id", Convert.ToInt32(txtID.Text));
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            VeriGetir();
            MessageBox.Show("Kayýt güncellendi.");
        }

        private void txtAra_TextChanged(object sender, EventArgs e)
        {
            DataView dv = dt.DefaultView;
            dv.RowFilter = "OgrenciAdi LIKE '" + txtAra.Text + "%'";
            dgwListe.DataSource = dv;
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}