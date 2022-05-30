using System;
using System.Data;
using System.Data.SqlClient;

namespace btlweb.cms.Admin.Dichvu.qlDichVu
{
    public partial class create_dichvu : System.Web.UI.UserControl
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
        protected void btnThem_Click(object sender, EventArgs e)
        {
            using (SqlConnection sCnn = new SqlConnection(constr))
            {
                sCnn.Open();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "insertDichVu";
                    cmd.Connection = sCnn;
                    cmd.Parameters.Add(new SqlParameter("@MaPhong", ddlPhong.SelectedValue));
                    cmd.Parameters.Add(new SqlParameter("@TenDichVu", tbTenDichVu.Text.ToString()));
                    int kq = cmd.ExecuteNonQuery();
                    if (kq != 0)
                    {
                        Response.Write("<script>alert('Thanh cong')</script>");
                        Response.Redirect("/Admin.aspx?modul=dichvu&modulphu=qldichvu");
                    }

                }
            }
        }
    }
}
