using System;
using System.Data;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace Student_Management_System__SMS_
{
	public partial class WebForm2 : System.Web.UI.Page
	{
        String connectionString = @"Data Source=DESKTOP-4HQC2B1\SQLSERVER;Initial Catalog=SMS;Integrated Security=True";
        protected void Page_Load(object sender, EventArgs e)
		{
            if (Session["admin_ID"] == null)
            {
                Response.Redirect("~/Login/adminLogin");
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();
                SqlCommand cmd = sqlConnection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "INSERT INTO Students VALUES('" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "','" + TextBox4.Text + "','" + TextBox5.Text + "')";
                cmd.ExecuteNonQuery();
                sqlConnection.Close();
                string message = "Successfully Inserted ...";
                MessageBox.Show(message);
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();
                SqlCommand cmd = sqlConnection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "INSERT INTO Couse_Material VALUES('" + TextBox6.Text + "','" + TextBox7.Text + "','" + TextBox8.Text + "','" + TextBox9.Text + "')";
                cmd.ExecuteNonQuery();
                sqlConnection.Close();
                string message = "Successfully Inserted ...";
                MessageBox.Show(message);
            }
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            Response.Redirect("~/Login/Login");
        }
    }
}