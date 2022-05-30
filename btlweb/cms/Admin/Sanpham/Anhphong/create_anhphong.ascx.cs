using System;
using System.Data;
using System.Data.SqlClient;

namespace btlweb.cms.Admin.Sanpham.Anhphong
{
    public partial class create_anhphong : System.Web.UI.UserControl
    {
        String constr = @"Data Source=.;Initial Catalog=hotelLuxury;Integrated Security=True";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadddlPhong();
            }
        }
        private void LoadddlPhong()
        {
            using (SqlConnection sCnn = new SqlConnection(constr))
            {
                sCnn.Open();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.CommandText = "viewDsPhong";
                    cmd.Connection = sCnn;
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    ddlPhong.DataSource = dt;
                    ddlPhong.DataTextField = "tenPhong";
                    ddlPhong.DataValueField = "MaPhong";
                    ddlPhong.DataBind();
                }
            }
        }

        protected void btnThem_Click(object sender, EventArgs e)
        {
            if (fuAnhPhong.FileContent != null)
            {
                if (fuAnhPhong.FileName.EndsWith(".jpeg") || fuAnhPhong.FileName.EndsWith(".jpg") || fuAnhPhong.FileName.EndsWith(".png") || fuAnhPhong.FileName.EndsWith(".gif"))
                {
                    fuAnhPhong.SaveAs(Server.MapPath("Picture/Phong/") + fuAnhPhong.FileName);
                }
            }
            using (SqlConnection sCnn = new SqlConnection(constr))
            {
                sCnn.Open();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "insertAnhPhong";
                    cmd.Connection = sCnn;
                    cmd.Parameters.Add(new SqlParameter("@MaPhong", ddlPhong.SelectedValue));
                    cmd.Parameters.Add(new SqlParameter("@Anh", fuAnhPhong.FileName));
                    int kq = cmd.ExecuteNonQuery();
                    if (kq != 0)
                    {
                        Response.Write("<script>alert('Thanh cong')</script>");
                        Response.Redirect("/Admin.aspx?modul=sanpham&modulphu=aphong");
                    }

                }
            }
        }
    }
}