using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BTL_LTGD
{
    public partial class Form4 : Form
    {
        SqlConnection connection;
        SqlCommand cmd;
        string str = "Data Source=ANIT;Initial Catalog=BenhVienDB;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        public Form4()
        {
            InitializeComponent();
        }
        void loaddata()
        {
            cmd = connection.CreateCommand();
            cmd.CommandText = "select * from BenhNhan where MaBenhNhan in (select MaBenhNhan from HoSo where ThongTinDieuTri = N'Đang được chữa trị')";
            adapter.SelectCommand = cmd;
            table.Clear();
            adapter.Fill(table);
            dataGridView1.DataSource = table;

        }
        private void Form4_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            loaddata();
        }

        private void btnBack1_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
            Form1 f0 = new Form1();
            f0.ShowDialog();
        }
    }
}
