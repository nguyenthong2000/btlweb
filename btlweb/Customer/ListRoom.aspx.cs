using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI.WebControls;

namespace btlweb.Customer
{
    public partial class ListRoom : System.Web.UI.Page
    {
        String constr = @"Data Source=.;Initial Catalog=hotelLuxury;Integrated Security=True";
        protected void Page_Load(object sender, EventArgs e)
        {
           
            if (!IsPostBack)
            {
                if (Session["User"] != null)
                {
                    Response.Write("<script language=javascript>alert('login');</script>");
                    
                }
                else
                {
                    Response.Write("<script language=javascript>alert('that bai');</script>");
                    Response.Redirect("Login.aspx");
                }

            }
            loadPhong();
        }

        private void loadPhong()
        {
            using (SqlConnection sCnn = new SqlConnection(constr))
            {
                sCnn.Open();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "viewphongbyLPdexury";
                    cmd.Connection = sCnn;
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        ltpr.Text += @"
                        <li class='main - product no - margin'>
                        <div class='img-product'>
                        <img src='/Picture/Phong/" + dt.Rows[i]["Anh"] + @"'
                        </div>
                        <div class='content-product'>
                        <p class='content-product-p'>" + dt.Rows[i]["TenPhong"] + @"</p>
                        <p class='content-product-p'>" + dt.Rows[i]["DonGia"] + @"</p>
                        <div class='content-product-deltals'>
                            <a href='../Customer/Booking.aspx?id=" + dt.Rows[i]["MaPhong"] + @"' class='btn btn-cart'>Đặt Phòng</a>
                        </div>
                    </div>
                </li>
                        ";
                    }
                }
                using(SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "viewphongbyLPsuit";
                    cmd.Connection = sCnn;
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        Literal2.Text += @"
                        <li class='main - product no - margin'>
                        <div class='img-product'>
                        <img src='/Picture/Phong/" + dt.Rows[i]["Anh"] + @"'
                        </div>
                        <div class='content-product'>
                        <p class='content-product-p'>" + dt.Rows[i]["TenPhong"] + @"</p>
                        <p class='content-product-p'>" + dt.Rows[i]["DonGia"] + @"</p>
                        <div class='content-product-deltals'>
                            <a href='../Customer/Booking.aspx?id=" + dt.Rows[i]["MaPhong"] + @"' class='btn btn-cart'>Đặt Phòng</a>
                        </div>
                    </div>
                </li>
                        ";
                    }
                }
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "viewphongbyLPvip";
                    cmd.Connection = sCnn;
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        Literal3.Text += @"
                        <li class='main - product no - margin'>
                        <div class='img-product'>
                        <img src='/Picture/Phong/" + dt.Rows[i]["Anh"] + @"'
                        </div>
                        <div class='content-product'>
                        <p class='content-product-p'>" + dt.Rows[i]["TenPhong"] + @"</p>
                        <p class='content-product-p'>" + dt.Rows[i]["DonGia"] + @"</p>
                        <div class='content-product-deltals'>
                            <a href='../Customer/Booking.aspx?id=" + dt.Rows[i]["MaPhong"] + @"' class='btn btn-cart'>Đặt Phòng</a>
                        </div>
                    </div>
                </li>
                        ";
                    }
                }

            }
        }
    }
}