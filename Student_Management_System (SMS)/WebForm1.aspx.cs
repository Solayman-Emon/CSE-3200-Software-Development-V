using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace Student_Management_System__SMS_
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        String connectionString = @"Data Source=DESKTOP-4HQC2B1\SQLSERVER;Initial Catalog=SMS;Integrated Security=True";
        protected void Page_Load(object sender, EventArgs e)
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT * from Students", sqlConnection);
                DataTable dt = new DataTable();
                sqlDataAdapter.Fill(dt);
                GridView3.DataSource = dt;
                GridView3.DataBind();

            }
        }
    }
}