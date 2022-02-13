using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace DispGVC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql = "insert into Fruit values ('" + textBox1.Text + "','" + textBox2.Text + "')";
            SqlDataAdapter da = new SqlDataAdapter(sql, Class1.cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            MessageBox.Show("Inserted!");
            disp();
            clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Focus();
            disp();
        }

        private void disp()
        {
            string sql = "select * from Fruit";
            SqlDataAdapter da = new SqlDataAdapter(sql, Class1.cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void clear()
        {
            textBox1.Text = " ";
            textBox2.Text = " ";
            textBox1.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = " ";
            textBox2.Text = " ";
            textBox1.Focus();
        }

    }
}
