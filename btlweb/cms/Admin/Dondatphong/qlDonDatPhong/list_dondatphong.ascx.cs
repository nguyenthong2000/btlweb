using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace btlweb.cms.Admin.Dondatphong.qlDonDatPhong
{
    public partial class list_dondatphong : System.Web.UI.UserControl
    {
        String constr = @"Data Source=.;Initial Catalog=hotelLuxury;Integrated Security=True";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadDataDDPhong();
            }
        }
        public void LoadDataDDPhong()
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
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        rlDDPhong.Text += @"
                            <tr>
                                <td>" + dt.Rows[i]["MaDonDat"] + @"</td>
                                <td>" + dt.Rows[i]["SoLuongNguoi"] + @"</td>
                                <td>" + dt.Rows[i]["NgayBatDau"] + @"</td>
                                <td>" + dt.Rows[i]["NgayKetThuc"] + @"</td> 
                                <td>" + dt.Rows[i]["TrangThai"] + @"</td> 
                                <td>" + dt.Rows[i]["MaKhachHang"] + @"</td> 
                                <td>
                                    <a href='#'><i class='fa-solid fa-eye'></i></a>
                                    <a href='/Admin.aspx?modul=dondatphong&modulphu=qldondatphong&thaotac=chinhsua&id=" + dt.Rows[i]["MaDonDat"] + @"'><i class='fa-solid fa-pen-to-square'></i></a>
               
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
                        cmd.CommandText = "viewDsDDPhong";
                        cmd.Connection = sCnn;
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        rlDDPhong.Text = "";
                        for (int i = 0; i < dt.Rows.Count; i++)
                        {
                            rlDDPhong.Text += @"
                            <tr>
                                <td>" + dt.Rows[i]["MaDonDat"] + @"</td>
                                <td>" + dt.Rows[i]["SoLuongNguoi"] + @"</td>
                                <td>" + dt.Rows[i]["NgayBatDau"] + @"</td>
                                <td>" + dt.Rows[i]["NgayKetThuc"] + @"</td> 
                                <td>" + dt.Rows[i]["TrangThai"] + @"</td> 
                                <td>" + dt.Rows[i]["MaKhachHang"] + @"</td> 
                                <td>
                                    <a href='#'><i class='fa-solid fa-eye'></i></a>
                                    <a href='/Admin.aspx?modul=dondatphong&modulphu=qldondatphong&thaotac=chinhsua&id=" + dt.Rows[i]["MaDonDat"] + @"'><i class='fa-solid fa-pen-to-square'></i></a>
               
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
                        cmd.CommandText = "searchDDPhong";
                        cmd.Connection = sCnn;
                        cmd.Parameters.AddWithValue("@txtSearch", txtSearch.Text);
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        rlDDPhong.Text = "";
                        for (int i = 0; i < dt.Rows.Count; i++)
                        {
                            rlDDPhong.Text += @"
                            <tr>
                                <td>" + dt.Rows[i]["MaDonDat"] + @"</td>
                                <td>" + dt.Rows[i]["SoLuongNguoi"] + @"</td>
                                <td>" + dt.Rows[i]["NgayBatDau"] + @"</td>
                                <td>" + dt.Rows[i]["NgayKetThuc"] + @"</td> 
                                <td>" + dt.Rows[i]["TrangThai"] + @"</td> 
                                <td>" + dt.Rows[i]["MaKhachHang"] + @"</td> 
                                <td>
                                    <a href='#'><i class='fa-solid fa-eye'></i></a>
                                    <a href='/Admin.aspx?modul=dondatphong&modulphu=qldondatphong&thaotac=chinhsua&id=" + dt.Rows[i]["MaDonDat"] + @"'><i class='fa-solid fa-pen-to-square'></i></a>
               
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