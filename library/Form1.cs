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
    public partial class Form1 : Form
    {
        Form3 frm2 = new Form3();
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source=DESKTOP-GK09A6H\\MSSQL;Initial Catalog=library;Integrated Security=True");

        private void button1_Click(object sender, EventArgs e)
        {

        }
        

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void kitapTanımToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 frm4 = new Form4();
            frm4.MdiParent = this;
            frm4.Show();
            //dataGridViewBookDefinition.Visible = true;
            //panel1.Visible =true;
            //btnFind.Visible = true;
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtBookname_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void memberDefinationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 frm5 = new Form5();
            frm5.MdiParent = this;
            frm5.Show();

        }

        private void dataGridViewBookDefinition_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridViewBookDefinition_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
             
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAddTable_Click(object sender, EventArgs e)
        {
          
        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }
        /*string Select = "Select * from book";
        SqlDataAdapter da = new SqlDataAdapter(Select, con);
        DataTable dt = new DataTable();
        da.Fill(dt);
            dataGridViewBookDefinition.DataSource = dt;*/
        private void btnFind_Click_1(object sender, EventArgs e)
        {
            /*if (textBox1.Text.Trim()=="" & textBox2.Text.Trim()=="" & textBox3.Text.Trim()==""&textBox4.Text.Trim()=="")
            {
                SqlDataAdapter da = new SqlDataAdapter("Select * from book", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridViewBookDefinition.DataSource = dt;
            }
            else if(textBox1.Text!="")
            {
                SqlDataAdapter da = new SqlDataAdapter("Select * from book where book_name Like '%"+textBox1.Text+"%'", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridViewBookDefinition.DataSource = dt;
            }
            else if (textBox2.Text != "")
            {
                SqlDataAdapter da = new SqlDataAdapter("Select * from book where writer Like '%" + textBox2.Text + "%'", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridViewBookDefinition.DataSource = dt;
            }
            else if (textBox3.Text != "")
            {
                SqlDataAdapter da = new SqlDataAdapter("Select * from book where book_type Like '%" + textBox3.Text + "%'", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridViewBookDefinition.DataSource = dt;
            }
            else if (textBox4.Text!="")
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
            */

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void bookProcessToolStripMenuItem_Click(object sender, EventArgs e)
        {

            ProcessForm frm7 = new ProcessForm();
            frm7.MdiParent = this;
            frm7.Show();
        }

        private void processToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

       /* private void btnAdd_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand komut =new SqlCommand("Insert into book(book_name,writer,book_type,publisher) Values('"+txtBookName.Text+"','"+txtWriter.Text+"','"+txtBookType.Text+"','"+txtPublisher.Text+"')",con);
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
         
        private void txtBookName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBookType_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPublisher_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtWriter_TextChanged(object sender, EventArgs e)
        {
             
        }

        private void dataGridViewBookProcess_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

      /*  private void btnDelete_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand komut = new SqlCommand("delete from book where book_id='"+txtDelete.Text+"'", con);
            komut.ExecuteNonQuery();
            dataGridViewBookProcess.Update();
            SqlDataAdapter da = new SqlDataAdapter("Select * from book", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridViewBookProcess.DataSource = dt;
            txtDelete.Clear();
        }*/

        private void btnMemberFind_Click(object sender, EventArgs e)
        {
           
        }

        private void btnAdd2_Click(object sender, EventArgs e)
        {
            /*con.Open();
            SqlCommand komut = new SqlCommand("Insert into members(name,surname,adress,e-mail,phone_number) Values('" + textBox5.Text + "','" + textBox6.Text + "','" + textBox7.Text + "','" + textBox8.Text + "','"+textBox9.Text+"')", con);
            komut.ExecuteNonQuery();
            dataGridViewMemberProcess.Update();
            SqlDataAdapter da = new SqlDataAdapter("Select * from members", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridViewMemberProcess.DataSource = dt;
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            textBox9.Clear();
            textBox5.Focus();*/
        }

        private void memberProcessToolStripMenuItem_Click(object sender, EventArgs e)
        {
         
            //pnlMember.Visible = false;
            //pnlmemberprocess.Visible = true;

        }

        private void btnDelete2_Click(object sender, EventArgs e)
        {
          /*  con.Open();
            SqlCommand komut = new SqlCommand("delete from members where member_id='" + textBox10.Text + "'", con);
            komut.ExecuteNonQuery();
            dataGridViewMemberProcess.Update();
            SqlDataAdapter da = new SqlDataAdapter("Select * from members", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridViewMemberProcess.DataSource = dt;
            textBox10.Clear();*/
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
            frm2.MdiParent = this;
            frm2.Show();
           // panel1.Visible = false;
           // frm2.Activate();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            /*DialogResult answer = new DialogResult();
            answer = MessageBox.Show("Are you sure about that? ", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (answer == DialogResult.Yes)
            {
                con.Open();
                SqlCommand komut = new SqlCommand("delete from book where book_id='" + dataGridViewBookDefinition.CurrentRow.Cells[0].Value.ToString() + "'", con);
                komut.ExecuteNonQuery();
                dataGridViewBookDefinition.Update();
                SqlDataAdapter da = new SqlDataAdapter("Select * from book", con);
                DataTable dt = new DataTable();
                da.Fill(dt); 
                con.Close();*/
                

            }

        private void processListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProcessList frm8 = new ProcessList();
            frm8.MdiParent = this;
            frm8.Show();
        }
    }

        
    }

