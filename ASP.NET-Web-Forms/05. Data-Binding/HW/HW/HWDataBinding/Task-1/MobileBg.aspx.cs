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
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                var defaultBrand = new Brand("Choose Brand");
                var brandMercedes = new Brand("Mercedes");
                var brandBmw = new Brand("BMW");
                var brandAudi = new Brand("Audi");
                var brandVW = new Brand("Volkswagen");
                var listOfBrands = new List<Brand>() { defaultBrand, brandMercedes, brandBmw, brandAudi, brandVW };

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
                this.DropDownListModel.DataSource = ModelGenerator.GetMercedesModels();
            }
            else if (this.DropDownListBrand.SelectedValue == "BMW")
            {
                this.DropDownListModel.DataSource = ModelGenerator.GetBMWModels();

            }
            else if (this.DropDownListBrand.SelectedValue == "Audi")
            {
                this.DropDownListModel.DataSource = ModelGenerator.GetAudiModels();

            }
            else if (this.DropDownListBrand.SelectedValue == "Volkswagen")
            {
                this.DropDownListModel.DataSource = ModelGenerator.GetVWModels();

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