using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TelerikAcademyHWWebFormsWebHTMLControls
{
    public partial class RandomNumberGenerator : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            var fromNumber = int.Parse(this.Text1.Value);
            var toNumber = int.Parse(this.Text2.Value);

            var rndNumGenerator = new RndNumGenerator();
            var rndNum = rndNumGenerator.GenerateRandomNumber(fromNumber, toNumber);

            this.GeneratedNumberLiteral.Text = rndNum.ToString();
        }

        private class RndNumGenerator
        {
            public int GenerateRandomNumber(int fromNum, int toNum)
            {
                var generator = new Random();
                
                return generator.Next(fromNum, toNum);
            }
        }
    }
}