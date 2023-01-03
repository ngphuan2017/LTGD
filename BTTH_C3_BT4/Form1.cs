using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTTH_C3_BT4
{
    public partial class Form1 : Form
    {
        private int dy = 20;
        private int dx = 20;

        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (picBall.Left < 0 || picBall.Right > ClientRectangle.Width)
                dx = -dx;
            if (picBall.Top < 0 || picBall.Bottom > ClientRectangle.Height)
                dy = -dy;
            picBall.Left += dx;
            picBall.Top += dy;
        }
    }
}
