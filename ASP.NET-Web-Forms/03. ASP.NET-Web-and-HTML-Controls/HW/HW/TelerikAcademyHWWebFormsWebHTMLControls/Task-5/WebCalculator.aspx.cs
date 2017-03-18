using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TelerikAcademyHWWebFormsWebHTMLControls.Task_5
{
    public partial class WebCalculator : System.Web.UI.Page
    {
        private const string SQUARE_ROOT = " √ ";
        private const string MINUS = " - ";
        private const string PLUS = " + ";
        private const string DIVISE = " / ";
        private const string MULTIPLY = " x ";

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            this.TextBoxOutput.Text += "1";
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            this.TextBoxOutput.Text += "2";
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            this.TextBoxOutput.Text += "3";
        }

        protected void ButtonPlus_Click(object sender, EventArgs e)
        {
            this.TextBoxOutput.Text += PLUS;

        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            this.TextBoxOutput.Text += "4";
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            this.TextBoxOutput.Text += "5";
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            this.TextBoxOutput.Text += "6";
        }

        protected void ButtonMinus_Click(object sender, EventArgs e)
        {
            this.TextBoxOutput.Text += MINUS;
        }

        protected void Button7_Click(object sender, EventArgs e)
        {
            this.TextBoxOutput.Text += "7";
        }

        protected void Button8_Click(object sender, EventArgs e)
        {
            this.TextBoxOutput.Text += "8";
        }

        protected void Button9_Click(object sender, EventArgs e)
        {
            this.TextBoxOutput.Text += "9";
        }

        protected void ButtonMultiply_Click(object sender, EventArgs e)
        {
            this.TextBoxOutput.Text += MULTIPLY;
        }

        protected void ButtonClear_Click(object sender, EventArgs e)
        {
            this.TextBoxOutput.Text = string.Empty;
        }

        protected void Button0_Click(object sender, EventArgs e)
        {
            this.TextBoxOutput.Text += "0";
        }

        protected void ButtonDivis_Click(object sender, EventArgs e)
        {
            this.TextBoxOutput.Text += DIVISE;
        }

        protected void ButtonSquareRoot_Click(object sender, EventArgs e)
        {
            this.TextBoxOutput.Text += SQUARE_ROOT;
        }

        protected void ButtonEquals_Click(object sender, EventArgs e)
        {
            this.TextBoxOutput.Text = ResultCalculator(this.TextBoxOutput.Text);
        }

        private string ResultCalculator(string equation)
        {
            try
            {
                var splitEquation = equation.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries).ToList();

                if (splitEquation.Contains("√") && splitEquation.Count == 2)
                {
                    return Math.Sqrt(long.Parse(splitEquation[0])).ToString();
                }
                else if (splitEquation.Count > 1)
                {
                    double result = long.Parse(splitEquation[0]);

                    for (int i = 1; i < splitEquation.Count - 1; i++)
                    {
                        if (splitEquation[i] == "+")
                        {
                            result += long.Parse(splitEquation[i + 1]);
                        }
                        else if (splitEquation[i] == "-")
                        {
                            result -= long.Parse(splitEquation[i + 1]);
                        }
                        else if (splitEquation[i] == "√")
                        {
                            result = Math.Sqrt(long.Parse(splitEquation[i - 1]));
                        }
                        else if (splitEquation[i] == "/")
                        {
                            result /= long.Parse(splitEquation[i + 1]);
                        }
                        else if (splitEquation[i] == "x")
                        {
                            result *= long.Parse(splitEquation[i + 1]);
                        }
                    }

                    return result.ToString();
                }
                else
                {
                    return this.TextBoxOutput.Text;
                }
            }
            catch (Exception)
            {

                return "INVALID INPUT";
            }
        }
    }
}