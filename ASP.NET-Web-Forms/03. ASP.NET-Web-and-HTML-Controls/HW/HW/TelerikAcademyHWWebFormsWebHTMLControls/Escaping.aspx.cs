using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TelerikAcademyHWWebFormsWebHTMLControls
{
    public partial class Escaping : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button_Click(object sender, EventArgs e)
        {
            var inutText = this.TextBoxInput.Text;
            this.TextBoxOutput.Text = inutText;
        }
    }
}