using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CST465_Project.WebForms
{
    public partial class RequiredTextBox : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public string Value
        {
            get { return uxRequiredTextBox.Text; }
            set { uxRequiredTextBox.Text = value; }
        }

        public string LabelText
        {
            get { return lblRequiredTextBox.Text; }
            set { lblRequiredTextBox.Text = value; }
        }

        public string ValidationGroup
        {
            get { return valRequiredTextBox.ValidationGroup; }
            set { valRequiredTextBox.ValidationGroup = value; }
        }
    }
}