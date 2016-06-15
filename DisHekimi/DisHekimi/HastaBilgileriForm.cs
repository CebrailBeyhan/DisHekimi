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
    public partial class HastaBilgileriForm : Form
    {
        SqlConnection con = new SqlConnection("server=RJ-45RJ; database=DisHekimi; integrated security=true");

        public HastaBilgileriForm()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        void HastaGetir()
        {
            SqlDataAdapter adp = new SqlDataAdapter("select * from Hastalar", con);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            cbHastaAdi.DisplayMember = "HastaAdi";
            cbHastaAdi.ValueMember = "HastaID";
            cbHastaAdi.DataSource = dt;



        }

        private void HastaBilgileriForm_Load(object sender, EventArgs e)
        {
            HastaGetir();
        }

        private void btnCalisanKaydet_Click(object sender, EventArgs e)
        {
            // SqlDataAdapter adp = new SqlDataAdapter(string.Format("select * from Hastalar where HastaID={0}",cbHastaAdi.SelectedValue), con);
            SqlDataAdapter adp = new SqlDataAdapter("select * from Hastalar where HastaID=@id", con);
            adp.SelectCommand.Parameters.AddWithValue("id",cbHastaAdi.SelectedValue);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            lblHastaAdi.Text = dt.Rows[0]["hastaadi"].ToString();
            lblTelefon.Text = dt.Rows[0]["Telefon"].ToString();
            lblCinsiyet.Text = dt.Rows[0]["Cinsiyet"].ToString();
            lblAdres.Text = dt.Rows[0]["Adres"].ToString();
           


            cbHastaAdi.SelectedIndex = -1;
            HastaBilgileriGetir();
        }
        
        void HastaBilgileriGetir()

        {

            SqlDataAdapter adp = new SqlDataAdapter("select * from Hastalar",con);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            cbHastaAdi.DisplayMember = "HastaAdi";
            cbHastaAdi.ValueMember = "HastaID";
            cbHastaAdi.DataSource = dt;
           

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            SqlDataAdapter adp = new SqlDataAdapter("select * from Hastalar", con);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            cbHastaAdi.DisplayMember = "HastaAdi";
            cbHastaAdi.ValueMember = "HastaID";
            cbHastaAdi.DataSource = dt;


            //if (cbHastaAdi.SelectedIndex > -1)
            //{

            //    lblHastaAdi.Text=
               
            //}

        }

        private void btnAna_Click(object sender, EventArgs e)
        {
            Ana AnayaGit = new Ana();
            this.Hide();
            AnayaGit.ShowDialog();
            this.Show();
        }

        //void ComboBilgi()
        //{
            
        //    string SqlText = @"select * from Hastalar ";
        //    SqlCommand komut = new SqlCommand(SqlText,con);
        //    SqlDataAdapter adp = new SqlDataAdapter(komut);
        //    DataTable dt = new DataTable();
        //    adp.Fill(dt);
        //    cbHastaAdi.DataSource = dt;
        //     if (cbHastaAdi.SelectedIndex == 1)
        //    {
        //    cbHastaAdi .ValueMember = "id";
        //    cbHastaAdi.DisplayMember = "AdapazarıGar";
        //    }
        
        //}

        //void labeGetir()
        //{


        //    if (cbHastaAdi.SelectedIndex > -1)
        //    {
        //        Ders d = (Ders)Ders.tumDersler[index];
        //        lblHastaAdi.Text = d.DersAdi;
        //        lblTelefon.Text = d.dersSaati.ToString();
        //        lblCinsiyet.Text = d.DersKredisi.ToString();
        //    }
        //}
         
    }
}
