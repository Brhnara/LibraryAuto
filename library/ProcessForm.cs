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
    public partial class ProcessForm : Form
    {
        public ProcessForm()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-GK09A6H\\MSSQL;Initial Catalog=library;Integrated Security=True");
   
       
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxMember_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void ProcessForm_Load(object sender, EventArgs e)
        {
    

            SqlCommand komut = new SqlCommand("select * from members ");
           

            komut.Connection = con;
           

            komut.CommandType = CommandType.Text;
           
            SqlDataReader dr;
            con.Open();
           
          dr = komut.ExecuteReader();
            while (dr.Read())
            {
               
                comboBox1.Items.Add(dr["name"].ToString()+ dr["surname"].ToString());
            

            }
            con.Close();
            
        }
        private void ProcessForm_Load1(object sender, EventArgs e)
        {
            deliveryTime.Format = DateTimePickerFormat.Custom;
            deliveryTime.CustomFormat = "   ";
            SqlCommand komut = new SqlCommand("select * from book");
            komut.Connection = con;
            komut.CommandType = CommandType.Text;
            SqlDataReader dr;
            con.Open();
            dr = komut.ExecuteReader();
            
            while (dr.Read())
            {
                comboBox2.Items.Add(dr["book_name"]);
            }
            con.Close();

        }

        private void dateTimePicker3_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            /* borrowedTime.Format = DateTimePickerFormat.Custom;
             borrowedTime.CustomFormat = "YYYY.MM.DD";
             deliveryTime.Format = DateTimePickerFormat.Custom;
             deliveryTime.CustomFormat = "YYYY.MM.DD";*/
            deliveryTime.Format = DateTimePickerFormat.Custom;
            deliveryTime.CustomFormat = " ";
            SqlCommand kmt = new SqlCommand("Insert into process(name,book,borrow_time,notes) Values ('" + comboBox1.Text + "','" + comboBox2.Text + "',@borrowedtime,'" +txtNotes.Text + "')", con);
            kmt.Parameters.AddWithValue("@borrowedtime", borrowedTime.Value.Date);
            //kmt.Parameters.AddWithValue("@deliverytime", deliveryTime.Value.Date);
        kmt.ExecuteNonQuery();
            MessageBox.Show("Added succesfully");
            con.Close();
           
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void deliveryTime_ValueChanged(object sender, EventArgs e)
        {
            deliveryTime.Format = DateTimePickerFormat.Short;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            ProcessList prlist = new ProcessList();
           
           SqlCommand komut = new SqlCommand("update process  set   NAME='" + comboBox1.Text + "',book='" + comboBox2.Text + "',borrow_time=@borrowedtime,delivery_time=@deliverytime,notes='" + txtNotes.Text + "'where process_id= @test ", con);
            komut.Parameters.AddWithValue("@borrowedtime", borrowedTime.Value.Date);
            komut.Parameters.AddWithValue("@test",prlist.dataGridViewProcessList.CurrentRow.Cells[0].Value.ToString());
            komut.Parameters.AddWithValue("@deliverytime", deliveryTime.Value.Date);
            con.Open();
            komut.ExecuteNonQuery();
            con.Close();
            SqlDataAdapter da = new SqlDataAdapter("Select * from process", con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            prlist.dataGridViewProcessList.DataSource = ds.Tables[0];

            MessageBox.Show("updated succesfully");
        }
    }
}
