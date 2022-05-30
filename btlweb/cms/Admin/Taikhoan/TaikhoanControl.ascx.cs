using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace btlweb.cms.Admin.Taikhoan
{
    public partial class TaikhoanControl : System.Web.UI.UserControl
    {
        private string modulphu = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["modulphu"] != null)
            {
                modulphu = Request.QueryString["modulphu"];
            }
            switch (modulphu)
            {
                case "qltaikhoan":
                    plhDichVu.Controls.Add(LoadControl("qlTaiKhoan/qltaikhoanControl.ascx"));
                    break;
            }
        }
    }
}