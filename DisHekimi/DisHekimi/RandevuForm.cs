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
    public partial class RandevuForm : Form
    {
        SqlConnection con = new SqlConnection("server=RJ-45RJ; database=DisHekimi; integrated security=true; ");
        public RandevuForm()
        {
            InitializeComponent();
        }

        private void Randevu_Load(object sender, EventArgs e)
        {
            RandevuGetir();
            HastaGetir();
            DoktorGetir();
            HastalikGetir();
           

        }
        void HastaGetir()
        {
            SqlDataAdapter adp = new SqlDataAdapter("select * from Hastalar", con);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            cbHastaAdi.DisplayMember = "HastaAdi";
            cbHastaAdi.ValueMember = "HastaID";
            cbHastaAdi.DataSource = dt;
            con.Open();
            con.Close();

        }
        void DoktorGetir()
        {
            SqlDataAdapter adp = new SqlDataAdapter("select *from Doktorlar", con);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            cbDoktor.DisplayMember = "DoktorAdi";
            cbDoktor.ValueMember = "DoktorID";
            cbDoktor.DataSource = dt;
            con.Open();
            con.Close();
        }
        void HastalikGetir()
        {

            SqlDataAdapter adp = new SqlDataAdapter("select * from doktorlar", con);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            cbHastalik.DisplayMember = "Hastalik";
            cbHastalik.ValueMember = "DoktorID";
            cbHastalik.DataSource = dt;
            con.Open();
            con.Close();
        }
        void RandevuGetir()
        {
            SqlDataAdapter adp = new SqlDataAdapter("select * from Randevular", con);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            dtgvRandevu.DataSource = dt;
            //dtgvRandevu.Columns["RandevuID"].Visible = false;

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            RandevuEkle();
            RandevuGetir();
        }

        void RandevuEkle()
        {

            if (!string.IsNullOrEmpty(txtSaat.Text))
            {
                SqlCommand komut = new SqlCommand("insert Randevular Values(@HastaAdi, @HastalikAdi, @DoktorAdi, @Tarih, @Saat, @Aciklama)", con);
                komut.Parameters.AddWithValue("@HastaAdi", cbHastaAdi.Text);
                komut.Parameters.AddWithValue("@HastalikAdi", cbHastalik.Text);
                komut.Parameters.AddWithValue("@DoktorAdi", cbDoktor.Text);
                komut.Parameters.AddWithValue("@Tarih", dateTarih.Text);
                komut.Parameters.AddWithValue("@Saat", txtSaat.Text);
                komut.Parameters.AddWithValue("@Aciklama", rtxtAciklama.Text);

                con.Open();
                komut.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("KAYIT BAŞARIYLA EKLENDİ.", "BİLGİ");
                cbHastaAdi.SelectedIndex = -1;
                cbHastalik.SelectedIndex = -1;
                cbDoktor.SelectedIndex = -1;
                txtSaat.Clear();
                rtxtAciklama.Clear();

            }
            else
            {
                MessageBox.Show("Lütfen Boş Alanları Doldurunuz", "DİKKAT");
            }

        }

        private void btnAna_Click(object sender, EventArgs e)
        {
            Ana AnayaGit = new Ana();
            this.Hide();
            AnayaGit.ShowDialog();
            this.Show();
        }
        

        void HastaligaGoreDoktor()
        {
            //-- HASTALIĞA GÖRE DOKTOR GETİRME

            SqlDataAdapter adp = new SqlDataAdapter("select * from Doktorlar where DoktorID=@id", con);
            
            adp.SelectCommand.Parameters.AddWithValue("id", cbHastalik.SelectedValue);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            cbDoktor.SelectedItem = dt.Rows[0]["DoktorAdi"].ToString();

        }

        private void cbHastalik_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlDataAdapter adp = new SqlDataAdapter("select * from Doktorlar where DoktorID=@id", con);

            adp.SelectCommand.Parameters.AddWithValue("id", cbHastalik.SelectedValue);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            cbDoktor.SelectedItem = dt.Rows[0]["DoktorAdi"].ToString();
            con.Open();
            con.Close();
        }
    }
}
