using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;

namespace CST465_Project.WebForms
{
    public partial class ValidatedForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void uxSubmit_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("?Name=" + uxName.Value);
            sb.Append("&FavoriteColor=" + uxFavoriteColor.Value);
            sb.Append("&City=" + uxCity.Value);
            Response.Redirect("/Validatedformoutput.aspx" + sb.ToString());
        }
    }
}