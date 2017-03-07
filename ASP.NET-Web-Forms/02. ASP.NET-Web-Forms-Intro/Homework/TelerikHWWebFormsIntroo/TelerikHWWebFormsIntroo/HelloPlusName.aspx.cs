using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TelerikHWWebFormsIntroo
{
    public partial class HelloPlusName : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            var textToDisplay = $"Hello {this.TextBox1.Text}!";

            this.Label1.Text = textToDisplay;
        }
    }
}