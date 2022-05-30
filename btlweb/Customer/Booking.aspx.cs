using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace btlweb.Customer
{
    public partial class Booking : System.Web.UI.Page
    {

        String constr = @"Data Source=.;Initial Catalog=hotelLuxury;Integrated Security=True";
        int mataikhoan;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadPhong();
            }
        }

        private void LoadPhong()
        {
            using (SqlConnection sCnn = new SqlConnection(constr))
            {
                sCnn.Open();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "viewPhongID";
                    cmd.Connection = sCnn;
                    cmd.Parameters.AddWithValue("@maPhong", Request.QueryString["id"]);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        tbLPhong.Text = dt.Rows[0]["tenLoaiPhong"].ToString();
                        tbTPhong.Text = dt.Rows[0]["TenPhong"].ToString();
                        dongia.Text = dt.Rows[0]["DonGia"].ToString();
                        Image1.ImageUrl = dt.Rows[0]["Anh"].ToString();
                    }
                }
            }
        }


        protected void submitButton_Click(object sender, EventArgs e)
        {

            //check ngay
            String dt = DateTP.Text;
            String thang = dt.Substring(5, 2);
            String nam = dt.Substring(0, 4);
            String ngay = dt.Substring(8, 2);

            DateTime d1 = Convert.ToDateTime(nam + "/" + thang + "/" + ngay);
            Response.Write("<script language=javascript>alert('" + d1.Year + d1.Month + d1.Day + "');</script>");

            DateTime n = DateTime.Now;

            if (n > d1)
            {
                Response.Write("<script language=javascript>alert('Sai ngay');</script>");

            }
            else
            {
                using (SqlConnection sCnn = new SqlConnection(constr))
                {
                    sCnn.Open();

                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.CommandText = "laymaTK";
                        cmd.Connection = sCnn;
                        cmd.Parameters.Add(new SqlParameter("@Email", Session["User"]));


                        SqlDataReader kq = cmd.ExecuteReader();

                        if (kq.HasRows)
                        {
                            while (kq.Read())
                            {
                                mataikhoan = int.Parse(kq["MaTaiKhoan"].ToString());

                            }
                            //Response.Redirect("/Customer/Booking.aspx?");
                        }
                    }

                }
                using (SqlConnection sCnn = new SqlConnection(constr))
                {
                    sCnn.Open();
                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.CommandText = "insertDonDatPhong";
                        cmd.Connection = sCnn;
                        cmd.Parameters.Add(new SqlParameter("@SoLuongNguoi", numberParent.Text));
                        cmd.Parameters.Add(new SqlParameter("@NgayBatDau", DateNP.Text.ToString()));
                        cmd.Parameters.Add(new SqlParameter("@NgayKetThuc", DateTP.Text.ToString()));
                        cmd.Parameters.Add(new SqlParameter("@TrangThai", 1));
                        cmd.Parameters.AddWithValue("@MaTaiKhoan", mataikhoan);
                        cmd.Parameters.AddWithValue("@MaPhong", Request.QueryString["id"]);

                        int kq = cmd.ExecuteNonQuery();
                        if (kq != 0)
                        {
                            Response.Write("<script language=javascript>alert('Đặt phòng thành công');</script>");

                            //Response.Redirect("/Customer/Booking.aspx?");
                        }
                    }
                }


                using (SqlConnection sCnn = new SqlConnection(constr))
                {
                    sCnn.Open();
                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.CommandText = "editTThaiPhong";
                        cmd.Connection = sCnn;
                        cmd.Parameters.AddWithValue("@maPhong", Request.QueryString["id"]);
                        Response.Write("id");
                        int kq = cmd.ExecuteNonQuery();
                        if (kq != 0)
                        {
                            //Response.Write("<script>alert('Thanh cong')</script>");
                            //Response.Redirect("/Customer/Booking.aspx?");
                        }
                    }
                }

                Response.Redirect("Home.aspx");
                Response.Write("<script language=javascript>alert('dung ngay');</script>");
            }
        }
    }
}


