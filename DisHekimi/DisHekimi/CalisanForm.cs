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
    public partial class CalisanForm : Form
    {

        SqlConnection con = new SqlConnection("server=RJ-45RJ; database=DisHekimi; integrated security=true");
        public CalisanForm()
        {
            InitializeComponent();
        }

        private void CalisanForm_Load(object sender, EventArgs e)
        {
            CalisanGetir();
        }
        void CalisanGetir()
        {
            SqlDataAdapter adp = new SqlDataAdapter("select * from Calisanlar",con);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            dtgvCalisan.DataSource = dt;
            dtgvCalisan.Columns["CalisanID"].Visible = false;

        
        }

        private void btnAna_Click(object sender, EventArgs e)
        {
            Ana AnayaGit = new Ana();
            this.Hide();
            AnayaGit.ShowDialog();
            this.Close();
        }

        private void btnCalisanKaydet_Click(object sender, EventArgs e)
        {
            CalisanEkle();
            CalisanGetir();
        }

        void CalisanEkle()
        {
            if (!string.IsNullOrEmpty(txtCalisanAdi.Text))
            {
                SqlCommand komut = new SqlCommand("insert Calisanlar values(@CalisanAdi, @CalismaSaatleri, @Gorevi, @IzinGunu, @Ucret, @Aciklama )", con);
            komut.Parameters.AddWithValue("@CalisanAdi",txtCalisanAdi.Text);
            komut.Parameters.AddWithValue("@CalismaSaatleri",cbCalismaSaatler.SelectedItem);
            komut.Parameters.AddWithValue("@Gorevi",txtGorev.Text);
            komut.Parameters.AddWithValue("@IzinGunu",cbIzinGunu.SelectedItem);
            komut.Parameters.AddWithValue("@Ucret",txtUcret.Text);
            komut.Parameters.AddWithValue("@Aciklama",rtxtAciklama.Text);


            MessageBox.Show("Kayıt Başarıyla Eklendi","BİLGİ");
            txtCalisanAdi.Clear();
            cbCalismaSaatler.SelectedIndex = -1;
            cbIzinGunu.SelectedIndex = -1;
            txtGorev.Clear();
            txtUcret.Clear();
            rtxtAciklama.Clear();
            con.Open();
            komut.ExecuteNonQuery();
            con.Close();
            }
            else
            {
                MessageBox.Show("Lütfen Alanları Doldurunuz","DİKKAT");
            }

            

        }
    }
}
