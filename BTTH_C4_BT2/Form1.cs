using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTTH_C4_BT2
{
    public partial class Form1 : Form
    {
        string path;
        int nChoose;
        int nCount, nWin, nLose;
        public Form1()
        {
            InitializeComponent();
        }

        private void btReset_CheckedChanged(object sender, EventArgs e)
        {
            Init();
        }

        private void btPlay_CheckedChanged(object sender, EventArgs e)
        {
            Random r = new Random();
            int res = r.Next(1, 7);

        }

        private void Init()
        {
            listResult.Items.Clear();
            lbLose.Text = lbCount.Text = lbWin.Text = "";
            nChoose = 1;
            picChoose.Image = Image.FromFile(path + "dice1.png");
            nCount = nWin = nLose = 0;
            picResult.Image = null;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            path = Application.StartupPath + @"\HinhXuxXac";
            Init();
        }
    }
}
