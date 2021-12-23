using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.SqlServer.Server;
using System.Diagnostics;
using System.Data.SqlClient;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)     
        {
            try
            {
                System.Diagnostics.Debug.WriteLine("Within The Try");
                SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-JA7JV1Q\SQLEXPRESS;Initial Catalog=Northwind;Integrated Security=True");
                connection.Open();
                CheckConnectionLabel.Text = "Connection Successful";
                connection.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
            
        }

        private void ViewButton_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand();
            SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-JA7JV1Q\SQLEXPRESS;Initial Catalog=Northwind;Integrated Security=True");
            connection.Open();

            command.Connection = connection;
            command.CommandText = "select * from Customers";
            SqlDataAdapter da = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            connection.Close();
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand();
            SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-JA7JV1Q\SQLEXPRESS;Initial Catalog=Northwind;Integrated Security=True");
            connection.Open();

            command.Connection = connection;
            command.CommandText = "insert into Customers (CustomerID, CompanyName) values('" + textBox1.Text + "','" + textBox2.Text + "')";
            command.ExecuteNonQuery();
            MessageBox.Show("Data saved");
            connection.Close();
        }

        private void CountButton_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand();
            SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-JA7JV1Q\SQLEXPRESS;Initial Catalog=Northwind;Integrated Security=True");
            connection.Open();

            command.Connection = connection;
            command.CommandText = "select count(*) from Customers";
            int count = (int)command.ExecuteScalar();
            lblCount.Text = count.ToString();

        }
    }
}
