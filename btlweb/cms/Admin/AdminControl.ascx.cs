using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace btlweb.cms.Admin
{

    public partial class AdminControl : System.Web.UI.UserControl
    {
        private string modul = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["modul"] != null)
                modul = Request.QueryString["modul"];
            switch (modul)
            {
                case "taikhoan":
                    plhAdminControl.Controls.Add(LoadControl("Taikhoan/TaikhoanControl.ascx"));
                    break;
                case "sanpham":
                    plhAdminControl.Controls.Add(LoadControl("Sanpham/sanphamControl.ascx"));
                    break;
                case "khachhang":
                    plhAdminControl.Controls.Add(LoadControl("Khachhang/khachhangControl.ascx"));
                    break;
                case "dichvu":
                    plhAdminControl.Controls.Add(LoadControl("Dichvu/dichvuControl.ascx"));
                    break;
                case "dondatphong":
                    plhAdminControl.Controls.Add(LoadControl("Dondatphong/dondatphongControl.ascx"));
                    break;
                //default:
                //    plhAdminControl.Controls.Add(LoadControl("Trangchu/trangchuControl.ascx"));
                //    break;
            }
        }
    }
}