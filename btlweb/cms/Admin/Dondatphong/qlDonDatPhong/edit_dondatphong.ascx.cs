using System;
using System.Data;
using System.Data.SqlClient;

namespace btlweb.cms.Admin.Dondatphong.qlDonDatPhong
{
    public partial class edit_dondatphong : System.Web.UI.UserControl
    {
        String constr = @"Data Source=.;Initial Catalog=hotelLuxury;Integrated Security=True";
        protected void Page_Load(object sender, EventArgs e)
        {
            LoadddlMaDonDat();
            LoadddlTrangThai();

        }
        private void LoadddlMaDonDat()
        {
            using (SqlConnection sCnn = new SqlConnection(constr))
            {
                sCnn.Open();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "viewDsDDPhong";
                    cmd.Connection = sCnn;
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    ddlMaDonDat.DataSource = dt;
                    ddlMaDonDat.DataTextField = "MaDonDat";
                    ddlMaDonDat.DataValueField = "MaDonDat";
                    ddlMaDonDat.DataBind();
                }
            }
        }
        private void LoadddlTrangThai()
        {
            using (SqlConnection sCnn = new SqlConnection(constr))
            {
                sCnn.Open();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "viewDsDDPhong";
                    cmd.Connection = sCnn;
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    ddlTrangThai.DataSource = dt;
                    ddlTrangThai.DataTextField = "TrangThai";
                    ddlTrangThai.DataValueField = "MaDonDat";
                    ddlTrangThai.DataBind();
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
                    cmd.CommandText = "editDDPhong";
                    cmd.Connection = sCnn;
                    cmd.Parameters.AddWithValue("@maDDPhong", Request.QueryString["id"]);
                    cmd.Parameters.Add(new SqlParameter("@maDDPhong", ddlMaDonDat.SelectedValue));
                   
                    int kq = cmd.ExecuteNonQuery();
                    if (kq != 0)
                    {
                        Response.Redirect("/Admin.aspx?modul=dondatphong&modulphu=qldondatphong");

                    }
                }
            }
        }
    }
}