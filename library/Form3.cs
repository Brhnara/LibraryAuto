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
namespace library
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-GK09A6H\\MSSQL;Initial Catalog=library;Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand komut = new SqlCommand("Insert into book(book_name,writer,book_type,publisher) Values('" + txtBookname.Text + "','" + txtWriter.Text + "','" + txtBooktype.Text + "','" + txtPublisher.Text + "')", con);
            komut.ExecuteNonQuery();
           
            SqlDataAdapter da = new SqlDataAdapter("Select * from book", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridViewAddbook.DataSource = dt;
            dataGridViewAddbook.Update();
            txtBookname.Clear();
            txtWriter.Clear();
            txtBooktype.Clear();
            txtPublisher.Clear();
            con.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand komut = new SqlCommand("update book  set   book_name='"+txtBookname.Text+"',writer='"+txtWriter.Text+"',book_type='"+txtBooktype.Text+"',publisher='"+txtPublisher.Text+"'where book_name='"+dataGridViewAddbook.CurrentRow.Cells[1].Value.ToString()+"'", con);
            komut.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter("Select * from book", con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridViewAddbook.DataSource = ds.Tables[0];
            
            MessageBox.Show("updated succesfully");
            txtBookname.Clear();
            txtWriter.Clear();
            txtBooktype.Clear();
            txtPublisher.Clear();
            con.Close();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            
        }

        private void dataGridViewAddbook_CellStateChanged(object sender, DataGridViewCellStateChangedEventArgs e)
        {

        }

        private void dataGridViewAddbook_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int area = dataGridViewAddbook.SelectedCells[0].RowIndex;
             txtBookname.Text = dataGridViewAddbook.Rows[area].Cells[1].Value.ToString();
             txtWriter.Text = dataGridViewAddbook.Rows[area].Cells[2].Value.ToString();
             txtBooktype.Text = dataGridViewAddbook.Rows[area].Cells[3].Value.ToString();
             txtPublisher.Text = dataGridViewAddbook.Rows[area].Cells[4].Value.ToString();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridViewAddbook_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
