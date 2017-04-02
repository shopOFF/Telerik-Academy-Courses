using System;
using System.Collections.Generic;
using System.Linq;
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

                var listOfBrands = new List<Brand>() {defaultBrand, brandMercedes, brandBmw };

                this.DropDownListBrand.DataSource = listOfBrands.Select(x => x.Name);
                this.DropDownListBrand.DataBind();
            }
        }

        protected void DropDownListBrand_SelectedIndexChanged(object sender, EventArgs e)
        {
            var mercedesModels = new List<string>() {"A class", "B class", "C class" ,
                "E class", "S class", "ML class", "GLK class","G class" };

            var bmwModels = new List<string>() { "1 series" , "2 series" , "3 series" ,
                "4 series" , "5 series" , "6 series" , "7 series" ,"X5 series","X6 series"};

            if (this.DropDownListBrand.SelectedValue == "Mercedes")
            {
                this.DropDownListModel.DataSource = mercedesModels;
            }
            else if (this.DropDownListBrand.SelectedValue == "BMW")
            {
                this.DropDownListModel.DataSource = bmwModels;

            }
            else
            {
                this.DropDownListModel.DataSource = string.Empty;
            }
            this.DropDownListModel.DataBind();
        }
    }
}