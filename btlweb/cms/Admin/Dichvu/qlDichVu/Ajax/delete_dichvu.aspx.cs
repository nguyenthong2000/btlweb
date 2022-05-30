using System;
using System.Data;
using System.Data.SqlClient;

namespace btlweb.cms.Admin.Dichvu.qlDichVu.Ajax
{
    public partial class delete_dichvu : System.Web.UI.Page
    {
        String constr = @"Data Source=LEE\SQLEXPRESS;Initial Catalog=hotelLux;Integrated Security=True";

        private String thaotac = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.Params["thaotac"] != null)
            {
                thaotac = Request.Params["thaotac"];
            }
            switch (thaotac)
            {
                case "XoaDichVu":
                    XoaDichVu();
                    break;

            }
        }
        private void XoaDichVu()
        {
            string MaDichVu = "";
            if (Request.Params["MaDichVu"] != null)
            {
                MaDichVu = Request.Params["MaDichVu"];
                using (SqlConnection sCnn = new SqlConnection(constr))
                {
                    sCnn.Open();
                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.CommandText = "deleteDichVu";
                        cmd.Connection = sCnn;
                        cmd.Parameters.AddWithValue("@madichvu", MaDichVu);
                        int kq = cmd.ExecuteNonQuery();
                    }
                }
            }
            Response.Write(1);
        }

    }
}