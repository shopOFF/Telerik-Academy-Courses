using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HWDataBinding.Task_2
{
    public partial class EmpDetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var uri = Request.Url.AbsoluteUri;
            this.OutputLabel.InnerText = $"GREDAAAAA!!! Selected Customer ID = {uri.Substring(uri.Length - 1)}";
        }

        protected void ButtonBack_Click(object sender, EventArgs e)
        {
            Response.Redirect("Employees.aspx");
        }
    }
}