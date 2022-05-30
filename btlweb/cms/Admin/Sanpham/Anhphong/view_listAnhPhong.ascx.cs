using System;
using System.Data;
using System.Data.SqlClient;

namespace btlweb.cms.Admin.Sanpham.Anhphong
{
    
    public partial class view_listAnhPhong : System.Web.UI.UserControl
    {
        String constr = @"Data Source=.;Initial Catalog=hotelLuxury;Integrated Security=True";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadDataPhong();
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
                    cmd.CommandText = "viewAnhPhong";
                    cmd.Connection = sCnn;
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        rlAnhPhong.Text += @"
                            <tr id = maanh_" + dt.Rows[i]["MaAnh"] + @">
                                <td>" + dt.Rows[i]["MaPhong"] + @"</td>
                                <td>" + dt.Rows[i]["MaAnh"] + @"</td>
                                <td><img src='/Picture/Phong/" + dt.Rows[i]["Anh"] + @"'</td>
                                <td>
                                    <a href='javascript:XoaAnhPhong(" + dt.Rows[i]["MaAnh"] + @")'><i class='fa-solid fa-circle-minus'></i></a>
                                 </td>
                            </tr>
                        ";
                    }

                }
            }
        }
    }
}