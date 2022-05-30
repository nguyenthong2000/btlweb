using System;
using System.Data;
using System.Data.SqlClient;

namespace btlweb.cms.Admin.Sanpham.Loaiphong
{
    public partial class edit_phong : System.Web.UI.UserControl
    {
        String constr = @"Data Source=.;Initial Catalog=hotelLuxury;Integrated Security=True";
        protected void Page_Load(object sender, EventArgs e)
        {
            LoadddlLoaiPhong();
            LoadDetailPhong();
            
        }
        private void LoadddlLoaiPhong()
        {
            using (SqlConnection sCnn = new SqlConnection(constr))
            {
                sCnn.Open();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.CommandText = "viewLP";
                    cmd.Connection = sCnn;
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    ddlLoaiPhong.DataSource = dt;
                    ddlLoaiPhong.DataTextField = "tenLoaiPhong";
                    ddlLoaiPhong.DataValueField = "MaLoaiphong";
                    ddlLoaiPhong.DataBind();
                }
            }
        }
        private void LoadDetailPhong()
        {
            using (SqlConnection sCnn = new SqlConnection(constr))
            {
                sCnn.Open();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "viewDetailPhong";
                    cmd.Connection = sCnn;
                    cmd.Parameters.AddWithValue("@maPhong", Request.QueryString["id"]);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    
                    if (dt.Rows.Count > 0)
                    {
                        ddlLoaiPhong.SelectedValue = dt.Rows[0]["MaLoaiPhong"].ToString();
                        tbTenPhong.Text = dt.Rows[0]["TenPhong"].ToString();
                        tbDonGia.Text = dt.Rows[0]["DonGia"].ToString();  
                    }
                    

                }
            }
        }

        protected void btnChinhsua_Click(object sender, EventArgs e)
        {
            using (SqlConnection sCnn = new SqlConnection(constr))
            {
                sCnn.Open();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "editPhong";
                    cmd.Connection = sCnn;
                    cmd.Parameters.AddWithValue("@maPhong", Request.QueryString["id"]);
                    cmd.Parameters.Add(new SqlParameter("@MaLoaiPhong", ddlLoaiPhong.SelectedValue));
                    cmd.Parameters.Add(new SqlParameter("@TenPhong", tbTenPhong.Text.ToString()));
                    cmd.Parameters.Add(new SqlParameter("@DonGia", int.Parse(tbDonGia.Text.ToString())));
                    int kq = cmd.ExecuteNonQuery();
                    if (kq != 0)
                    {
                        Response.Redirect("/Admin.aspx?modul=sanpham&modulphu=phong");
                        
                    }

                }
            }
        }
    }
}