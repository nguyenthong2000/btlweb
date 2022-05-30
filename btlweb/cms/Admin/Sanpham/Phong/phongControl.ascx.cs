using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace btlweb.cms.Admin.Phong.Loaiphong
{
    public partial class LoaiphongControl : System.Web.UI.UserControl
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
                    plhLP.Controls.Add(LoadControl("create_phong.ascx"));
                    break;
                case "chinhsua":
                    plhLP.Controls.Add(LoadControl("edit_phong.ascx"));
                    break;
                default:
                    plhLP.Controls.Add(LoadControl("list_phong.ascx"));
                    break;

            }
        }
    }
}
