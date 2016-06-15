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
    public partial class HastalikForm : Form
    {

        SqlConnection con = new SqlConnection("server=RJ-45RJ; database=DisHekimi; integrated security=true;");
        public HastalikForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ana AnayaGit = new Ana();
            this.Hide();
            AnayaGit.ShowDialog();
            this.Show();
        }

        private void HastalikForm_Load(object sender, EventArgs e)
        {
            HastalikGetir();
        }

        void HastalikGetir()
        {

            SqlDataAdapter adp = new SqlDataAdapter("select * from Hastalik", con);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            dtgvHastalik.DataSource = dt;
            con.Open();
            con.Close();
            dtgvHastalik.Columns["HastalikID"].Visible = false;
            dtgvHastalik.Columns["Hastalik"].Width=150;
            dtgvHastalik.Columns["Fiyat"].Width = 50;

        }

        private void btnHastalikKaydet_Click(object sender, EventArgs e)
        {
            HastalikEkle();
            HastalikGetir();
        }

        void HastalikEkle()
        {
            if (!string.IsNullOrEmpty(txtHastalik_adi.Text) && !string.IsNullOrEmpty(txtFiyati.Text))
            {
                SqlCommand komut = new SqlCommand("insert Hastalik Values(@Hastalik,@Fiyat,@Aciklama)", con);
                komut.Parameters.AddWithValue("@Hastalik", txtHastalik_adi.Text);
                komut.Parameters.AddWithValue("@Fiyat", txtFiyati.Text);
                komut.Parameters.AddWithValue("@Aciklama", txtAciklama.Text);

                con.Open();
                komut.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Kayıt Başarıyla Eklendi", "BİLGİ");
                txtHastalik_adi.Clear();
                txtFiyati.Clear();
                txtAciklama.Clear();

            }
            else
            {
                MessageBox.Show("Lütfen Boş Alanları Doldurunuz !!!", " DİKKAT ");
            }
        
        }
    }
}
