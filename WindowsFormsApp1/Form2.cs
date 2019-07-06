using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
   
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source=DESKTOP-GK09A6H\\MSSQL;Initial Catalog=library;Integrated Security=True");

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void pnlBookProcess_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            
        }

        /*private void btnAdd_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand komut = new SqlCommand("Insert into book(book_name,writer,book_type,publisher) Values('" + txtBookName.Text + "','" + txtWriter.Text + "','" + txtBookType.Text + "','" + txtPublisher.Text + "')", con);
            komut.ExecuteNonQuery();
            dataGridViewBookProcess.Update();
            SqlDataAdapter da = new SqlDataAdapter("Select * from book", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridViewBookProcess.DataSource = dt;
            txtBookName.Clear();
            txtWriter.Clear();
            txtBookType.Clear();
            txtPublisher.Clear();
        }*/
    }
}
