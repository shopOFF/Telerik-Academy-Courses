using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HWDataBinding.Task_1
{
    public partial class MobileBg : System.Web.UI.Page
    {
        private Brand defaultBrand = new Brand("Choose Brand");

        private Brand brandMercedes = new Brand("Mercedes")
        {
            CollectionOfModels = new List<string>()
        { "A class", "B class", "C class" , "E class", "S class", "ML class", "GLK class","G class" }
        };

        private Brand brandBmw = new Brand("BMW")
        {
            CollectionOfModels = new List<string>()
        { "1 series" , "2 series" , "3 series" ,"4 series" , "5 series" , "6 series" , "7 series" ,"X5 series","X6 series" }
        };

        private Brand brandAudi = new Brand("Audi")
        {
            CollectionOfModels = new List<string>()
        { "A 1", "A 3", "A 4","A 6", "A 7", "A 8", "RS 6", "Q 7", "R 8" }
        };

        private Brand brandVW = new Brand("Volkswagen")
        {
            CollectionOfModels = new List<string>()
        { "Polo", "Golf", "Passat","Phaeton", "Touareg", "Scirocco", "Jetta", "Tiguan", "Beetle" }
        };

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                var listOfBrands = new List<Brand>() { this.defaultBrand, this.brandMercedes, this.brandBmw, this.brandAudi, this.brandVW };

                this.DropDownListBrand.DataSource = listOfBrands.Select(x => x.Name);
                this.DropDownListBrand.DataBind();

                var extraAC = new Extra() { Name = "AC" };
                var extraLeatherSeats = new Extra() { Name = "Leather Seats" };
                var extraNavi = new Extra() { Name = "Navigation" };
                var extraESP = new Extra() { Name = "ESP" };
                var extraAlarm = new Extra() { Name = "Alarm" };
                var listOfExtras = new List<Extra>() { extraAC, extraLeatherSeats, extraNavi, extraESP, extraAlarm };

                this.CheckBoxListExtras.DataSource = listOfExtras.Select(x => x.Name);
                this.CheckBoxListExtras.DataBind();

                this.RadioButtonListEngines.DataSource = new List<string>() { "Petrol", "Diesel", "Electric", "Hybrid" };
                this.RadioButtonListEngines.DataBind();
            }
        }

        protected void DropDownListBrand_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.DropDownListBrand.SelectedValue == "Mercedes")
            {
                this.DropDownListModel.DataSource = this.brandMercedes.CollectionOfModels;
            }
            else if (this.DropDownListBrand.SelectedValue == "BMW")
            {
                this.DropDownListModel.DataSource = this.brandBmw.CollectionOfModels;

            }
            else if (this.DropDownListBrand.SelectedValue == "Audi")
            {
                this.DropDownListModel.DataSource = this.brandAudi.CollectionOfModels;

            }
            else if (this.DropDownListBrand.SelectedValue == "Volkswagen")
            {
                this.DropDownListModel.DataSource = this.brandVW.CollectionOfModels;

            }
            else
            {
                this.DropDownListModel.DataSource = string.Empty;
            }
            this.DropDownListModel.DataBind();
        }

        protected void ButtonSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                this.ResultInfo.InnerText = string.Empty;

                var extras = this.CheckBoxListExtras.Items
               .Cast<ListItem>()
               .Where(li => li.Selected)
               .ToList();

                var sb = new StringBuilder();
                sb.Append($"Car Brand - {this.DropDownListBrand.SelectedItem.Text}");
                sb.Append("<br>");
                sb.Append($"Car Model - {this.DropDownListModel.SelectedItem.Text}");
                sb.AppendLine("<br>");
                sb.Append($"Car Extras - {string.Join(", ", extras)}");
                sb.AppendLine("<br>");
                sb.Append($"Car Engine Type - {this.RadioButtonListEngines.SelectedItem.Text}");

                var literalInfo = new Literal();
                literalInfo.Text = sb.ToString();
                this.ResultInfo.Visible = true;
                this.ResultInfo.Controls.Add(literalInfo);
            }
            catch (Exception)
            {
                this.ResultInfo.Visible = true;
                this.ResultInfo.InnerText = "INVALID INPUT!";
            }

        }
    }
}