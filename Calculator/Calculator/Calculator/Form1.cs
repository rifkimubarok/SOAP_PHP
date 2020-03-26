using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        CalculateService.webservice wb = new CalculateService.webservice();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTambarh_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txt_a.Text);
            int b = int.Parse(txt_b.Text);
            int hasil = wb.Tambah(a, b);
            txt_hasil.Text = hasil.ToString();
        }

        private void btn_kurang_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txt_a.Text);
            int b = int.Parse(txt_b.Text);
            int hasil = wb.Kurang(a, b);
            txt_hasil.Text = hasil.ToString();
        }

        private void btn_kali_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txt_a.Text);
            int b = int.Parse(txt_b.Text);
            int hasil = wb.kali(a, b);
            txt_hasil.Text = hasil.ToString();
        }

        private void btn_bagi_Click(object sender, EventArgs e)
        {
            double a = double.Parse(txt_a.Text);
            double b = double.Parse(txt_b.Text);
            double hasil = wb.bagi(a, b);
            txt_hasil.Text = hasil.ToString();
        }
    }
}
