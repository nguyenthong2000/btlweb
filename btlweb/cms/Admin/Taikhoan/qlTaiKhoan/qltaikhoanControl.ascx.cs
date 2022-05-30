using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace btlweb.cms.Admin.Taikhoan.qlTaiKhoan
{
    public partial class qltaikhoanControl : System.Web.UI.UserControl
    {
        private string modulphu = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["thaotac"] != null)
            {
                modulphu = Request.QueryString["thaotac"];
            }
            switch (modulphu)
            {
                case "themmoi":
                    plhqlTaiKhoan.Controls.Add(LoadControl("create_taikhoan.ascx"));
                    break;
                case "chinhsua":
                    plhqlTaiKhoan.Controls.Add(LoadControl("edit_taikhoan.ascx"));
                    break;
                default:
                    plhqlTaiKhoan.Controls.Add(LoadControl("list_taikhoan.ascx"));
                    break;

            }
        }
    }
}