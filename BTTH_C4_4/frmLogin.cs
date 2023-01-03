using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTTH_C4_4
{
    public partial class frmLogin : Form
    {
        string ht;
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnDn_Click(object sender, EventArgs e)
        {
            ht = txtHT.Text;
            string mk = txtMK.Text;
            if (ht != "" && mk == "admin")
            {
                this.Hide();
                frmMain f1 = new frmMain(ht);
                f1.ShowDialog();
            }
            else
                MessageBox.Show("Xin nhập lại!", "Thông Báo");
        }
    }
}
