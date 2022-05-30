using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace btlweb.Customer
{
    public partial class Login : System.Web.UI.Page
    {
        String connectionSTR = @"Data Source=.;Initial Catalog=hotelLuxury;Integrated Security=True";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["User"] != null)
            {
                Session["User"] = null;

                Response.Redirect("Home.aspx");

            }

        }

        protected void loginbtn_Click(object sender, EventArgs e)
        {
            login(tb_username.Text.Trim(), tb_password.Text.Trim());
        }

        public void login(string username, string password)
        {
            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand())
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "login";
                    command.Connection = connection;
                    command.Parameters.Add(new SqlParameter("@email", username));
                    command.Parameters.Add(new SqlParameter("@password", password));
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable data = new DataTable();
                    adapter.Fill(data);

                    if (data.Rows.Count > 0)
                    {
                        Session["User"] = data.Rows[0]["Email"];

                        Response.Redirect("Home.aspx");
                    }
                    else
                    {
                        Response.Write("<script language=javascript>alert('Đăng nhập thất bại');</script>");
                    }

                    command.Dispose();
                }
                connection.Close();

            }
        }
    }
}