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
using System.Data.OleDb;



namespace library
{
    public partial class ProcessList : Form
    {
        public ProcessList()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-GK09A6H\\MSSQL;Initial Catalog=library;Integrated Security=True");


        private void buttonFind_Click(object sender, EventArgs e)
        {

            SqlCommand kmt = new SqlCommand();

            if (textBoxMember.Text == "" && textBoxBook.Text == "" && dateTimePickerBorrowed.Checked == false && dateTimePickerBorrowed2.Checked == false && dateTimePickerDelivery.Checked == false && dateTimePickerDelivery2.Checked == false)
            {

                kmt.CommandText = "Select * from process";

            }
            if (textBoxMember.Text != "")
            {
                kmt.CommandText = "Select * from process where name Like '%" + textBoxMember.Text + "%'";

            }
            if (textBoxBook.Text != "")
            {
                kmt.CommandText = kmt.CommandText + "  and book Like '%" + textBoxBook.Text + "%'";

            }


            if (dateTimePickerBorrowed.Checked == true || dateTimePickerBorrowed2.Checked == true)
            {
                dateTimePickerBorrowed.Format = DateTimePickerFormat.Custom;
                dateTimePickerBorrowed.CustomFormat = "yyyy-MM-dd";
                dateTimePickerBorrowed2.Format = DateTimePickerFormat.Custom;
                dateTimePickerBorrowed2.CustomFormat = "yyyy-MM-dd";
                MessageBox.Show("dfsdff");
                kmt.CommandText = kmt.CommandText + "  AND ([borrow_time] <= @tarih1)";  /*and ([borrow_time] <= @tarih2)";*/

                //SqlCommand kmt1 = new SqlCommand("SELECT * FROM process WHERE borrow_time >= @tarih1 and borrow_time < @tarih2", con);

                kmt.Parameters.AddWithValue("@tarih1", SqlDbType.DateTime).Value=dateTimePickerBorrowed.Value.Date;
                kmt.Parameters.AddWithValue("@tarih2", SqlDbType.DateTime).Value=dateTimePickerBorrowed2.Value.Date;

                /*  SqlDataAdapter da1 = new SqlDataAdapter(kmt1);
                   DataTable tablosay1 = new DataTable();
                   tablosay1.Clear();
                   da1.Fill(tablosay1);
                   dataGridViewProcessList.DataSource = tablosay1;*/

            }
            if (dateTimePickerDelivery.Checked == true || dateTimePickerDelivery2.Checked==true)
             {
                dateTimePickerDelivery.Format = DateTimePickerFormat.Custom;
                dateTimePickerDelivery.CustomFormat = "yyyy - MM-dd";
                dateTimePickerDelivery2.Format = DateTimePickerFormat.Custom;
                dateTimePickerDelivery2.CustomFormat = "yyyy -MM -dd";

                MessageBox.Show("dfsdff");
                MessageBox.Show(dateTimePickerDelivery2.Text);
                kmt.CommandText = kmt.CommandText + "  AND ([delivery_time] >= @tarih3) ";// and  ([delivery_time] < @tarih4)";
                
                //SqlCommand kmt1 = new SqlCommand("SELECT * FROM process WHERE delivery_time >= @tarih1 and delivery_time < @tarih2", con);
               kmt.Parameters.AddWithValue("@tarih3", SqlDbType.DateTime).Value=dateTimePickerDelivery.Value.Date  ;

                kmt.Parameters.AddWithValue("@tarih4", SqlDbType.DateTime).Value=dateTimePickerDelivery2.Value.Date;
               
                
                
                //kmt.Parameters.AddWithValue("@tarih4", dateTimePickerDelivery2.Value.Date) ;
                /*con.Open();
                 SqlDataAdapter da1 = new SqlDataAdapter(kmt1);
                 DataTable tablosay1 = new DataTable();
                 tablosay1.Clear();
                 da1.Fill(tablosay1);
                 dataGridViewProcessList.DataSource = tablosay1;
                 con.Close();*/
            }
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter(kmt.CommandText, con);
            DataTable dt = new DataTable();
            dt.Clear();

           da.Fill(dt);
            dataGridViewProcessList.DataSource = dt;
            con.Close();

            if (checkBox1.Checked)
            {
                con.Open();
                //SqlCommand kmt = new SqlCommand("Select * from process where delivery_time =' ' "  , con);
                //SqlDataAdapter da = new SqlDataAdapter(kmt);
                //DataTable dt = new DataTable();
                //da.Fill(dt);
                //dataGridViewProcessList.DataSource = dt;
                //con.Close();
            }
        
    
        }
    
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProcessForm prcsfrm = new ProcessForm();
          
            prcsfrm.Show();
            prcsfrm.comboBox1.Text = dataGridViewProcessList.CurrentRow.Cells[4].Value.ToString();
            prcsfrm.comboBox2.Text = dataGridViewProcessList.CurrentRow.Cells[6].Value.ToString();
            prcsfrm.borrowedTime.Text = dataGridViewProcessList.CurrentRow.Cells[1].Value.ToString();
            prcsfrm.deliveryTime.Text = dataGridViewProcessList.CurrentRow.Cells[2].Value.ToString();
            prcsfrm.txtNotes.Text = dataGridViewProcessList.CurrentRow.Cells[3].Value.ToString();
            prcsfrm.deliveryTime.Visible = true;
           
        }

        private void dataGridViewProcessList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ProcessForm prcsfrm = new ProcessForm();

            int area = dataGridViewProcessList.SelectedCells[0].RowIndex;

          
        }

        private void textBoxMember_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
