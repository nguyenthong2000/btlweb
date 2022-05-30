using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace btlweb.cms.Admin.Dangnhap
{
    public partial class Dangnhap : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            label.Text = "";
            if (Request.Form.Count > 0 && Request.Form["type"] == "signin")
            {
                String email = Request.Form["email"];
                String pass = Request.Form["password"];
                if (email == "admin@gmail.com" && pass == "123")
                {
                    Session["adminLogedin"] = true;
                    Response.Redirect("/Admin.aspx");
                }
                else
                {
                    label.Text = "Thông tin tài khoản không chính xác!";
                }
            }
        }
    }
}