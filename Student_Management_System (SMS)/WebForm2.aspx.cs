using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Student_Management_System__SMS_
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        String connectionString = @"Data Source=DESKTOP-4HQC2B1\SQLSERVER;Initial Catalog=SMS;Integrated Security=True";
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();
                SqlCommand cmd = sqlConnection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "INSERT INTO Students VALUES('"+TextBox1.Text+"','" + TextBox2.Text + "','" + TextBox3.Text + "','" + TextBox4.Text + "','" + TextBox5.Text + "')";
                cmd.ExecuteNonQuery();
                sqlConnection.Close();
                string message = "Successfully Inserted ...";
                MessageBox.Show(message);

            }
        }
    }
}