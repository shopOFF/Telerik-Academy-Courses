using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TelerikAcademyHWWebFormsWebHTMLControls.Task_4
{
    public partial class TicТacТoe : System.Web.UI.Page
    {
        private static int playerCounter = 0;
        private const string X_PLAYER = "X";
        private const string O_PLAYER = "O";
        private const string WINNER_X_MESSAGE = "PLAYER X WON!";
        private const string WINNER_O_MESSAGE = "PLAYER O WON!";
        private const string DRAW_MESSAGE = "DRAW!";

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonFirstRowLeft_Click(object sender, EventArgs e)
        {
            playerCounter++;
            this.ButtonFirstRowLeft.Text = CheckFirsOrSecondPlayer();
            this.ButtonFirstRowLeft.Enabled = false;
            CheckIfThereIsAWinner();
        }

        protected void ButtonFirstRowMiddle_Click(object sender, EventArgs e)
        {
            playerCounter++;
            this.ButtonFirstRowMiddle.Text = CheckFirsOrSecondPlayer();
            this.ButtonFirstRowMiddle.Enabled = false;
            CheckIfThereIsAWinner();
        }

        protected void ButtonFirstRowRight_Click(object sender, EventArgs e)
        {
            playerCounter++;
            this.ButtonFirstRowRight.Text = CheckFirsOrSecondPlayer();
            this.ButtonFirstRowRight.Enabled = false;
            CheckIfThereIsAWinner();
        }

        protected void ButtonSecondRowLeft_Click(object sender, EventArgs e)
        {
            playerCounter++;
            this.ButtonSecondRowLeft.Text = CheckFirsOrSecondPlayer();
            this.ButtonSecondRowLeft.Enabled = false;
            CheckIfThereIsAWinner();
        }

        protected void ButtonSecondRowMiddle_Click(object sender, EventArgs e)
        {
            playerCounter++;
            this.ButtonSecondRowMiddle.Text = CheckFirsOrSecondPlayer();
            this.ButtonSecondRowMiddle.Enabled = false;
            CheckIfThereIsAWinner();
        }

        protected void ButtonSecondRowRight_Click(object sender, EventArgs e)
        {
            playerCounter++;
            this.ButtonSecondRowRight.Text = CheckFirsOrSecondPlayer();
            this.ButtonSecondRowRight.Enabled = false;
            CheckIfThereIsAWinner();
        }

        protected void ButtonThirdRowLeft_Click(object sender, EventArgs e)
        {
            playerCounter++;
            this.ButtonThirdRowLeft.Text = CheckFirsOrSecondPlayer();
            this.ButtonThirdRowLeft.Enabled = false;
            CheckIfThereIsAWinner();
        }

        protected void ButtonThirdRowMiddle_Click(object sender, EventArgs e)
        {
            playerCounter++;
            this.ButtonThirdRowMiddle.Text = CheckFirsOrSecondPlayer();
            this.ButtonThirdRowMiddle.Enabled = false;
            CheckIfThereIsAWinner();
        }

        protected void ButtonThirdRowRight_Click(object sender, EventArgs e)
        {
            playerCounter++;
            this.ButtonThirdRowRight.Text = CheckFirsOrSecondPlayer();
            this.ButtonThirdRowRight.Enabled = false;
            CheckIfThereIsAWinner();
        }

        protected void ButtonRestart_Click(object sender, EventArgs e)
        {
            playerCounter = 0;
            this.ButtonFirstRowLeft.Text = " ";
            this.ButtonFirstRowMiddle.Text = " ";
            this.ButtonFirstRowRight.Text = " ";

            this.ButtonSecondRowLeft.Text = " ";
            this.ButtonSecondRowMiddle.Text = " ";
            this.ButtonSecondRowRight.Text = " ";

            this.ButtonThirdRowLeft.Text = " ";
            this.ButtonThirdRowMiddle.Text = " ";
            this.ButtonThirdRowRight.Text = " ";

            this.LabelResult.Visible = false;
            EnableDisabeField();
        }

        private string CheckFirsOrSecondPlayer()
        {
            if (playerCounter % 2 != 0)
            {
                return X_PLAYER;
            }
            else
            {
                return O_PLAYER;
            }
        }

        private void CheckIfThereIsAWinner()
        {
            // X won, you won
            if (this.ButtonFirstRowLeft.Text == X_PLAYER &&
                this.ButtonFirstRowMiddle.Text == X_PLAYER &&
                this.ButtonFirstRowRight.Text == X_PLAYER)
            {
                this.LabelResult.Visible = true;
                this.LabelResult.Text = WINNER_X_MESSAGE;
                EnableDisabeField();
            }
            else if (this.ButtonFirstRowLeft.Text == X_PLAYER &&
                this.ButtonSecondRowMiddle.Text == X_PLAYER &&
                this.ButtonThirdRowRight.Text == X_PLAYER)
            {
                this.LabelResult.Visible = true;
                this.LabelResult.Text = WINNER_X_MESSAGE;
                EnableDisabeField();
            }
            else if (this.ButtonFirstRowRight.Text == X_PLAYER &&
               this.ButtonSecondRowRight.Text == X_PLAYER &&
               this.ButtonThirdRowRight.Text == X_PLAYER)
            {
                this.LabelResult.Visible = true;
                this.LabelResult.Text = WINNER_X_MESSAGE;
                EnableDisabeField();
            }
            else if (this.ButtonFirstRowLeft.Text == X_PLAYER &&
              this.ButtonSecondRowLeft.Text == X_PLAYER &&
              this.ButtonThirdRowLeft.Text == X_PLAYER)
            {
                this.LabelResult.Visible = true;
                this.LabelResult.Text = WINNER_X_MESSAGE;
                EnableDisabeField();
            }
            else if (this.ButtonFirstRowRight.Text == X_PLAYER &&
              this.ButtonSecondRowMiddle.Text == X_PLAYER &&
              this.ButtonThirdRowLeft.Text == X_PLAYER)
            {
                this.LabelResult.Visible = true;
                this.LabelResult.Text = WINNER_X_MESSAGE;
                EnableDisabeField();
            }
            else if (this.ButtonFirstRowMiddle.Text == X_PLAYER &&
              this.ButtonSecondRowMiddle.Text == X_PLAYER &&
              this.ButtonThirdRowMiddle.Text == X_PLAYER)
            {
                this.LabelResult.Visible = true;
                this.LabelResult.Text = WINNER_X_MESSAGE;
                EnableDisabeField();
            }

            else if (this.ButtonSecondRowLeft.Text == X_PLAYER &&
             this.ButtonSecondRowMiddle.Text == X_PLAYER &&
             this.ButtonSecondRowRight.Text == X_PLAYER)
            {
                this.LabelResult.Visible = true;
                this.LabelResult.Text = WINNER_X_MESSAGE;
                EnableDisabeField();
            }
            else if (this.ButtonThirdRowLeft.Text == X_PLAYER &&
            this.ButtonThirdRowMiddle.Text == X_PLAYER &&
            this.ButtonThirdRowRight.Text == X_PLAYER)
            {
                this.LabelResult.Visible = true;
                this.LabelResult.Text = WINNER_X_MESSAGE;
                EnableDisabeField();
            }

            // draw
            if (playerCounter == 9)
            {
                this.LabelResult.Visible = true;
                this.LabelResult.Text = DRAW_MESSAGE;
                EnableDisabeField();
            }

            // O won, you lost
            if (this.ButtonFirstRowLeft.Text == O_PLAYER &&
               this.ButtonFirstRowMiddle.Text == O_PLAYER &&
               this.ButtonFirstRowRight.Text == O_PLAYER)
            {
                this.LabelResult.Visible = true;
                this.LabelResult.Text = WINNER_O_MESSAGE;
                EnableDisabeField();
            }
            else if (this.ButtonFirstRowLeft.Text == O_PLAYER &&
                this.ButtonSecondRowMiddle.Text == O_PLAYER &&
                this.ButtonThirdRowRight.Text == O_PLAYER)
            {
                this.LabelResult.Visible = true;
                this.LabelResult.Text = WINNER_O_MESSAGE;
                EnableDisabeField();
            }
            else if (this.ButtonFirstRowRight.Text == O_PLAYER &&
               this.ButtonSecondRowRight.Text == O_PLAYER &&
               this.ButtonThirdRowRight.Text == O_PLAYER)
            {
                this.LabelResult.Visible = true;
                this.LabelResult.Text = WINNER_O_MESSAGE;
                EnableDisabeField();
            }
            else if (this.ButtonFirstRowLeft.Text == O_PLAYER &&
              this.ButtonSecondRowLeft.Text == O_PLAYER &&
              this.ButtonThirdRowLeft.Text == O_PLAYER)
            {
                this.LabelResult.Visible = true;
                this.LabelResult.Text = WINNER_O_MESSAGE;
                EnableDisabeField();
            }
            else if (this.ButtonFirstRowRight.Text == O_PLAYER &&
              this.ButtonSecondRowMiddle.Text == O_PLAYER &&
              this.ButtonThirdRowLeft.Text == O_PLAYER)
            {
                this.LabelResult.Visible = true;
                this.LabelResult.Text = WINNER_O_MESSAGE;
                EnableDisabeField();
            }
            else if (this.ButtonFirstRowMiddle.Text == O_PLAYER &&
              this.ButtonSecondRowMiddle.Text == O_PLAYER &&
              this.ButtonThirdRowMiddle.Text == O_PLAYER)
            {
                this.LabelResult.Visible = true;
                this.LabelResult.Text = WINNER_O_MESSAGE;
                EnableDisabeField();
            }

            else if (this.ButtonSecondRowLeft.Text == O_PLAYER &&
             this.ButtonSecondRowMiddle.Text == O_PLAYER &&
             this.ButtonSecondRowRight.Text == O_PLAYER)
            {
                this.LabelResult.Visible = true;
                this.LabelResult.Text = WINNER_O_MESSAGE;
                EnableDisabeField();
            }
            else if (this.ButtonThirdRowLeft.Text == O_PLAYER &&
            this.ButtonThirdRowMiddle.Text == O_PLAYER &&
            this.ButtonThirdRowRight.Text == O_PLAYER)
            {
                this.LabelResult.Visible = true;
                this.LabelResult.Text = WINNER_O_MESSAGE;
                EnableDisabeField();
            }
        }

        private void EnableDisabeField()
        {
            if (LabelResult.Visible == true)
            {
                this.ButtonFirstRowLeft.Enabled = false;
                this.ButtonFirstRowMiddle.Enabled = false;
                this.ButtonFirstRowRight.Enabled = false;

                this.ButtonSecondRowLeft.Enabled = false;
                this.ButtonSecondRowMiddle.Enabled = false;
                this.ButtonSecondRowRight.Enabled = false;

                this.ButtonThirdRowLeft.Enabled = false;
                this.ButtonThirdRowMiddle.Enabled = false;
                this.ButtonThirdRowRight.Enabled = false;
            }
            else
            {
                this.ButtonFirstRowLeft.Enabled = true;
                this.ButtonFirstRowMiddle.Enabled = true;
                this.ButtonFirstRowRight.Enabled = true;

                this.ButtonSecondRowLeft.Enabled = true;
                this.ButtonSecondRowMiddle.Enabled = true;
                this.ButtonSecondRowRight.Enabled = true;

                this.ButtonThirdRowLeft.Enabled = true;
                this.ButtonThirdRowMiddle.Enabled = true;
                this.ButtonThirdRowRight.Enabled = true;
            }
        }
    }
}