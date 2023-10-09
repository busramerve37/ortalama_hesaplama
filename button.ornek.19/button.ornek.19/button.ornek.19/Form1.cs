using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace button.ornek._19
{
    public partial class lblDurum : Form
    {
        public lblDurum()
        {
            InitializeComponent();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            float yazili1, yazili2, ortalama;
            yazili1 = Convert.ToSingle(txtYazili1.Text);
            yazili2 = Convert.ToSingle(txtYazili2.Text);
            ortalama = (yazili1 + yazili2) / 2;

            if (ortalama>=50)
            {
                label3.Text = "Durum: Geçti";
                label3.ForeColor = Color.Green;
            }
            else
            {
                label3.Text = "Durum: Kaldı";
                label3.ForeColor= Color.Red;
                //isimlendirmelere dikkat
            }
            lblOrtalama.Text = "Ortalama:" + ortalama.ToString();

        }   
            
            
    }
}
