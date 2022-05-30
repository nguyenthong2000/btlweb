using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace btlweb.Customer
{
    public partial class Register : System.Web.UI.Page
    {
        String connectionSTR = @"Data Source=.;Initial Catalog=hotelLuxury;Integrated Security=True";
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void registerbtn_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand())
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "checkEmaiAlreadyExist";
                    command.Connection = connection;
                    command.Parameters.Add(new SqlParameter("@email", tb_username.Text.Trim()));
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable data = new DataTable();
                    adapter.Fill(data);

                    if (data.Rows.Count > 0)
                    {
                        Response.Write("<script language=javascript>alert('Tài khoản đã được đăng ký');</script>");

                    }
                    else
                    {
                        command.Dispose();
                        command.Parameters.Clear();
                        command.CommandType = CommandType.StoredProcedure;
                        command.CommandText = "register";
                        command.Connection = connection;
                        command.Parameters.Add(new SqlParameter("@email", tb_username.Text.Trim()));
                        command.Parameters.Add(new SqlParameter("@password", tb_password.Text.Trim()));

                        int result = command.ExecuteNonQuery();
                        if (result > 0)
                        {
                            Session["User"] = tb_username.Text.Trim();
                            Response.Redirect("Home.aspx");
                        }
                        else
                        {
                            Response.Write("<script language=javascript>alert('Đăng ký thất bại');</script>");
                        }



                    }


                    command.Dispose();
                }
                connection.Close();

            }


            /*
            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                connection.Open();

                SqlCommand command = new SqlCommand("select * from TaiKhoan where TaiKhoan.Email = '" + tb_username.Text.Trim() + "'", connection);

                var readerselect = command.ExecuteReader();
                if (readerselect.HasRows)
                {
                    //da co email
                    Response.Write("<script language=javascript>alert('Tài khoản này đã được đăng ký');</script>");
                    readerselect.Close();
                }
                else
                {
                    readerselect.Close();
                    command = new SqlCommand("insert into TaiKhoan(Email,MatKhau,TrangThai,MaLoaiTaiKhoan) Values('" + tb_username.Text.Trim() + "', '" + tb_password.Text.Trim() + "', 1, 1); ", connection);
                    int check = command.ExecuteNonQuery();

                    if (check > 0)
                    {
                        //thanhcong
                        command = new SqlCommand("select * from TaiKhoan where TaiKhoan.Email = '" + tb_username.Text.Trim() + "' and TaiKhoan.MatKhau='" + tb_password.Text.Trim() + "'", connection);

                        var reader = command.ExecuteReader();
                        if (reader.HasRows)
                        {

                            while (reader.Read())
                            {
                                Response.Write("<script language=javascript>alert('" + reader["MaTaiKhoan"].ToString() + "');</script>");
                                Session["User"] = reader["MaTaiKhoan"];
                                Response.Redirect("Home.aspx");

                            }

                        }
                        else
                        {
                            Response.Write("<script language=javascript>alert('Đăng ký thất bại');</script>");
                        }
                        reader.Close();
                    }

                }
                command.Dispose();


                connection.Close();
            */

        }
    }
}