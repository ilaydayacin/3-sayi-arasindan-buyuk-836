using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3_sayıdan_büyük_küçük
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHesap_Click(object sender, EventArgs e)
        {
            int sayi1, sayi2, sayi3;
            sayi1 = Convert.ToInt32(txtS1.Text);
            sayi2 = Convert.ToInt32(txtS2.Text);
            sayi3 = Convert.ToInt32(txtS3.Text);

            if (sayi1 > sayi2 && sayi1 > sayi3)
            {
                lblSonuc.Text = "Sonuç: 1. Sayı daha büyük";
            }
            else if (sayi2 > sayi1 && sayi2 > sayi3)
            {
                lblSonuc.Text = "Sonuç: 2. Sayı daha büyük";
            }
            else
            {
                lblSonuc.Text = "Sonuç: 3. Sayı daha büyük";
            }
        }
    }
}
