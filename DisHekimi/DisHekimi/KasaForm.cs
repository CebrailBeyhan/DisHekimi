using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DisHekimi
{
    public partial class KasaForm : Form
    {
        public KasaForm()
        {
            InitializeComponent();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            Hesapla();
        }


        int sayi1, sayi2;

        private void Hesapla()
        {
            int.TryParse(txtFiyat.Text, out sayi1);
            //int.TryParse(txtSayi2.Text, out sayi2);

            lblSonuc.Text = (sayi1*8/100).ToString();
            //console otomatik yaparken burada string dönüşümü yazmalıyız.
        }

        

        private void KasaForm_Load(object sender, EventArgs e)
        {

        }
    }
}
