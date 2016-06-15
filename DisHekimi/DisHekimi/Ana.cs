using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace DisHekimi
{
    public partial class Ana : Form
    {
        public Ana()
        {
            InitializeComponent();
        }



        private void button3_MouseLeave(object sender, EventArgs e)
        {
            btnAnaHastaKayit.BackColor = Color.MediumVioletRed;
        }


        private void button8_MouseLeave(object sender, EventArgs e)
        {
            btnAnaRandevuKayit.BackColor = Color.White;
        }


        private void button3_Click(object sender, EventArgs e)
        {
            HastaKayitForm HastaGit = new HastaKayitForm();
            this.Hide();
            HastaGit.ShowDialog();
            this.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            DoktorForm DoktoraGit = new DoktorForm();
            this.Hide();
            DoktoraGit.ShowDialog();
            this.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            HastalikForm HastalikaGit = new HastalikForm();
            this.Hide();
            HastalikaGit.ShowDialog();
            this.Show();
        }

        private void btnAnaKasa_Click(object sender, EventArgs e)
        {
            KasaForm KasayaGit = new KasaForm();
            this.Hide();
            KasayaGit.ShowDialog();
            this.Show();

        }

        private void btnAnaCalisanlar_Click(object sender, EventArgs e)
        {
            CalisanForm CalisanaGit = new CalisanForm();
            this.Hide();
            CalisanaGit.ShowDialog();
            this.Show();
        }

        private void btnAnaOdeme_Click(object sender, EventArgs e)
        {
            OdemeForm OdemeyeGit = new OdemeForm();
            this.Hide();
            OdemeyeGit.ShowDialog();
            this.Show();
        }

        private void btnAnaHastaBilgileri_Click(object sender, EventArgs e)
        {
            HastaBilgileriForm HastaBilgilerineGit = new HastaBilgileriForm();
            this.Hide();
            HastaBilgilerineGit.ShowDialog();
            this.Show();
        }

        private void btnAnaRandevuKayit_Click(object sender, EventArgs e)
        {
            RandevuForm RandevuyaGit = new RandevuForm();
            this.Hide();
            RandevuyaGit.ShowDialog();
            this.Show();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAnaRandevuKayit_Click_1(object sender, EventArgs e)
        {
            RandevuForm RandevuyaGit = new RandevuForm();
            this.Hide();
            RandevuyaGit.ShowDialog();
            this.Show();
        }

        //private void pictureBox1_Click(object sender, EventArgs e) ---------- internet sayfasına link vermek çin yukarıda "using System.Diagnostics;" yazdık
        //{
        //    Process.Start("http://www.google.com");
        //}




        //------------------------------------------------------------------------------------------------

        /*using System;
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

        private void dataGridViewHasta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cbCinsiyet_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtTel_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtHasta_adi_TextChanged(object sender, EventArgs e)
        {

        }

        private void rtxtAdres_TextChanged(object sender, EventArgs e)
        {

        }

        
    }
}
*/
    }
}
