using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace btlweb.cms.Admin.Sanpham
{
    public partial class sanphamControl : System.Web.UI.UserControl
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
                case "phong":
                    plhSanpham.Controls.Add(LoadControl("Phong/phongControl.ascx"));
                    break;
                case "loaiphong":
                    plhSanpham.Controls.Add(LoadControl("LoaiPhong/loaiphongControl.ascx"));
                    break;
                case "aphong":
                    plhSanpham.Controls.Add(LoadControl("Anhphong/anhControl.ascx"));
                    break;
            }
        }
    }
}