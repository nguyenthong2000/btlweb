using System;
using System.Data;
using System.Data.SqlClient;

namespace btlweb.cms.Admin.Sanpham.Anhphong.Ajax
{
    public partial class xoa_anhphong : System.Web.UI.Page
    {
        String constr = @"Data Source=.;Initial Catalog=hotelLuxury;Integrated Security=True";
        private String thaotac = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            //cần code kiểm tra đăng nhập ở đây mới thực hiện thao tác ở dưới
            if (Request.Params["thaotac"] != null)
            {
                thaotac = Request.Params["thaotac"];
            }
            switch (thaotac)
            {
                case "XoaAnhPhong":
                    XoaAnhPhong();
                    break;

            }
        }
        private void XoaAnhPhong()
        {
            string MaAnhPhong = "";
            if (Request.Params["MaAnh"] != null)
            {
                MaAnhPhong = Request.Params["MaAnh"];
                using (SqlConnection sCnn = new SqlConnection(constr))
                {
                    sCnn.Open();
                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.CommandText = "deleteAnhPhong";
                        cmd.Connection = sCnn;
                        cmd.Parameters.AddWithValue("@maanh", MaAnhPhong);  
                        int kq = cmd.ExecuteNonQuery();

                    }
                }
            }
            Response.Write(1);
        }

    }
}