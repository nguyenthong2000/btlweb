using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace btlweb
{
    public partial class Admin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if ((bool)Session["adminLogedin"] == false)
            {
                Response.Redirect("cms/Admin/Dangnhap/Dangnhap.aspx");
            }
        }
    }
}