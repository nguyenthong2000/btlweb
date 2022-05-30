using System;
using System.Data;
using System.Data.SqlClient;
namespace btlweb.cms.Admin.Sanpham.LoaiPhong
{
    public partial class list_LoaiPhong : System.Web.UI.UserControl
    {
        String constr = @"Data Source=.;Initial Catalog=hotelLuxury;Integrated Security=True";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadDataLoaiPhong();
            }
        }
        public void LoadDataLoaiPhong()
        {
            using (SqlConnection sCnn = new SqlConnection(constr))
            {
                sCnn.Open();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "viewLP";
                    cmd.Connection = sCnn;
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    //repeater_anh.DataSource = dt;
                    //repeater_anh.DataBind();
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        rlLoaiPhong.Text += @"
                             <tr>
                                 <td>" + dt.Rows[i]["MaLoaiPhong"] + @"</td>
                                 <td>" + dt.Rows[i]["tenLoaiPhong"] + @"</td>
                                 <td>" + dt.Rows[i]["MoTaLoaiPhong"] + @"</td>  
                             </tr>
                         ";
                    }

                }
            }
        }
    }
}