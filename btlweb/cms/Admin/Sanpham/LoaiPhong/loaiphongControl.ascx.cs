using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace btlweb.cms.Admin.Sanpham.LoaiPhong
{
    public partial class loaiphongControl : System.Web.UI.UserControl
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
                    plhLoaiPhong.Controls.Add(LoadControl("create_loaiphong.ascx"));
                    break;
                default:
                    plhLoaiPhong.Controls.Add(LoadControl("list_LoaiPhong.ascx"));
                    break;

            }
        }
    }
}