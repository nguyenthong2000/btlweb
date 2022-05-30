using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace btlweb.cms.Admin.Dichvu
{
    public partial class dichvuControl : System.Web.UI.UserControl
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
                    case "qldichvu":
                    plhDichVu.Controls.Add(LoadControl("qlDichVu/qldichvuControl.ascx"));
                    break;
                }
            }
        }
    }