using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI.WebControls;

namespace btlweb.cms.Admin.Sanpham.Phong
{
    public partial class create_phong : System.Web.UI.UserControl
    {
        String constr = @"Data Source=.;Initial Catalog=hotelLuxury;Integrated Security=True";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadddlLoaiPhong(); 
            }

        }
        private void LoadddlLoaiPhong()
        {
            using (SqlConnection sCnn = new SqlConnection(constr))
            {
                sCnn.Open();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandType = CommandType.StoredProcedure;
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

        protected void btnThem_Click(object sender, EventArgs e)
        {
             using (SqlConnection sCnn = new SqlConnection(constr))
             {
                    sCnn.Open();
                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.CommandText = "insertPhong";
                        cmd.Connection = sCnn;
                        cmd.Parameters.Add(new SqlParameter("@MaLoaiPhong", ddlLoaiPhong.SelectedValue));
                        cmd.Parameters.Add(new SqlParameter("@TenPhong", tbTenPhong.Text.ToString()));
                        cmd.Parameters.Add(new SqlParameter("@DonGia", int.Parse(tbDonGia.Text.ToString())));
                        cmd.Parameters.Add(new SqlParameter("@TrangThai", 0));
                        int kq = cmd.ExecuteNonQuery();
                        if (kq != 0)
                        {
                            Response.Write("<script>alert('Thanh cong')</script>");
                            Response.Redirect("/Admin.aspx?modul=sanpham&modulphu=phong");
                        }
                    }
             }    
        }
        public void ResetControl()
        {
            tbTenPhong.Text = "";
            tbDonGia.Text = "";
        }
        protected void btnHuy_Click(object sender, EventArgs e)
        {
            ResetControl();
        }
    }
}