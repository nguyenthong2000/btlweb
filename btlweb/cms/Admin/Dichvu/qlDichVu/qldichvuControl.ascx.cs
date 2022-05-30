using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace btlweb.cms.Admin.Dichvu.qlDichVu
{
    public partial class qldichvuControl : System.Web.UI.UserControl
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
                    plhqlDichVu.Controls.Add(LoadControl("create_dichvu.ascx"));
                    break;
                case "chinhsua":
                    plhqlDichVu.Controls.Add(LoadControl("edit_dichvu.ascx"));
                    break;
                default:
                    plhqlDichVu.Controls.Add(LoadControl("list_dichvu.ascx"));
                    break;

            }
        }
    }
}