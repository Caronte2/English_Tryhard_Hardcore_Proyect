using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace English_Tryhard_Hardcore_Proyect
{
    public partial class UserPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            UserClass user = Session["User"] as UserClass;

            if (user == null)
            {
                Label1.Text = "No user is logged in.";
            }
            
        }
    }
}