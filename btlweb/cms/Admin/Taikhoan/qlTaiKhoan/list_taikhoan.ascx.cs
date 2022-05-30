using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace btlweb.cms.Admin.Taikhoan.qlTaiKhoan
{
    public partial class list_taikhoan : System.Web.UI.UserControl
    {
        String constr = @"Data Source=.;Initial Catalog=hotelLuxury;Integrated Security=True";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadDataTaiKhoan();
            }
        }
        public void LoadDataTaiKhoan()
        {
            using (SqlConnection sCnn = new SqlConnection(constr))
            {
                sCnn.Open();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "viewDsTK";
                    cmd.Connection = sCnn;
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        rlTaiKhoan.Text += @"
                            <tr>
                                <td>" + dt.Rows[i]["MaTaiKhoan"] + @"</td>
                                <td>" + dt.Rows[i]["Email"] + @"</td>
                                <td>" + dt.Rows[i]["MatKhau"] + @"</td>
                                <td>" + dt.Rows[i]["TrangThai"] + @"</td> 
                                <td>" + dt.Rows[i]["MaLoaiTaiKhoan"] + @"</td> 
                                <td>
                                    <a href='#'><i class='fa-solid fa-eye'></i></a>
                                    <a href='/Admin.aspx?modul=TaiKhoan&modulphu=qlTaiKhoan&thaotac=chinhsua&id=" + dt.Rows[i]["MaTaiKhoan"] + @"'><i class='fa-solid fa-pen-to-square'></i></a>
                                   <a href='javascript:XoaTaiKhoan(" + dt.Rows[i]["MaTaiKhoan"] + @")'><i class='fa-solid fa-circle-minus'></i></a>
                                </td>
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
                        cmd.CommandText = "viewDsTK";
                        cmd.Connection = sCnn;
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        rlTaiKhoan.Text = "";
                        for (int i = 0; i < dt.Rows.Count; i++)
                        {
                            rlTaiKhoan.Text += @"
                            <tr>
                                <td>" + dt.Rows[i]["MaTaiKhoan"] + @"</td>
                                <td>" + dt.Rows[i]["Email"] + @"</td>
                                <td>" + dt.Rows[i]["MatKhau"] + @"</td>
                                <td>" + dt.Rows[i]["TrangThai"] + @"</td> 
                                <td>" + dt.Rows[i]["MaLoaiTaiKhoan"] + @"</td> 
                                <td>
                                    <a href='#'><i class='fa-solid fa-eye'></i></a>
                                    <a href='/Admin.aspx?modul=TaiKhoan&modulphu=qlTaiKhoan&thaotac=chinhsua&id=" + dt.Rows[i]["MaTaiKhoan"] + @"'><i class='fa-solid fa-pen-to-square'></i></a>
                                   <a href='javascript:XoaTaiKhoan(" + dt.Rows[i]["MaTaiKhoan"] + @")'><i class='fa-solid fa-circle-minus'></i></a>
                                </td>
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
                        cmd.CommandText = "searchTK";
                        cmd.Connection = sCnn;
                        cmd.Parameters.AddWithValue("@txtSearch", txtSearch.Text);
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        rlTaiKhoan.Text = "";
                        for (int i = 0; i < dt.Rows.Count; i++)
                        {
                            rlTaiKhoan.Text += @"
                            <tr>
                                <td>" + dt.Rows[i]["MaTaiKhoan"] + @"</td>
                                <td>" + dt.Rows[i]["Email"] + @"</td>
                                <td>" + dt.Rows[i]["MatKhau"] + @"</td>
                                <td>" + dt.Rows[i]["TrangThai"] + @"</td> 
                                <td>" + dt.Rows[i]["MaLoaiTaiKhoan"] + @"</td> 
                                <td>
                                    <a href='#'><i class='fa-solid fa-eye'></i></a>
                                    <a href='/Admin.aspx?modul=TaiKhoan&modulphu=qlTaiKhoan&thaotac=chinhsua&id=" + dt.Rows[i]["MaTaiKhoan"] + @"'><i class='fa-solid fa-pen-to-square'></i></a>
                                   <a href='javascript:XoaTaiKhoan(" + dt.Rows[i]["MaTaiKhoan"] + @")'><i class='fa-solid fa-circle-minus'></i></a>
                                </td>
                            </tr>
                        ";
                        }
                    }
                }
            }
        }
    }
}