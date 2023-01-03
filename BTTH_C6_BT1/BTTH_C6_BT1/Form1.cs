using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTTH_C6_BT1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labText.Text = labText.Text.Substring(1) + labText.Text.Substring(0, 1);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void btnChen_Click(object sender, EventArgs e)
        {
            try
            {
                string s1, s2;
                s1 = txt1.Text;
                s2 = txt2.Text;
                int vt = int.Parse(txtvt.Text);
                s1 = s1.Insert(vt, s2);
                txt1.Text = s1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo");
            }
        }

        private void btnThayThe_Click(object sender, EventArgs e)
        {
            try
            {
                string s1, s2, s3;
                s1 = txt1.Text;
                s2 = txt2.Text;
                s3 = txt3.Text;
                s1 = s1.Replace(s2, s3);
                txt1.Text = s1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                string s1, s2;
                s1 = txt1.Text;
                s2 = txt2.Text;
                s1 = s1.Remove(s1.IndexOf(s2), s2.Length);
                txt1.Text = s1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo");
            }
        }

        private void btnDao_Click(object sender, EventArgs e)
        {
            try
            {
                string s1;
                s1 = txt1.Text;
                string [] dao = s1.Split(new char[] {' ', ','}, StringSplitOptions.RemoveEmptyEntries);
                s1 = "";
                for (int i = dao.Length - 1; i >= 0; i--)
                    s1 += dao[i] + " ";
                txt1.Text = s1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo");
            }
        }

        private void btnChuanHoa_Click(object sender, EventArgs e)
        {
            try
            {
                string s1;
                s1 = txt1.Text;
                string[] dao = s1.Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
                s1 = "";
                for (int i = 0; i < dao.Length; i++)
                {
                    string s = dao[i].Substring(0, 1).ToUpper() + dao[i].Substring(1).ToLower();
                    if (i != dao.Length - 1)
                        s1 += s + " ";
                    else
                        s1 += s;
                }
                txt1.Text = s1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo");
            }
        }
    }
}
