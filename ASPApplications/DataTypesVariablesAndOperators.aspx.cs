using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPApplications
{
    public partial class DevSheet2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //comparisionTypeLabel.Text = "equal to";
            //comparisionTypeLabel.Text = "not equal to";
            comparisionTypeLabel.Text = "greater than";
            pizzaImage.ImageUrl = "/Images/tonys-pizzaria.jpg";
            totalLabel.Text = "$0.00";


        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //resultLabel.Text = (firstTextBox.Text == secondTextBox.Text) ?  "Yes" : "No";
            //resultLabel.Text = (firstTextBox.Text != secondTextBox.Text) ?  "Yes" : "No";
            //resultLabel.Text = (firstTextBox.Text > secondTextBox.Text) ?  "Yes" : "No";

            //int first = int.Parse(firstTextBox.Text);
            //int second = int.Parse(secondTextBox.Text);
            //resultLabel.Text = (first > second) ? "yes" : "no";
            //resultLabel.Text = (first < second) ? "yes" : "no";
            //resultLabel.Text = (first >= second) ? "yes" : "no";
            //resultLabel.Text = (first <= second) ? "yes" : "no";

            //resultLabel.Text = (CheckBox1.Checked) ? "yes" : "no";

            //opposite of boolean - ! tests for not true
            //resultLabel.Text = (!CheckBox1.Checked) ? "no" : "yes";

            //logical 'And' and 'Or'
            //* && -And operator

            if (CheckBox1.Checked
                && firstTextBox.Text == "Usman"
                && secondTextBox.Text == "Tarfa")
            {
                resultLabel.Text = "Perfect trifecta!";
            }
            else
            {
                resultLabel.Text = "Wrong you idiot.";
            }

            /* 'OR'
             * || - Or operator
             *  if (CheckBox1.Checked
                || firstTextBox.Text == "Usman"
                || secondTextBox.Text == "Tarfa")
            {
                resultLabel.Text = "one out of three ain't bad.";
            }             
             */

            /*'And' and 'Or' 
             *  && - And operator 
             *  || - Or operator
             * 
             *  if (CheckBox1.Checked
                || firstTextBox.Text == "Usman"
                && secondTextBox.Text == "Tarfa")
           {
               resultLabel.Text = "two out of three ain't bad.";
           }             
            */

            /* && has presedence over ||
             * can be adjusted by adding perenthesis for your prefered condition
             
            if ((CheckBox1.Checked
               || firstTextBox.Text == "Usman")
               && secondTextBox.Text == "Tarfa")
               
            {
                resultLabel.Text = "two out of three ain't bad.";
            }
            */
        }

        protected void purchaseButton_Click(object sender, EventArgs e)
        {
            double total;

            if (smRadioButton.Checked)
            {
                total = 10.0;
            }
            else if (mdRadioButton2.Checked)
            {
                total = 12.0;
            }
            else if (lgRadioButton3.Checked)
            {
                total = 14.0;
            }
            else
            {
                total = 0.0;
            }


            if (dpdishRadioButton.Checked)
            {
                total = total + 2.0;

                /*or you can use
                 * total += 2.0;
                 */
            }

            total = (pepperoniCheckBox.Checked) ? total + 1.5 : total;
            total = (onionCheckBox.Checked) ? total + 0.75 : total;
            total = (gpeppersCheckBox.Checked) ? total + 0.50 : total;
            total = (redpeppersCheckBox.Checked) ? total + 0.75 : total;
            if (anchoviesCheckBox.Checked)
            {
                total = total + 2.0;
            }

            if ((pepperoniCheckBox.Checked
                && gpeppersCheckBox.Checked 
                && anchoviesCheckBox.Checked)
                || (pepperoniCheckBox.Checked
                && redpeppersCheckBox.Checked
                && onionCheckBox.Checked))
            {
                total = total - 2.0;
                /*or you can use
                 * total -= 2.0;
                 */
            }

            totalLabel.Text = "$ " + total.ToString();
        }

        protected void datetimeButton_Click(object sender, EventArgs e)
        {
            /*
             * how to format dates: using myValue.To____()
             */
            //DateTime myValue = DateTime.Now;
            //datetimeTextBox.Text = myValue.ToString();
            //datetimeTextBox.Text = myValue.ToLongDateString();
            //datetimeTextBox.Text = myValue.ToShortDateString();
            //datetimeTextBox.Text = myValue.ToShortTimeString();
            //datetimeTextBox.Text = myValue.ToLongTimeString();

            /*
             * how to perform math on dates 
             * Chaining - using multiple helper methods
             */
            //datetimeTextBox.Text = myValue.AddDays(2).ToString();
            //datetimeTextBox.Text = myValue.AddMonths(-2).ToString();


            /*
             * how to retrieve specific pieces of dates with 
             * different properties and helper methods
             */
            //datetimeTextBox.Text = myValue.Month.ToString();
            //datetimeTextBox.Text = myValue.IsDaylightSavingTime().ToString();
            //datetimeTextBox.Text = myValue.DayOfWeek.ToString();
            //datetimeTextBox.Text = myValue.DayOfYear.ToString();

            /*how to initialize a specific date to the past or future. 
             */
            //DateTime myValue = DateTime.Parse("02/01/1977");
            //datetimeTextBox.Text = myValue.ToLongDateString();
            // or



        }

        protected void spantimeButton_Click(object sender, EventArgs e)
        {
            //http://is.gd/timepan


            //how to create a new time span object
            //Days.Hours:Minutes:Seconds.Milliseconds
            //TimeSpan myTimeSpan = TimeSpan.Parse("1.2:3:30.5");

            DateTime myBirthday = DateTime.Parse("01/02/1977");

            TimeSpan myAge = DateTime.Now.Subtract(myBirthday);

            //timespanTextBox.Text = myAge.Hours.ToString();
            //timespanTextBox.Text = myAge.ToString();
            timespanTextBox.Text = myAge.TotalDays.ToString();
        }

        protected void getdateButton_Click(object sender, EventArgs e)
        {
            //calendarTextBox.Text = myCalendar.TodaysDate.ToString();
            calendarTextBox.Text = myCalendar.SelectedDate.ToShortDateString();
        }

        protected void setdateButton_Click(object sender, EventArgs e)
        {
            myCalendar.SelectedDate = DateTime.Parse("07/15/2016");
        }

        protected void showdateButton_Click(object sender, EventArgs e)
        {
            myCalendar.VisibleDate = DateTime.Parse("09/15/2016");
        }

        protected void selectweekButton_Click(object sender, EventArgs e)
        {
            calendarTextBox.Text = "Week of " + myCalendar.SelectedDate.ToShortDateString(); 
        }

        protected void myCalendar_SelectionChanged(object sender, EventArgs e)
        {
            calendarTextBox.Text = myCalendar.SelectedDate.ToShortDateString();
        }

        protected void challengeButton_Click(object sender, EventArgs e)
        {
            if (challengeCalendar.SelectedDate > challengeCalendar2.SelectedDate)
            {
                challengeTextBox.Text = challengeCalendar
                    .SelectedDate.Subtract(challengeCalendar2.SelectedDate)
                    .TotalDays.ToString();
            }
            else
            {
                challengeTextBox.Text = challengeCalendar2.SelectedDate
                    .Subtract(challengeCalendar.SelectedDate)
                    .TotalDays.ToString();
            }
        }
                      
    }
}