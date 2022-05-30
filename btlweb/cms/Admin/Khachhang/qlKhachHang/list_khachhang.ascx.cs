using System;
using System.Data;
using System.Data.SqlClient;

namespace btlweb.cms.Admin.Khachhang.qlKhachHang
{
    public partial class list_khachhang : System.Web.UI.UserControl
    {
        String constr = @"Data Source=.;Initial Catalog=hotelLuxury;Integrated Security=True";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadDataKhachHang();
            }
        }
        public void LoadDataKhachHang()
        {
            using (SqlConnection sCnn = new SqlConnection(constr))
            {
                sCnn.Open();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "viewDsKH";
                    cmd.Connection = sCnn;
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        rlKhachHang.Text += @"
                            <tr>
                                <td>" + dt.Rows[i]["MaKhachHang"] + @"</td>
                                <td>" + dt.Rows[i]["TenKhachHang"] + @"</td>
                                
                                <td>" + dt.Rows[i]["SoDienThoai"] + @"</td>
                                <td>" + dt.Rows[i]["CMND"] + @"</td> 
                                <td>" + dt.Rows[i]["Email"] + @"</td> 
                                <td>" + dt.Rows[i]["MaTaiKhoan"] + @"</td> 
                            </tr>
                        ";
                    }

                }
            }
        }

        protected void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text == "")
            {
                using (SqlConnection sCnn = new SqlConnection(constr))
                {
                    sCnn.Open();
                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.CommandText = "viewDsKH";
                        cmd.Connection = sCnn;
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        rlKhachHang.Text = "";
                        for (int i = 0; i < dt.Rows.Count; i++)
                        {
                            rlKhachHang.Text += @"
                            <tr>
                                <td>" + dt.Rows[i]["MaKhachHang"] + @"</td>
                                <td>" + dt.Rows[i]["TenKhachHang"] + @"</td>
                                
                                <td>" + dt.Rows[i]["SoDienThoai"] + @"</td>
                                <td>" + dt.Rows[i]["CMND"] + @"</td> 
                                <td>" + dt.Rows[i]["Email"] + @"</td> 
                                <td>" + dt.Rows[i]["MaTaiKhoan"] + @"</td> 
                            </tr>
                        ";
                        }

                    }
                }
            }    
            else
            {
                using (SqlConnection sCnn = new SqlConnection(constr))
                {
                    sCnn.Open();
                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.CommandText = "searchKH";
                        cmd.Connection = sCnn;
                        cmd.Parameters.AddWithValue("@txtSearch", txtSearch.Text);
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        rlKhachHang.Text = "";
                        for (int i = 0; i < dt.Rows.Count; i++)
                        {
                            rlKhachHang.Text += @"
                            <tr>
                                <td>" + dt.Rows[i]["MaKhachHang"] + @"</td>
                                <td>" + dt.Rows[i]["TenKhachHang"] + @"</td>
                                
                                <td>" + dt.Rows[i]["SoDienThoai"] + @"</td>
                                <td>" + dt.Rows[i]["CMND"] + @"</td> 
                                <td>" + dt.Rows[i]["Email"] + @"</td> 
                                <td>" + dt.Rows[i]["MaTaiKhoan"] + @"</td> 
                            </tr>
                        ";
                        }
                    }
                }
            }    
        }
    }
}
