using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace öğrencinin_net_hesaplaması
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            int dogru, yanlis;
            double netDogru;

            dogru = Convert.ToInt32(cmbDogru.Text);
            yanlis = Convert.ToInt32(cmbYanlis.Text);

            netDogru = dogru - yanlis / 4.0;

            lblNet.Text = "Toplam Net Doğru :" + netDogru.ToString();
        }
    }
}
