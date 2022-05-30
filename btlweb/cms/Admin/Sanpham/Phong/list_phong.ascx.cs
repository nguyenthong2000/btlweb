using System;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI.WebControls;

namespace btlweb.cms.Admin.Sanpham.Phong
{
    public partial class list_phong : System.Web.UI.UserControl
    {
        String constr = @"Data Source=.;Initial Catalog=hotelLuxury;Integrated Security=True";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadDataPhong();
                LoadddlSapXep();
            }
        }
        public void LoadDataPhong()
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
                    for(int i = 0; i < dt.Rows.Count; i++)                       
                    {
                            rlPhong.Text += @"
                            <tr>
                                <td>"+ dt.Rows[i]["MaPhong"]+ @"</td>
                                <td>"+ dt.Rows[i]["TenPhong"] + @"</td>
                                <td>"+ dt.Rows[i]["TrangThai"] + @"</td>
                                <td>"+ dt.Rows[i]["DonGia"] + @"</td> 
                                <td>"+ dt.Rows[i]["MaLoaiPhong"] + @"</td> 
                                <td>
                                    <a href='#'><i class='fa-solid fa-eye'></i></a>
                                    <a href='/Admin.aspx?modul=sanpham&modulphu=phong&thaotac=chinhsua&id=" + dt.Rows[i]["MaPhong"] + @"'><i class='fa-solid fa-pen-to-square'></i></a>
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
                using(SqlConnection sCnn = new SqlConnection(constr))
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
                        rlPhong.Text = "";
                        for (int i = 0; i < dt.Rows.Count; i++)
                        {
                            rlPhong.Text += @"
                            <tr>
                                <td>" + dt.Rows[i]["MaPhong"] + @"</td>
                                <td>" + dt.Rows[i]["TenPhong"] + @"</td>
                                <td>" + dt.Rows[i]["TrangThai"] + @"</td>
                                <td>" + dt.Rows[i]["DonGia"] + @"</td> 
                                <td>" + dt.Rows[i]["MaLoaiPhong"] + @"</td> 
                                <td>
                                    <a href='#'><i class='fa-solid fa-eye'></i></a>
                                    <a href='/Admin.aspx?modul=sanpham&modulphu=phong&thaotac=chinhsua&id=" + dt.Rows[i]["MaPhong"] + @"'><i class='fa-solid fa-pen-to-square'></i></a>
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
                        cmd.CommandText = "searchPhong";
                        cmd.Connection = sCnn;
                        cmd.Parameters.AddWithValue("@txtSearch", txtSearch.Text);
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        rlPhong.Text = "";
                        for (int i = 0; i < dt.Rows.Count; i++)
                        {
                            rlPhong.Text += @"
                            <tr>
                                <td>" + dt.Rows[i]["MaPhong"] + @"</td>
                                <td>" + dt.Rows[i]["TenPhong"] + @"</td>
                                <td>" + dt.Rows[i]["TrangThai"] + @"</td>
                                <td>" + dt.Rows[i]["DonGia"] + @"</td> 
                                <td>" + dt.Rows[i]["MaLoaiPhong"] + @"</td> 
                                <td>
                                    <a href='#'><i class='fa-solid fa-eye'></i></a>
                                    <a href='/Admin.aspx?modul=sanpham&modulphu=phong&thaotac=chinhsua&id=" + dt.Rows[i]["MaPhong"] + @"'><i class='fa-solid fa-pen-to-square'></i></a>
                                        </td>
                            </tr>
                        ";
                        }
                    }
                }
            }    
        }

        private void LoadddlSapXep()
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
                    ddlSapXep.Items.Add(new ListItem("Không sắp xếp", "0"));
                    dt.Rows.Add(0, "Không sắp xếp");
                    ddlSapXep.Items.Add(new ListItem("Giá cao đến thấp", "1"));
                    dt.Rows.Add(1, "Giá cao đến thấp");
                    ddlSapXep.Items.Add(new ListItem("Giá thấp đến cao", "2"));
                    dt.Rows.Add(2, "Giá thấp đến cao");
                }
            }
        }
        protected void DDLSapxep_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dataTable = new DataTable();
            if (ddlSapXep.SelectedValue.Equals("0"))
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
                        rlPhong.Text = "";
                        for (int i = 0; i < dt.Rows.Count; i++)
                        {
                            rlPhong.Text += @"
                            <tr>
                                <td>" + dt.Rows[i]["MaPhong"] + @"</td>
                                <td>" + dt.Rows[i]["TenPhong"] + @"</td>
                                <td>" + dt.Rows[i]["TrangThai"] + @"</td>
                                <td>" + dt.Rows[i]["DonGia"] + @"</td> 
                                <td>" + dt.Rows[i]["MaLoaiPhong"] + @"</td> 
                                <td>
                                    <a href='#'><i class='fa-solid fa-eye'></i></a>
                                    <a href='/Admin.aspx?modul=sanpham&modulphu=phong&thaotac=chinhsua&id=" + dt.Rows[i]["MaPhong"] + @"'><i class='fa-solid fa-pen-to-square'></i></a>
                                        </td>
                            </tr>
                        ";
                        }
                    }
                }
            }
            else if (ddlSapXep.SelectedValue.Equals("1"))
            {
                using (SqlConnection sCnn = new SqlConnection(constr))
                {
                    sCnn.Open();
                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.CommandText = "sortGiagiam";
                        cmd.Connection = sCnn;
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        rlPhong.Text = "";
                        for (int i = 0; i < dt.Rows.Count; i++)
                        {
                            rlPhong.Text += @"
                            <tr>
                                <td>" + dt.Rows[i]["MaPhong"] + @"</td>
                                <td>" + dt.Rows[i]["TenPhong"] + @"</td>
                                <td>" + dt.Rows[i]["TrangThai"] + @"</td>
                                <td>" + dt.Rows[i]["DonGia"] + @"</td> 
                                <td>" + dt.Rows[i]["MaLoaiPhong"] + @"</td> 
                                <td>
                                    <a href='#'><i class='fa-solid fa-eye'></i></a>
                                    <a href='/Admin.aspx?modul=sanpham&modulphu=phong&thaotac=chinhsua&id=" + dt.Rows[i]["MaPhong"] + @"'><i class='fa-solid fa-pen-to-square'></i></a>
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
                        cmd.CommandText = "sortGiatang";
                        cmd.Connection = sCnn;
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        rlPhong.Text = "";
                        for (int i = 0; i < dt.Rows.Count; i++)
                        {
                            rlPhong.Text += @"
                            <tr>
                                <td>" + dt.Rows[i]["MaPhong"] + @"</td>
                                <td>" + dt.Rows[i]["TenPhong"] + @"</td>
                                <td>" + dt.Rows[i]["TrangThai"] + @"</td>
                                <td>" + dt.Rows[i]["DonGia"] + @"</td> 
                                <td>" + dt.Rows[i]["MaLoaiPhong"] + @"</td> 
                                <td>
                                    <a href='#'><i class='fa-solid fa-eye'></i></a>
                                    <a href='/Admin.aspx?modul=sanpham&modulphu=phong&thaotac=chinhsua&id=" + dt.Rows[i]["MaPhong"] + @"'><i class='fa-solid fa-pen-to-square'></i></a>
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