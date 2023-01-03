using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTTH_C6_BT2
{
    public partial class Form1 : Form
    {
        int n;
        int[] a;
        int[] copy;
        public Form1()
        {
            InitializeComponent();
        }
        private void Show(int[] a, int l, TextBox txt)
        {
            string kq = "";
            for(int i=0; i<l; i++)
            {
                if (i == 0)
                    kq = a[i].ToString();
                else
                    kq += ", " + a[i].ToString();
            }
            txt.Text = kq;

        }
        private void Check(int[]a, int l, TextBox txt)
        {
            string kq = "";
            for (int i = 0; i < l; i++)
            {
                if(a[i] > 3)
                {
                    for (int j = 2; j < a[i]; i++)
                        if (a[i] % j == 0)
                            break;
                        else
                            kq += a[i].ToString() + ", ";
                }
                else
                    kq += a[i].ToString() + ", ";
            }
            txt.Text = kq;
        }
        private void btnTaoMang_Click(object sender, EventArgs e)
        {
            n = int.Parse(txt1.Text);
            Random rd = new Random();
            int chan = 0, le = 0, tong=0;
            double tb;
            a = new int[n];
            copy = new int[n];
            for(int i=0; i<n; i++)
            {
                a[i] = rd.Next(0, 100);
                tong += a[i];
                if (a[i] % 2 == 0)
                    chan += a[i];
                else
                    le += a[i];
            }
            tb = tong / n;
            txtChan.Text = chan.ToString();
            txtLe.Text = le.ToString();
            txtTb.Text = tb.ToString();
            Show(a, n, txtMang);
            Check(a, n, txtNguyenTo);
        }
        private void Sort()
        {
            Array.Copy(a, copy, n);
            Array.Sort(copy);
            Show(copy, n, txtTang);
            Array.Reverse(copy);
            Show(copy, n, txtGiam);
            Array.Copy(a, copy, n);
            Array.Reverse(copy);
            Show(copy, n, txtDao);
        }
        private void swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
        private void SortCL()
        {
            Array.Copy(a, copy, n);
            for (int i = 0; i < n - 1; i++)
                for (int j = i + 1; j < n; j++)
                {
                    if (copy[i] % 2 == 0 && copy[j] % 2 == 0 && copy[i] > copy[j])
                        swap(ref copy[i], ref copy[j]);
                    else if (copy[i] % 2 != 0 && copy[j] % 2 != 0 && copy[i] < copy[j])
                        swap(ref copy[i], ref copy[j]);
                    else if(copy[i] %2 != 0 && copy[j] %2 == 0)
                        swap(ref copy[i], ref copy[j]);
                }
            Show(copy, n, txtSapXep);
        }

        private void btnSapXep_Click(object sender, EventArgs e)
        {
            Sort();
            SortCL();
        }
    }
}
