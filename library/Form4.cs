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
    public partial class Form4 : Form
    {
        
        //Form4 frm4 = new Form4();
        public Form4()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-GK09A6H\\MSSQL;Initial Catalog=library;Integrated Security=True");

        private void btnFind_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() == "" & textBox2.Text.Trim() == "" & textBox3.Text.Trim() == "" & textBox4.Text.Trim() == "")
            {
                SqlDataAdapter da = new SqlDataAdapter("Select * from book", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridViewBookDefinition.DataSource = dt;
            }
             if (textBox1.Text != "")
            {
                SqlDataAdapter da = new SqlDataAdapter("Select * from book where book_name Like '%" + textBox1.Text + "%'", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridViewBookDefinition.DataSource = dt;
            }
            if (textBox2.Text != "")
            {
                SqlDataAdapter da = new SqlDataAdapter("Select * from book where writer Like '%" + textBox2.Text + "%'", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridViewBookDefinition.DataSource = dt;
            }
            if (textBox3.Text != "")
            {
                SqlDataAdapter da = new SqlDataAdapter("Select * from book where book_type Like '%" + textBox3.Text + "%'", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridViewBookDefinition.DataSource = dt;
            }
            if (textBox4.Text != "")
            {
                SqlDataAdapter da = new SqlDataAdapter("Select * from book where publisher Like '%" + textBox4.Text + "%'", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridViewBookDefinition.DataSource = dt;
            }
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox1.Focus();

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            Form3 frm3 = new Form3();
            frm3.ShowDialog();
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult answer = new DialogResult();
            answer = MessageBox.Show("Are you sure about that? ", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (answer == DialogResult.Yes)
            {
                con.Open();
                SqlCommand komut = new SqlCommand("delete from book where book_id='" + dataGridViewBookDefinition.CurrentRow.Cells[0].Value.ToString() + "'", con);
                komut.ExecuteNonQuery();

                dataGridViewBookDefinition.Update();
                SqlDataAdapter da = new SqlDataAdapter("Select * from book", con);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridViewBookDefinition.DataSource = ds.Tables[0];
                con.Close();


            }
        }

        private void dataGridViewBookDefinition_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int area = dataGridViewBookDefinition.SelectedCells[0].RowIndex;
            textBox1.Text = dataGridViewBookDefinition.Rows[area].Cells[1].Value.ToString();
            textBox2.Text = dataGridViewBookDefinition.Rows[area].Cells[2].Value.ToString();
            textBox3.Text = dataGridViewBookDefinition.Rows[area].Cells[3].Value.ToString();
            textBox4.Text = dataGridViewBookDefinition.Rows[area].Cells[4].Value.ToString();
            
        }
    }
}
