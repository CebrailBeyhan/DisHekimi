using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace DisHekimi
{
    public partial class DoktorForm : Form
    {

        SqlConnection con = new SqlConnection("server=RJ-45RJ; database=DisHekimi; integrated security=true");
        public DoktorForm()
        {
            InitializeComponent();
        }

        private void Doktorlar_Load(object sender, EventArgs e)
        {
            DoktorGetir();
            HastalikGetir();
        }


        void DoktorGetir()
        {

            SqlDataAdapter adp = new SqlDataAdapter("select * from Doktorlar", con);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            dtgvDoktorlar.DataSource = dt;
            con.Open();
            con.Close();
            dtgvDoktorlar.Columns["DoktorID"].Visible = false;


        }

        void HastalikGetir()
        {

            SqlDataAdapter adp = new SqlDataAdapter("select* from Hastalik", con);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            cbHastalik.DisplayMember = "Hastalik";
            cbHastalik.ValueMember = "HastalikID";
            cbHastalik.DataSource = dt;
            con.Open();
            con.Close();
            
        }


        void DoktorEkle()
        {
            if (!string.IsNullOrEmpty(txtDoktor.Text) && !String.IsNullOrEmpty(txtUcret.Text))
            {
                SqlCommand komut = new SqlCommand("insert Doktorlar Values(@DoktorAdi,@Hastalik,@CalismaSaatleri,@IzinGunu,@Ucret,@Aciklama)", con);
                komut.Parameters.AddWithValue("@DoktorAdi", txtDoktor.Text);
                komut.Parameters.AddWithValue("@Hastalik", cbHastalik.DisplayMember);
                komut.Parameters.AddWithValue("@CalismaSaatleri", cbCalismaSaatler.SelectedItem);
                komut.Parameters.AddWithValue("@IzinGunu", cbIzinGunu.SelectedItem);
                komut.Parameters.AddWithValue("@Ucret", txtUcret.Text);
                komut.Parameters.AddWithValue("@Aciklama", rtxtAciklama.Text);

                MessageBox.Show("Kayıt Başarıyla Eklendi", " /* BİLGİ */");

                txtDoktor.Clear();
                txtUcret.Clear();
                rtxtAciklama.Clear();
                cbHastalik.SelectedIndex = -1;
                cbCalismaSaatler.SelectedIndex = -1;
                cbIzinGunu.SelectedIndex = -1;

                

                con.Open();
                komut.ExecuteNonQuery();
                con.Close();

               
            }
            else
            {
                MessageBox.Show("Lütfen Alanları Doldurunuz", "/* DİKKAT */");
            }


        }

        private void btnCalisanKaydet_Click(object sender, EventArgs e)
        {
            DoktorEkle();
            DoktorGetir();
            HastalikGetir();
        }

        private void btnAna_Click(object sender, EventArgs e)
        {
            Ana AnayaGit = new Ana();
            this.Hide();
            AnayaGit.ShowDialog();
            this.Close();

        }



        private void txtDoktor_TextChanged(object sender, EventArgs e)
        {
            txtDoktor.Text.ToUpper();
        }

        //---------------------------------------------------------------------------------

        /*  using System;
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
  }*/



    }
}
