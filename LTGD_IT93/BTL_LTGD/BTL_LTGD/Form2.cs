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
    public partial class Form2 : Form
    {
        SqlConnection connection;
        SqlCommand cmd;
        string str = "Data Source=ANIT;Initial Catalog=BenhVienDB;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();

        void loaddata()
        {
            cmd = connection.CreateCommand();
            cmd.CommandText = "select * from BenhNhan ";
            adapter.SelectCommand = cmd;
            table.Clear();
            adapter.Fill(table);
            dataGridView1.DataSource = table;

        }
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            loaddata();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.ReadOnly = true;
            int i;
            i = dataGridView1.CurrentRow.Index;
            textBox1.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
            textBox5.Text = dataGridView1.Rows[i].Cells[4].Value.ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            cmd = connection.CreateCommand();
            cmd.CommandText = "insert into BenhNhan values('"+textBox1.Text+ "', N'"+textBox2.Text+ "', '" +textBox3.Text+ "', N'" +textBox4.Text+ "', N'" +textBox5.Text+ "')";
            cmd.ExecuteNonQuery();
            loaddata();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            cmd = connection.CreateCommand();
            cmd.CommandText = "delete from BenhNhan where MaBenhNhan= '"+textBox1.Text+"'";
            cmd.ExecuteNonQuery();
            loaddata();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            cmd = connection.CreateCommand();
            cmd.CommandText = "update BenhNhan set HoTen= N'" +textBox2.Text+ "', SoDienThoai= '" +textBox3.Text+ "', BenhLy= N'" +textBox4.Text+ "', ChiTietBenhLy=  N'" +textBox5.Text+ "' where MaBenhNhan= '"+textBox1.Text+"'";
            cmd.ExecuteNonQuery();
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
