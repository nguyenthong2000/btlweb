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
    public partial class Rooms : System.Web.UI.Page
    {

        String connectionSTR = @"Data Source=.;Initial Catalog=hotelLuxury;Integrated Security=True";
        
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                using (SqlConnection connection = new SqlConnection(connectionSTR))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand())
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.CommandText = "viewAllRooms";
                        command.Connection = connection;
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable data = new DataTable();
                        adapter.Fill(data);
                        ListRooms.DataSource = data;
                        ListRooms.DataBind();
                        command.Dispose();
                    }
                    connection.Close();

                }

            }

        }

        protected void ListRooms_SelectedIndexChanged(object sender, RepeaterCommandEventArgs e)
        {
            Label ldID = (Label)e.Item.FindControl("id");
            Response.Redirect(@"RoomDetails.aspx?ID=" + ldID.Text);




        }
    }
}