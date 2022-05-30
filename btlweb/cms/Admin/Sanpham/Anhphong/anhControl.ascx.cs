using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace btlweb.cms.Admin.Sanpham.Anhphong
{
    public partial class anhControl : System.Web.UI.UserControl
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
                    plhAnhPhong.Controls.Add(LoadControl("create_anhphong.ascx"));
                    break;
                case "xoa":
                    plhAnhPhong.Controls.Add(LoadControl("delete_phong.ascx"));
                    break;
                default:
                    plhAnhPhong.Controls.Add(LoadControl("view_listAnhPhong.ascx"));
                    break;

            }
        }
    }
}