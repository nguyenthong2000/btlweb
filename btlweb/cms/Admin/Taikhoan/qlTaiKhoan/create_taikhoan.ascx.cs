using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace btlweb.cms.Admin.Taikhoan
{
    public partial class create_taikhoan : System.Web.UI.UserControl
    {
        String constr = @"Data Source=.;Initial Catalog=hotelLuxury;Integrated Security=True";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadddlLoaiTK();
            }

        }
        private void LoadddlLoaiTK()
        {
            using (SqlConnection sCnn = new SqlConnection(constr))
            {
                sCnn.Open();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.CommandText = "viewLTK";
                    cmd.Connection = sCnn;
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    ddlLoaiTK.DataSource = dt;
                    ddlLoaiTK.DataTextField = "TenLoai";
                    ddlLoaiTK.DataValueField = "MaLoaiTaiKhoan";
                    ddlLoaiTK.DataBind();
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
                    cmd.CommandText = "insertTK";
                    cmd.Connection = sCnn;
                    cmd.Parameters.Add(new SqlParameter("@MaLoaiTK", ddlLoaiTK.SelectedValue));
                    cmd.Parameters.Add(new SqlParameter("@Email", tbEmail.Text.ToString()));
                    cmd.Parameters.Add(new SqlParameter("@MatKhau", tbMK.Text.ToString()));
                    cmd.Parameters.Add(new SqlParameter("@TrangThai", 1));
                    int kq = cmd.ExecuteNonQuery();
                    if (kq != 0)
                    {
                        Response.Write("<script>alert('Thanh cong')</script>");
                        Response.Redirect("/Admin.aspx?modul=taikhoan&modulphu=qltaikhoan");
                    }

                }
            }
        }
        public void ResetControl()
        {
            tbEmail.Text = "";
            tbMK.Text = "";
        }
        protected void btnHuy_Click(object sender, EventArgs e)
        {
            ResetControl();
        }
    }
}