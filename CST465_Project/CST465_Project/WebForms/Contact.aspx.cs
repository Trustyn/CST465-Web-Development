using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CST465_Project.WebForms
{
    public partial class Contact : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            uxEventOutput.Text += "<br>" + "Load Called!";


        }

        protected void Page_Init(object sender, EventArgs e)
        {
            uxEventOutput.Text += "<br>" + "Init Called!";
        }

        protected void Page_PreRender(object sender, EventArgs e)
        {
            uxEventOutput.Text += "<br>" + "PreRender Called!";
        }

        protected void uxSubmit_Click(object sender, EventArgs e)
        {
            uxFormOutput.Text += "<br>" + "Name: " + uxName.Text + "<br>" +
                                 "Priority: " + uxPriority.Text + "<br>" +
                                 "Subject: " + uxSubject.Text + "<br>" +
                                 "Description: " + uxDescription.Text + "<br>";
        }
    }
}