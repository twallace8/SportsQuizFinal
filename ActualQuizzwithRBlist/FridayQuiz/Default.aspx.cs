using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FridayQuizz
{
        public partial class _Default : Page
        {

            static int score = 0;
            string summary = "";

            protected void Page_Load(object sender, EventArgs e)
            {

            }

        // Question 1 answer A

        protected void RadioButtonList2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (RadioButtonList2.SelectedValue == "Reading")
            {
                Question1Answer.ForeColor = System.Drawing.Color.White;
                Question1Answer.Text = "Correct answer";
                Question1Answer.BackColor = System.Drawing.Color.Green;
                Question1Answer.BorderStyle = BorderStyle.Solid;
                score ++;
            }
            else if (RadioButtonList2.SelectedValue == "Newcastle")
            {
                Question1Answer.ForeColor = System.Drawing.Color.White;
                Question1Answer.Text = "Incorrect.The answer is Reading";
                Question1Answer.BackColor = System.Drawing.Color.Red;
                Question1Answer.BorderStyle = BorderStyle.Solid;
            }
            else if (RadioButtonList2.SelectedValue == "Derby")
            {
                Question1Answer.ForeColor = System.Drawing.Color.White;
                Question1Answer.Text = "Incorrect.The answer is Reading";
                Question1Answer.BackColor = System.Drawing.Color.Red;
                Question1Answer.BorderStyle = BorderStyle.Solid;
            }

            else if (RadioButtonList2.SelectedValue == "Norwich")
            {
                Question1Answer.ForeColor = System.Drawing.Color.White;
                Question1Answer.Text = "Incorrect.The answer is Reading";
                Question1Answer.BackColor = System.Drawing.Color.Red;
                Question1Answer.BorderStyle = BorderStyle.Solid;
            }
        }

        // Question 2 answer C

        protected void RadioButtonList3_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (RadioButtonList3.SelectedValue == "Las Vegas, Nevada")
            {
                Question2Answer.ForeColor = System.Drawing.Color.White;
                Question2Answer.Text = "Incorrect.The answer is Louisville, Kentucky";
                Question2Answer.BackColor = System.Drawing.Color.Red;
                Question2Answer.BorderStyle = BorderStyle.Solid;
                

            }
            else if (RadioButtonList3.SelectedValue == "Philadelphia, Pennsylvania")
            {
                Question2Answer.ForeColor = System.Drawing.Color.White;
                Question2Answer.Text = "Incorrect.The answer is Louisville, Kentucky";
                Question2Answer.BackColor = System.Drawing.Color.Red;
                Question2Answer.BorderStyle = BorderStyle.Solid;
            }
            else if (RadioButtonList3.SelectedValue == "Louisville, Kentucky")
            {
                Question2Answer.ForeColor = System.Drawing.Color.White;
                Question2Answer.Text = "Correct answer";
                Question2Answer.BackColor = System.Drawing.Color.Green;
                Question2Answer.BorderStyle = BorderStyle.Solid;
                score++;
            }

            else if (RadioButtonList3.SelectedValue == "Grand Rapids, Michigan")
            {
                Question2Answer.ForeColor = System.Drawing.Color.White;
                Question2Answer.Text = "Incorrect.The answer is Louisville, Kentucky";
                Question2Answer.BackColor = System.Drawing.Color.Red;
                Question2Answer.BorderStyle = BorderStyle.Solid;
            }
        }

        //Question 3 answer A

        protected void RadioButtonList4_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (RadioButtonList4.SelectedValue == "Goran Ivanišević")
            {
                Question3Answer.ForeColor = System.Drawing.Color.White;
                Question3Answer.Text = "Correct Answer";
                Question3Answer.BackColor = System.Drawing.Color.Green;
                Question3Answer.BorderStyle = BorderStyle.Solid;
                score++;

            }
            else if (RadioButtonList4.SelectedValue == "Marin Čilić")
            {
                Question3Answer.ForeColor = System.Drawing.Color.White;
                Question3Answer.Text = "Incorrect.The answer is Goran Ivanišević";
                Question3Answer.BackColor = System.Drawing.Color.Red;
                Question3Answer.BorderStyle = BorderStyle.Solid;
            }
            else if (RadioButtonList4.SelectedValue == "Tomáš Berdych")
            {
                Question3Answer.ForeColor = System.Drawing.Color.White;
                Question3Answer.Text = "Incorrect.The answer is Goran Ivanišević";
                Question3Answer.BackColor = System.Drawing.Color.Red;
                Question3Answer.BorderStyle = BorderStyle.Solid;
            }

            else if (RadioButtonList4.SelectedValue == "Richard Krajicek")
            {
                Question3Answer.ForeColor = System.Drawing.Color.White;
                Question3Answer.Text = "Incorrect.The answer is Goran Ivanišević";
                Question3Answer.BackColor = System.Drawing.Color.Red;
                Question3Answer.BorderStyle = BorderStyle.Solid;
            }
        }


        // Question 4 answer A

        protected void RadioButtonList5_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (RadioButtonList5.SelectedValue == "Joe Frazier")
            {
                Question4Answer.ForeColor = System.Drawing.Color.White;
                Question4Answer.Text = "Correct Answer";
                Question4Answer.BackColor = System.Drawing.Color.Green;
                Question4Answer.BorderStyle = BorderStyle.Solid;
                score++;

            }
            else if (RadioButtonList5.SelectedValue == "Sonny Liston")
            {
                Question4Answer.ForeColor = System.Drawing.Color.White;
                Question4Answer.Text = "Incorrect.The answer is Joe Frazier";
                Question4Answer.BackColor = System.Drawing.Color.Red;
                Question4Answer.BorderStyle = BorderStyle.Solid;
            }
            else if (RadioButtonList5.SelectedValue == "Ken Norton")
            {
                Question4Answer.ForeColor = System.Drawing.Color.White;
                Question4Answer.Text = "Incorrect.The answer is Joe Frazier";
                Question4Answer.BackColor = System.Drawing.Color.Red;
                Question4Answer.BorderStyle = BorderStyle.Solid;
            }

            else if (RadioButtonList5.SelectedValue == "George Foreman")
            {
                Question4Answer.ForeColor = System.Drawing.Color.White;
                Question4Answer.Text = "Incorrect.The answer is Joe Frazier";
                Question4Answer.BackColor = System.Drawing.Color.Red;
                Question4Answer.BorderStyle = BorderStyle.Solid;
            }
        }


        //Question 5 answer D

        protected void RadioButtonList6_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Eden Hazard, Riyad Mahrez, Alexis Sanchez, Jamie Vardy
            if (RadioButtonList6.SelectedValue == "Eden Hazard")
            {
                Question5Answer.ForeColor = System.Drawing.Color.White;
                Question5Answer.Text = "Incorrect.The answer is Jamie Vardy";
                Question5Answer.BackColor = System.Drawing.Color.Red;
                Question5Answer.BorderStyle = BorderStyle.Solid;
            }
            else if (RadioButtonList6.SelectedValue == "Riyad Mahrez")
            {
                Question5Answer.ForeColor = System.Drawing.Color.White;
                Question5Answer.Text = "Incorrect.The answer is Jamie Vardy";
                Question5Answer.BackColor = System.Drawing.Color.Red;
                Question5Answer.BorderStyle = BorderStyle.Solid;
            }
            else if (RadioButtonList6.SelectedValue == "Alexis Sanchez")
            {
                Question5Answer.ForeColor = System.Drawing.Color.White;
                Question5Answer.Text = "Incorrect.The answer is Jamie Vardy";
                Question5Answer.BackColor = System.Drawing.Color.Red;
                Question5Answer.BorderStyle = BorderStyle.Solid;
            }

            else if (RadioButtonList6.SelectedValue == "Jamie Vardy")
            {
                Question5Answer.ForeColor = System.Drawing.Color.White;
                Question5Answer.Text = "Correct Answer";
                Question5Answer.BackColor = System.Drawing.Color.Green;
                Question5Answer.BorderStyle = BorderStyle.Solid;
                score++;
            }
        }


        //Question 6 answer B

        protected void RadioButtonList7_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (RadioButtonList7.SelectedValue == "Didier Drogba")
            {
                Question6Answer.ForeColor = System.Drawing.Color.White;
                Question6Answer.Text = "Incorrect.The answer is Yaya Toure";
                Question6Answer.BackColor = System.Drawing.Color.Red;
                Question6Answer.BorderStyle = BorderStyle.Solid;
            }
            else if (RadioButtonList7.SelectedValue == "Yaya Toure")
            {
                Question6Answer.ForeColor = System.Drawing.Color.White;
                Question6Answer.Text = "Correct Answer";
                Question6Answer.BackColor = System.Drawing.Color.Green;
                Question6Answer.BorderStyle = BorderStyle.Solid;
                score++;
            }
            else if (RadioButtonList7.SelectedValue == "Victor Moses")
            {
                Question6Answer.ForeColor = System.Drawing.Color.White;
                Question6Answer.Text = "Incorrect.The answer is Yaya Toure";
                Question6Answer.BackColor = System.Drawing.Color.Red;
                Question6Answer.BorderStyle = BorderStyle.Solid;
            }

            else if (RadioButtonList7.SelectedValue == "Samuel Eto'o")
            {
                Question6Answer.ForeColor = System.Drawing.Color.White;
                Question6Answer.Text = "Incorrect.The answer is Yaya Toure";
                Question6Answer.BackColor = System.Drawing.Color.Red;
                Question6Answer.BorderStyle = BorderStyle.Solid;
                
            }
        }


        //Question 7 answer C

        protected void RadioButtonList8_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (RadioButtonList8.SelectedValue == "CapeTown, South Africa")
            {
                Question7Answer.ForeColor = System.Drawing.Color.White;
                Question7Answer.Text = "Incorrect.The answer is Tokyo, Japan";
                Question7Answer.BackColor = System.Drawing.Color.Red;
                Question7Answer.BorderStyle = BorderStyle.Solid;
            }
            else if (RadioButtonList8.SelectedValue == "Wellington, New Zealand")
            {
                Question7Answer.ForeColor = System.Drawing.Color.White;
                Question7Answer.Text = "Incorrect.The answer is Tokyo, Japan";
                Question7Answer.BackColor = System.Drawing.Color.Red;
                Question7Answer.BorderStyle = BorderStyle.Solid;
            }
            else if (RadioButtonList8.SelectedValue == "Tokyo, Japan")
            {
                Question7Answer.ForeColor = System.Drawing.Color.White;
                Question7Answer.Text = "Correct Answer";
                Question7Answer.BackColor = System.Drawing.Color.Green;
                Question7Answer.BorderStyle = BorderStyle.Solid;
                score++;
            }

            else if (RadioButtonList8.SelectedValue == "Shanghai, China")
            {
                Question6Answer.ForeColor = System.Drawing.Color.White;
                Question6Answer.Text = "Incorrect.The answer is Tokyo, Japan";
                Question6Answer.BackColor = System.Drawing.Color.Red;
                Question6Answer.BorderStyle = BorderStyle.Solid;
               
            }
        }


        //Question 8 answer C

        protected void RadioButtonList9_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (RadioButtonList9.SelectedValue == "Sir Bradley Wiggins and Jason Kenny")
            {
                Question8Answer.ForeColor = System.Drawing.Color.White;
                Question8Answer.Text = "Incorrect.The answer is Sir Bradley Wiggins and Mark Cavendish";
                Question8Answer.BackColor = System.Drawing.Color.Red;
                Question8Answer.BorderStyle = BorderStyle.Solid;
            }
            else if (RadioButtonList9.SelectedValue == "Jason Kenny and Chris Froome")
            {
                Question8Answer.ForeColor = System.Drawing.Color.White;
                Question8Answer.Text = "Incorrect.The answer is Sir Bradley Wiggins and Mark Cavendish";
                Question8Answer.BackColor = System.Drawing.Color.Red;
                Question8Answer.BorderStyle = BorderStyle.Solid;
            }
            else if (RadioButtonList9.SelectedValue == "Sir Bradley Wiggins and Mark Cavendish")
            {
                Question8Answer.ForeColor = System.Drawing.Color.White;
                Question8Answer.Text = "Correct Answer";
                Question8Answer.BackColor = System.Drawing.Color.Green;
                Question8Answer.BorderStyle = BorderStyle.Solid;
                score++;
            }

            else if (RadioButtonList9.SelectedValue == "Chris Froome and Mark Cavendish")
            {
                Question6Answer.ForeColor = System.Drawing.Color.White;
                Question6Answer.Text = "Incorrect.The answer is Sir Bradley Wiggins and Mark Cavendish";
                Question6Answer.BackColor = System.Drawing.Color.Red;
                Question6Answer.BorderStyle = BorderStyle.Solid;

            }
        }


        //Question 9 answer A

        protected void RadioButtonList10_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (RadioButtonList10.SelectedValue == "18")
            {
                Question9Answer.ForeColor = System.Drawing.Color.White;
                Question9Answer.Text = "Correct answer";
                Question9Answer.BackColor = System.Drawing.Color.Green;
                Question9Answer.BorderStyle = BorderStyle.Solid;
                score++;
            }
            else if (RadioButtonList10.SelectedValue == "16")
            {
                Question9Answer.ForeColor = System.Drawing.Color.White;
                Question9Answer.Text = "Incorrect.The answer is 18";
                Question9Answer.BackColor = System.Drawing.Color.Red;
                Question9Answer.BorderStyle = BorderStyle.Solid;
            }
            else if (RadioButtonList10.SelectedValue == "20")
            {
                Question9Answer.ForeColor = System.Drawing.Color.White;
                Question9Answer.Text = "Incorrect.The answer is 18";
                Question9Answer.BackColor = System.Drawing.Color.Red;
                Question9Answer.BorderStyle = BorderStyle.Solid;
            }

            else if (RadioButtonList10.SelectedValue == "17")
            {
                Question9Answer.ForeColor = System.Drawing.Color.White;
                Question9Answer.Text = "Incorrect.The answer is 18";
                Question9Answer.BackColor = System.Drawing.Color.Red;
                Question9Answer.BorderStyle = BorderStyle.Solid;

            }
        }


        // Question 10 Answer D

        protected void RadioButtonList11_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (RadioButtonList11.SelectedValue == "FC Barcelona")
            {
                Question10Answer.ForeColor = System.Drawing.Color.White;
                Question10Answer.Text = "Incorrect.The answer is Monaco";
                Question10Answer.BackColor = System.Drawing.Color.Red;
                Question10Answer.BorderStyle = BorderStyle.Solid;
            }
            else if (RadioButtonList11.SelectedValue == "Juventus")
            {
                Question10Answer.ForeColor = System.Drawing.Color.White;
                Question10Answer.Text = "Incorrect.The answer is Monaco";
                Question10Answer.BackColor = System.Drawing.Color.Red;
                Question10Answer.BorderStyle = BorderStyle.Solid;
            }
            else if (RadioButtonList11.SelectedValue == "Arsenal")
            {
                Question10Answer.ForeColor = System.Drawing.Color.White;
                Question10Answer.Text = "Incorrect.The answer is Monaco";
                Question10Answer.BackColor = System.Drawing.Color.Red;
                Question10Answer.BorderStyle = BorderStyle.Solid;
            }

            else if (RadioButtonList11.SelectedValue == "Monaco")
            {
                Question10Answer.ForeColor = System.Drawing.Color.White;
                Question10Answer.Text = "Correct answer";
                Question10Answer.BackColor = System.Drawing.Color.Green;
                Question10Answer.BorderStyle = BorderStyle.Solid;
                score++;
            }
        }
     

            //Results:

            protected void Submit_Click(object sender, EventArgs e)
            {
                if (score <= 4)
                {
                    summary = "This test is a little hard";
                }
                else if (score == 5)
                {
                    summary = "That's not too bad";
                }
                else if (score >= 6)
                {
                    summary = "Good effort";
                }
                else
                {
                    summary = "Great work";
                }

                TotalScore.Text = summary + ", you scored " + score + " out of 10 giving you " + (score * 10) + "%";
            }






        }

    }
