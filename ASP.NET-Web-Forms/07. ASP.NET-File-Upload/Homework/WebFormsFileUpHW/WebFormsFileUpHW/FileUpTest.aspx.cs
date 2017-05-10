using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebFormsFileUpHW
{
    public partial class FileUpTest : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void UploadBtn_Click(object sender, EventArgs e)
        {
            if (this.FileUploadTest.HasFile)
            {
                string fileName = Path.GetFileName(this.FileUploadTest.FileName);
                this.FileUploadTest.SaveAs(Server.MapPath($"~/Uploaded_Files/{fileName}"));
                this.Label_Result.Text= "Upload status: File uploaded!";
            }
        }
    }
}