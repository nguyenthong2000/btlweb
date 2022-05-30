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
    public partial class RoomDetails : System.Web.UI.Page
    {
        String connectionSTR = @"Data Source=.;Initial Catalog=hotelLuxury;Integrated Security=True";
        protected void Page_Load(object sender, EventArgs e)
        {
            string id = Request.QueryString["ID"];
            if (String.IsNullOrEmpty(id))
            {

            }
            else
            {
                using (SqlConnection connection = new SqlConnection(connectionSTR))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand())
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.CommandText = "viewRoomDetails";
                        command.Connection = connection;
                        command.Parameters.Add(new SqlParameter("@maLoaiPhong", int.Parse(id)));
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
    }
}