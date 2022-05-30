using System;
using System.Data;
using System.Data.SqlClient;
namespace btlweb.cms.Admin.Dichvu.qlDichVu
{
    public partial class edit_dichvu : System.Web.UI.UserControl
    {
        String constr = @"Data Source=.;Initial Catalog=hotelLuxury;Integrated Security=True";
        protected void Page_Load(object sender, EventArgs e)
        {
            LoadddlPhong();
            LoadDetailDichVu();
        }
        private void LoadddlPhong()
        {
            using (SqlConnection sCnn = new SqlConnection(constr))
            {
                sCnn.Open();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandType = CommandType.StoredProcedure;
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
        private void LoadDetailDichVu()
        {
            using (SqlConnection sCnn = new SqlConnection(constr))
            {
                sCnn.Open();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "viewDetailDichVu";
                    cmd.Connection = sCnn;
                    cmd.Parameters.AddWithValue("@maDichVu", Request.QueryString["id"]);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        ddlPhong.SelectedValue = dt.Rows[0]["MaPhong"].ToString();
                        tbTenDichVu.Text = dt.Rows[0]["TenDichVu"].ToString();
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
                    cmd.CommandText = "editDichVu";
                    cmd.Connection = sCnn;
                    cmd.Parameters.AddWithValue("@MaDichVu", Request.QueryString["id"]);
                    cmd.Parameters.Add(new SqlParameter("@MaPhong", ddlPhong.SelectedValue));
                    cmd.Parameters.Add(new SqlParameter("@TenDichVu", tbTenDichVu.Text.ToString()));
                    int kq = cmd.ExecuteNonQuery();
                    if (kq != 0)
                    {
                        Response.Redirect("/Admin.aspx?modul=dichvu&modulphu=qldichvu");

                    }

                }
            }
        }
    }
}