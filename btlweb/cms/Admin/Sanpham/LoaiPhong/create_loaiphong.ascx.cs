using System;
using System.Data;
using System.Data.SqlClient;

namespace btlweb.cms.Admin.Sanpham.LoaiPhong
{

    public partial class create_loaiphong : System.Web.UI.UserControl
    {
        String constr = @"Data Source=.;Initial Catalog=hotelLuxury;Integrated Security=True";
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnThem_Click(object sender, EventArgs e)
        {
            using (SqlConnection sCnn = new SqlConnection(constr))
            {
                sCnn.Open();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "insertLoaiPhong";
                    cmd.Connection = sCnn;
                    cmd.Parameters.Add(new SqlParameter("@TenLoaiPhong", TbTenLoaiPhong.Text.ToString()));
                    cmd.Parameters.Add(new SqlParameter("@MoTaLoaiPhong", tbMoTaLoaiPhong.Text.ToString()));
                    int kq = cmd.ExecuteNonQuery();
                    if (kq != 0)
                    {
                        Response.Write("<script>alert('Thanh cong')</script>");
                        Response.Redirect("/Admin.aspx?modul=sanpham&modulphu=loaiphong");
                    }

                }
            }
        }
    }
}
