using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HWDataBinding.Task_2
{
    public partial class EmpDetails : System.Web.UI.Page
    {
        private int idNum = 0;

        private List<Employee> employees = new List<Employee>()
                 {
                     new Employee() { FullName = "Nancy Davolio",ID=1, Phone = "0894 77 22 53"},
                     new Employee() { FullName = "Andrew	Fuller", ID = 2, Phone = "0899 555 444" },
                     new Employee() { FullName = "Janet Leverling", ID =3, Phone = "095 955 955" },
                     new Employee() { FullName = "Margaret Peacock",ID=4, Phone = "0894 77 72 53"},
                     new Employee() { FullName = "Steven	Buchanan", ID = 5, Phone = "0899 555 144" },
                     new Employee() { FullName = "Michael Suyama", ID=6, Phone = "095 955 055" },
                     new Employee() { FullName = "Robert	King",ID=7, Phone = "0894 77 22 59"},
                     new Employee() { FullName = "Laura Callahan", ID = 8, Phone = "0899 655 444" },
                     new Employee() { FullName = "Anne Dodsworth", ID = 9, Phone = "0899 695 444" }
                 };
        protected void Page_Load(object sender, EventArgs e)
        {
            string uri = Request.Url.AbsoluteUri;
            string check = uri.Substring(uri.Length - 1);

            bool isNumeric = int.TryParse(check, out idNum);
 

        
                this.DetailsViewOutput.DataSource = employees;
                this.DetailsViewOutput.DataBind();
      
        }

        protected void ButtonBack_Click(object sender, EventArgs e)
        {
            Response.Redirect("Employees.aspx");
        }

        protected void DetailsViewOutput_PageIndexChanging(object sender, DetailsViewPageEventArgs e)
        {
            this.DetailsViewOutput.PageIndex = idNum;
        }
    }
}