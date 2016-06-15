using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;

namespace DisHekimi
{
    public partial class HastaKayitForm : Form
    {
        SqlConnection con = new SqlConnection("server=.; database=DisHekimi; integrated security=true");
        public HastaKayitForm()
        {
            InitializeComponent();
        }
        void HastaKaydet()
        {
            if (!string.IsNullOrEmpty(txtHasta_adi.Text))
            {
                SqlCommand komut = new SqlCommand("insert Hastalar values (@HastaAdi,@Telefon,@Cinsiyet,@Adres)", con);
                komut.Parameters.AddWithValue("@HastaAdi", txtHasta_adi.Text);
                komut.Parameters.AddWithValue("@Telefon", txtTel.Text);
                komut.Parameters.AddWithValue("@Cinsiyet", cbCinsiyet.SelectedItem);
                komut.Parameters.AddWithValue("@Adres", rtxtAdres.Text);


                MessageBox.Show(" KAYIT EKLENDİ :) ", " -- BİLGİ -- ");


                txtHasta_adi.Clear();
                txtTel.Clear();
                rtxtAdres.Clear();
                con.Open();
                komut.ExecuteNonQuery();
                con.Close();

            }
            else
            {
                MessageBox.Show("LÜTFEN YAZI  GİRİNİZ !!!", "UYARI");
            }
        }


        private void HastaKayit_Load(object sender, EventArgs e)
        {
            HastaGetir();


        }
        void HastaGetir()
        {
            con.Open();
            SqlDataAdapter adp = new SqlDataAdapter("Select * from Hastalar", con);
            DataTable dt = new DataTable();
            

            adp.Fill(dt);
            dataGridViewHasta.DataSource = dt;
            con.Close();

            dataGridViewHasta.Columns["HastaID"].Visible = false;
        }

        private void btnHastaKaydet_Click(object sender, EventArgs e)
        {

            HastaKaydet();
            HastaGetir();
        }

        private void btnAna_Click(object sender, EventArgs e)
        {
            Ana AnayaGit = new Ana();
            this.Hide();
            AnayaGit.ShowDialog();
            this.Show();
        }





    }
}
