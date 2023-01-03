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
    public partial class Form3 : Form
    {
        SqlConnection connection;
        SqlCommand cmd;
        string str = "Data Source=ANIT;Initial Catalog=BenhVienDB;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();

        void loaddata()
        {
            cmd = connection.CreateCommand();
            cmd.CommandText = "select * from HoSo ";
            adapter.SelectCommand = cmd;
            table.Clear();
            adapter.Fill(table);
            dataGridView1.DataSource = table;

        }
        public Form3()
        {

            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            loaddata();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            cmd = connection.CreateCommand();
            cmd.CommandText = "insert into HoSo values('" + textBox1.Text + "', N'" + textBox2.Text + "', '" + textBox3.Text + "', N'" + textBox4.Text + "', N'" + textBox5.Text + "')";
            cmd.ExecuteNonQuery();
            loaddata();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            cmd = connection.CreateCommand();
            cmd.CommandText = "delete from HoSo where MaHoSo= '" + textBox1.Text + "'";
            cmd.ExecuteNonQuery();
            loaddata();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            cmd = connection.CreateCommand();
            cmd.CommandText = "update HoSo set MaBenhNhan= N'" + textBox2.Text + "', MaBacSi= '" + textBox3.Text + "', HoTenBacSi= N'" + textBox4.Text + "', ThongTinDieuTri=  N'" + textBox5.Text + "' where MaHoSo= '" + textBox1.Text + "'";
            cmd.ExecuteNonQuery();
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

        private void btnBack1_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
            Form1 f0 = new Form1();
            f0.ShowDialog();
        }
    }
}
