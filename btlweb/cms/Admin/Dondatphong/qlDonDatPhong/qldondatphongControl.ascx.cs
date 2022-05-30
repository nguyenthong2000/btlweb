using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace btlweb.cms.Admin.Dondatphong.qlDonDatPhong
{
    public partial class qldondatphongControl : System.Web.UI.UserControl
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
                case "chinhsua":
                    plhqlDonDatPhong.Controls.Add(LoadControl("edit_dondatphong.ascx"));
                    break;
                default:
                    plhqlDonDatPhong.Controls.Add(LoadControl("list_dondatphong.ascx"));
                    break;

            }
        }
    }
}