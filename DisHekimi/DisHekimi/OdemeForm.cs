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
    public partial class OdemeForm : Form
    {
        public OdemeForm()
        {
            InitializeComponent();
        }

        private void Ödeme_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

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
