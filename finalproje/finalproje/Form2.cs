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
    public partial class Form2 : Form
    {
        MySqlConnection conn = new MySqlConnection("Server=172.21.54.3;Database=Grup9-2023;Uid=Grup9-2023;Pwd=NyP:974.cc;");
        MySqlCommand cmd;
        MySqlDataAdapter adapter;
        DataTable dt;
        public Form2()
        {
            InitializeComponent();
        }

        void VeriGetir()
        {
            dt = new DataTable();
            conn.Open();
            adapter = new MySqlDataAdapter("SELECT *FROM personel_evraklari", conn);
            adapter.Fill(dt);
            dgwListe.DataSource = dt;
            conn.Close();
        }
        private void btnDegistir_Click(object sender, EventArgs e)
        {
            string sql = "UPDATE personel_evraklari " +
    "SET Personel_Isim=@personelisim,Personel_Yas=@personelyas,Evrak_ID=@personelevrakid,Personel_Bolum=@personelbolum,Personel_TelNo=@personeltelno" +
    " WHERE Personel_ID=@personelid";
            cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@personelisim", txtpersonelİsim.Text);
            cmd.Parameters.AddWithValue("@personelyas", txtPersonelYas.Text);
            cmd.Parameters.AddWithValue("@personelevrakid", txtPersonelEvrakID.Text);
            cmd.Parameters.AddWithValue("@personelbolum", cmbPersonelBolum.Text);
            cmd.Parameters.AddWithValue("@personeltelno", txtPersonelTelNo.Text);
            cmd.Parameters.AddWithValue("@personelid", Convert.ToInt32(txtPersonelID.Text));
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            VeriGetir();
            MessageBox.Show("Kayıt güncellendi.");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            VeriGetir();
        }

        private void txtAra_TextChanged(object sender, EventArgs e)
        {
            DataView dv = dt.DefaultView;
            dv.RowFilter = "Personel_Isim LIKE '" + txtAra.Text + "%'";
            dgwListe.DataSource = dv;
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            string sql = "DELETE FROM personel_evraklari WHERE Personel_ID=@personelid";
            cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@personelid", txtPersonelID.Text);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            VeriGetir();
            MessageBox.Show("Kayıt Silindi");
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            string sql = "INSERT INTO personel_evraklari(Personel_Isim,Personel_Bolum,Personel_Yas,Personel_TelNo,Evrak_ID)" +
    "VALUES (@personelisim,@personelbolum,@personelyas,@personeltelno,@personelevrakid)";
            cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@personelisim", txtpersonelİsim.Text);
            cmd.Parameters.AddWithValue("@personelbolum", cmbPersonelBolum.Text);
            cmd.Parameters.AddWithValue("@personelyas", txtPersonelYas.Text);
            cmd.Parameters.AddWithValue("@personeltelno", txtPersonelTelNo.Text);
            cmd.Parameters.AddWithValue("@personelevrakid", txtPersonelEvrakID.Text);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            VeriGetir();
            MessageBox.Show("Veri Eklendi");
        }

        private void dgwListe_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtPersonelID.Text = dgwListe.CurrentRow.Cells[0].Value.ToString();
                txtpersonelİsim.Text = dgwListe.CurrentRow.Cells[1].Value.ToString();
                txtPersonelYas.Text = dgwListe.CurrentRow.Cells[3].Value.ToString();
                txtPersonelTelNo.Text = dgwListe.CurrentRow.Cells[4].Value.ToString();
                cmbPersonelBolum.Text = dgwListe.CurrentRow.Cells[2].Value.ToString();
                txtPersonelEvrakID.Text = dgwListe.CurrentRow.Cells[5].Value.ToString();

            }
            catch
            {

            }
        }

        private void dgwListe_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }

}
