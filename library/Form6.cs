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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-GK09A6H\\MSSQL;Initial Catalog=library;Integrated Security=True");
        private void btnAdd_Click(object sender, EventArgs e)
        {
            con.Open();
           SqlCommand kmt = new SqlCommand("Insert into members(name,surname,adress,email,phone_number) Values ('" + txtMemberName.Text + "','" + txtSurname.Text + "','" + txtAdress.Text + "','" + txtEmail.Text + "','"+txtPhonenumber.Text+"')", con);

            kmt.ExecuteNonQuery();


            dataGridViewMemberDefination.Update();
           SqlDataAdapter da = new SqlDataAdapter("Select * from members", con);
           DataTable dt = new DataTable();
           da.Fill(dt);
            dataGridViewMemberDefination.DataSource = dt;
            con.Close();
          

           txtMemberName.Clear();
           txtSurname.Clear();
           txtAdress.Clear();
           txtEmail.Clear();
           txtPhonenumber.Clear();
           txtMemberName.Focus();
        }

        private void dataGridViewMemberDefination_Click(object sender, EventArgs e)
        {

        }

        private void dataGridViewMemberDefination_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int area = dataGridViewMemberDefination.SelectedCells[0].RowIndex;
            txtMemberName.Text = dataGridViewMemberDefination.Rows[area].Cells[1].Value.ToString();
            txtSurname.Text = dataGridViewMemberDefination.Rows[area].Cells[2].Value.ToString();
            txtAdress.Text = dataGridViewMemberDefination.Rows[area].Cells[3].Value.ToString();
            txtEmail.Text = dataGridViewMemberDefination.Rows[area].Cells[4].Value.ToString();
            txtPhonenumber.Text = dataGridViewMemberDefination.Rows[area].Cells[5].Value.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand komut = new SqlCommand("update members  set   name='" + txtMemberName.Text + "',surname='" + txtSurname.Text + "',adress='" + txtAdress.Text + "',email='" + txtEmail.Text + "',phone_number='"+txtPhonenumber.Text+"'where name='" + dataGridViewMemberDefination.CurrentRow.Cells[1].Value.ToString() + "'", con);
           komut.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter("Select * from members", con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridViewMemberDefination.DataSource = ds.Tables[0];

            MessageBox.Show("updated succesfully");
            txtMemberName.Clear();
            txtSurname.Clear();
            txtAdress.Clear();
            txtEmail.Clear();
            txtPhonenumber.Clear();
            con.Close();
        }
    }
}
