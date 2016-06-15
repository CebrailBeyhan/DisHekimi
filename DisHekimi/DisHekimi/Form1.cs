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
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection("server=.; database=DisHekimi; integrated security=true");
        public Form1()
        {
            InitializeComponent();
        }


        private void tabPage2_Click(object sender, EventArgs e)
        {

        }


        //------------------------------------------------------

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
               
        private void Form1_Load(object sender, EventArgs e)
        {
            HastaGetir();
            IsimGetir();
            
        }
        void HastaGetir()
        {
            con.Open();
            SqlDataAdapter adp = new SqlDataAdapter("Select * from Hastalar", con);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            dataGridViewHasta.DataSource = dt;
            con.Close();
        }
        void IsimGetir()
        {
            con.Open();
            SqlDataAdapter adp = new SqlDataAdapter("select*from Hastalar ", con);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            cbHastaAdi.DisplayMember = "HastaAdi";
            cbHastaAdi.ValueMember = "HastaID";
            cbHastaAdi.DataSource = dt;
            con.Close();

        }
       
        private void btnHastaKaydet_Click(object sender, EventArgs e)
        {
            HastaKaydet();
        }

       
    }
}
