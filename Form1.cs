using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HesapMakinesi
{
    public partial class Form1 : Form
    {
        double ilkSayi;
        double ikinciSayi;
        char sembol;
        double cevap;
        Hesaplama hs = new Hesaplama(0.0, 0.0, ' ');
        public Form1()
        {
            InitializeComponent();
        }
        private void metroButton12_Click(object sender, EventArgs e)
        {
            EkranYaz("1");
        }
        private void btn0_Click(object sender, EventArgs e)
        {
            EkranYaz("0");
        }
        private void btn2_Click(object sender, EventArgs e)
        {
            EkranYaz("2");
        }
        private void btn3_Click(object sender, EventArgs e)
        {
            EkranYaz("3");
        }
        private void btn4_Click(object sender, EventArgs e)
        {
            EkranYaz("4");
        }
        private void btn5_Click(object sender, EventArgs e)
        {
            EkranYaz("5");
        }
        private void btn6_Click(object sender, EventArgs e)
        {
            EkranYaz("6");
        }
        private void btn7_Click(object sender, EventArgs e)
        {
            EkranYaz("7");
        }
        private void btn8_Click(object sender, EventArgs e)
        {
            EkranYaz("8");
        }
        private void btn9_Click(object sender, EventArgs e)
        {
            EkranYaz("9");
        }
        private void btnVirgul_Click(object sender, EventArgs e)
        {
            EkranYaz(",");
        }
        private void btnSil_Click(object sender, EventArgs e)
        {
            txtAlani.Text = null;
        }
        private void btnTopla_Click(object sender, EventArgs e)
        {
            Islem('+');
        }
        private void btnEsittir_Click(object sender, EventArgs e)
        {
           ikinciSayi =Convert.ToDouble( txtAlani.Text);
           cevap=hs.HesapYap(ilkSayi, ikinciSayi, sembol);
           txtAlani.Text = Convert.ToString(cevap);

        }
        private void btnCikart_Click(object sender, EventArgs e)
        {
            Islem('-');
        }

        private void btnCarp_Click(object sender, EventArgs e)
        {
            Islem('*');
        }

        private void btnBol_Click(object sender, EventArgs e)
        {
            Islem('/');
        }
        public string EkranYaz(string sayi)
        {
            if (txtAlani.Text == null && txtAlani.Text == "0")
              return txtAlani.Text = sayi;
            else
             return txtAlani.Text = txtAlani.Text + sayi;
        }
        public void Islem(char opt)
        {
            ilkSayi = Convert.ToDouble(txtAlani.Text);
            txtAlani.Text = null;
            sembol = opt;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }

}
