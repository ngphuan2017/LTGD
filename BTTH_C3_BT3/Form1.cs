using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTTH_C3_BT1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void rdCong_CheckedChanged(object sender, EventArgs e)
        {
            lbDau.Text = rdCong.Text;
            PhanSo ps1, ps2;
            ps1 = new PhanSo(int.Parse(txtTuso1.Text), int.Parse(txtMauso1.Text));
            ps2 = new PhanSo(int.Parse(txtTuso2.Text), int.Parse(txtMauso2.Text));
            PhanSo kq = ps1.Cong(ps2);
            txtTuso3.Text = kq.Tuso.ToString();
            txtMauso3.Text = kq.Mauso.ToString();
        }

        private void rdTru_CheckedChanged(object sender, EventArgs e)
        {
            lbDau.Text = rdTru.Text;
            PhanSo ps1, ps2;
            ps1 = new PhanSo(int.Parse(txtTuso1.Text), int.Parse(txtMauso1.Text));
            ps2 = new PhanSo(int.Parse(txtTuso2.Text), int.Parse(txtMauso2.Text));
            PhanSo kq = ps1.Tru(ps2);
            txtTuso3.Text = kq.Tuso.ToString();
            txtMauso3.Text = kq.Mauso.ToString();
        }

        private void rdNhan_CheckedChanged(object sender, EventArgs e)
        {
            lbDau.Text = rdNhan.Text;
            PhanSo ps1, ps2;
            ps1 = new PhanSo(int.Parse(txtTuso1.Text), int.Parse(txtMauso1.Text));
            ps2 = new PhanSo(int.Parse(txtTuso2.Text), int.Parse(txtMauso2.Text));
            PhanSo kq = ps1.Nhan(ps2);
            txtTuso3.Text = kq.Tuso.ToString();
            txtMauso3.Text = kq.Mauso.ToString();
        }

        private void rdChia_CheckedChanged(object sender, EventArgs e)
        {
            lbDau.Text = rdChia.Text;
            PhanSo ps1, ps2;
            ps1 = new PhanSo(int.Parse(txtTuso1.Text), int.Parse(txtMauso1.Text));
            ps2 = new PhanSo(int.Parse(txtTuso2.Text), int.Parse(txtMauso2.Text));
            PhanSo kq = ps1.Chia(ps2);
            txtTuso3.Text = kq.Tuso.ToString();
            txtMauso3.Text = kq.Mauso.ToString();
        }
    }
}
