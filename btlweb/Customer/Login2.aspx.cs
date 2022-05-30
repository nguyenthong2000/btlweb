using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace btlweb.Customer
{
    public partial class Login2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void updatebtn_Click(object sender, EventArgs e)
        {
            lb_time.Text = DateTime.Now.ToString();
        }
    }
}