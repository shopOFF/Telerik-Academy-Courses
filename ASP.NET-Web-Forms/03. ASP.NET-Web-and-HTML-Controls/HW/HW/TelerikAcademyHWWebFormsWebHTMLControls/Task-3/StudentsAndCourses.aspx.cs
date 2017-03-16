using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TelerikAcademyHWWebFormsWebHTMLControls.Task_3
{
    public partial class StudentsAndCourses : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonSubmit_Click(object sender, EventArgs e)
        {
            Label labelResult = new Label();
            labelResult.CssClass = "ResultLabel";
            labelResult.Text = "Result:";
            Label firstNameLabel = new Label();
            firstNameLabel.Text =$"First Name: {this.TextBoxFirstName.Text}" ;
            Label lastNameLabel = new Label();
            lastNameLabel.Text = $"Last Name: {this.TextBoxLastName.Text}";
            Label facNumLabel = new Label();
            facNumLabel.Text = $"Faculty Number: {this.TextBoxFacultyNumber.Text}";
            Label universityLabel = new Label();
            universityLabel.Text = $"University: {this.DropDownListUniversities.SelectedItem}";
            Label specialtyLabel = new Label();
            specialtyLabel.Text = $"Specialty: {this.DropDownListSpecialties.SelectedItem}";
            Label coursesLabel = new Label();
            var courses = this.CheckBoxListCourses.Items
                .Cast<ListItem>()
                .Where(li => li.Selected)
                .ToList();
            coursesLabel.Text = $"Courses: {string.Join(", ",courses)}";

            this.ResultInfo.Visible = true;
            this.ResultInfo.Controls.Add(labelResult);
            this.ResultInfo.Controls.Add(new LiteralControl("<br />"));
            this.ResultInfo.Controls.Add(firstNameLabel);
            this.ResultInfo.Controls.Add(new LiteralControl("<br />"));
            this.ResultInfo.Controls.Add(lastNameLabel);
            this.ResultInfo.Controls.Add(new LiteralControl("<br />"));
            this.ResultInfo.Controls.Add(facNumLabel);
            this.ResultInfo.Controls.Add(new LiteralControl("<br />"));
            this.ResultInfo.Controls.Add(universityLabel);
            this.ResultInfo.Controls.Add(new LiteralControl("<br />"));
            this.ResultInfo.Controls.Add(specialtyLabel);
            this.ResultInfo.Controls.Add(new LiteralControl("<br />"));
            this.ResultInfo.Controls.Add(coursesLabel);
        }
    }
}