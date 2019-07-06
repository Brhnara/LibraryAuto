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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-GK09A6H\\MSSQL;Initial Catalog=library;Integrated Security=True");
        private void btnMemberFind_Click(object sender, EventArgs e)
        {
            if (txtMemberName.Text.Trim() == "" & txtSurname.Text.Trim() == "" & txtAdress.Text.Trim() == "" & txtEmail.Text.Trim() == "" & txtPhonenumber.Text.Trim() == "")
            {
                SqlDataAdapter da = new SqlDataAdapter("Select * from members", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridViewMemberList.DataSource = dt;
            }
            else if (txtMemberName.Text != "")
            {
                SqlDataAdapter da = new SqlDataAdapter("Select * from members where name Like '%" + txtMemberName.Text + "%'", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridViewMemberList.DataSource = dt;
            }
            else if (txtSurname.Text != "")
            {
                SqlDataAdapter da = new SqlDataAdapter("Select * from members where surname Like '%" + txtSurname.Text + "%'", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridViewMemberList.DataSource = dt;
            }
            else if (txtAdress.Text != "")
            {
                SqlDataAdapter da = new SqlDataAdapter("Select * from members where adress Like '%" + txtAdress.Text + "%'", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridViewMemberList.DataSource = dt;
            }
            else if (txtEmail.Text != "")
            {
                SqlDataAdapter da = new SqlDataAdapter("Select * from members where e-mail Like '%" + txtEmail.Text + "%'", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridViewMemberList.DataSource = dt;
            }
            else if (txtPhonenumber.Text != "")
            {
                SqlDataAdapter da = new SqlDataAdapter("Select * from members where phone_number Like '%" + txtPhonenumber.Text + "%'", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                //dataGridViewBookDefinition.DataSource = dt;

            }
            txtSurname.Clear();
            txtEmail.Clear();
            txtMemberName.Clear();

            txtAdress.Clear();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            Form6 frm6 = new Form6();
            frm6.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult answer = new DialogResult();
            answer = MessageBox.Show("Are you sure about that? ", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (answer == DialogResult.Yes)
            {
                con.Open();
                SqlCommand komut = new SqlCommand("delete from members where member_id='" + dataGridViewMemberList.CurrentRow.Cells[0].Value.ToString() + "'", con);
                komut.ExecuteNonQuery();

                dataGridViewMemberList.Update();
                SqlDataAdapter da = new SqlDataAdapter("Select * from members", con);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridViewMemberList.DataSource = ds.Tables[0];
                con.Close();


            }
        }
    }
}
