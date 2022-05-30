 using System;
using System.Data;
using System.Data.SqlClient;

namespace btlweb.cms.Admin.Dichvu.qlDichVu
{
    public partial class list_dichvu : System.Web.UI.UserControl
    {
        String constr = @"Data Source=.;Initial Catalog=hotelLuxury;Integrated Security=True";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadDataDichVu();
            }
        }
        public void LoadDataDichVu()
        {
            using (SqlConnection sCnn = new SqlConnection(constr))
            {
                sCnn.Open();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "viewDsDV";
                    cmd.Connection = sCnn;
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        rlDichVu.Text += @"
                            <tr  id = madichvu_" + dt.Rows[i]["MaDichVu"] + @">
                                <td>" + dt.Rows[i]["MaDichVu"] + @"</td>
                                <td>" + dt.Rows[i]["TenDichVu"] + @"</td>
                                <td>" + dt.Rows[i]["MaPhong"] + @"</td> 
                                <td>
                                    <a href='#'><i class='fa-solid fa-eye'></i></a>
                                    <a href='/Admin.aspx?modul=dichvu&modulphu=qldichvu&thaotac=chinhsua&id=" + dt.Rows[i]["MaDichVu"] + @"'><i class='fa-solid fa-pen-to-square'></i></a>
                                   <a href='javascript:XoaDichVu(" + dt.Rows[i]["MaDichVu"] + @")'><i class='fa-solid fa-circle-minus'></i></a>
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
                        cmd.CommandText = "viewDsDV";
                        cmd.Connection = sCnn;
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        rlDichVu.Text = "";
                        for (int i = 0; i < dt.Rows.Count; i++)
                        {
                            rlDichVu.Text += @"
                            <tr  id = madichvu_" + dt.Rows[i]["MaDichVu"] + @">
                                <td>" + dt.Rows[i]["MaDichVu"] + @"</td>
                                <td>" + dt.Rows[i]["TenDichVu"] + @"</td>
                                <td>" + dt.Rows[i]["MaPhong"] + @"</td> 
                                <td>
                                    <a href='#'><i class='fa-solid fa-eye'></i></a>
                                    <a href='/Admin.aspx?modul=dichvu&modulphu=qldichvu&thaotac=chinhsua&id=" + dt.Rows[i]["MaDichVu"] + @"'><i class='fa-solid fa-pen-to-square'></i></a>
                                   <a href='javascript:XoaDichVu(" + dt.Rows[i]["MaDichVu"] + @")'><i class='fa-solid fa-circle-minus'></i></a>
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
                        cmd.CommandText = "searchDV";
                        cmd.Connection = sCnn;
                        cmd.Parameters.AddWithValue("@txtSearch", txtSearch.Text);
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        rlDichVu.Text = "";
                        for (int i = 0; i < dt.Rows.Count; i++)
                        {
                            rlDichVu.Text += @"
                            <tr  id = madichvu_" + dt.Rows[i]["MaDichVu"] + @">
                                <td>" + dt.Rows[i]["MaDichVu"] + @"</td>
                                <td>" + dt.Rows[i]["TenDichVu"] + @"</td>
                                <td>" + dt.Rows[i]["MaPhong"] + @"</td> 
                                <td>
                                    <a href='#'><i class='fa-solid fa-eye'></i></a>
                                    <a href='/Admin.aspx?modul=dichvu&modulphu=qldichvu&thaotac=chinhsua&id=" + dt.Rows[i]["MaDichVu"] + @"'><i class='fa-solid fa-pen-to-square'></i></a>
                                   <a href='javascript:XoaDichVu(" + dt.Rows[i]["MaDichVu"] + @")'><i class='fa-solid fa-circle-minus'></i></a>
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