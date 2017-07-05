using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPApplications
{
    public partial class DevSheet3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Page.MaintainScrollPositionOnPostBack = true;

            /*
             * Page load will execute prior to the okButton event
             * Therefore resetting the values of the controls
             * to its own values.
             */


            //if the page is only reloading then execute "if" condition
            if (!Page.IsPostBack)
            {
                TextBox.Text = "Some Value";
                // myCalendar.SelectedDate = DateTime.Parse("07/17/2016");
                myCalendar.SelectedDate = DateTime.Now.Date.AddDays(2);
            }


            //Challenge solution from line 31-39
            //Business Rule 1:
           // spyImage.ImageUrl = "epicspies.jpg";
            /*
             * DateTime startDate = DateTime.Today.AddDays(22);
             * spyCalendar2.SelectedDate = startDate;
             * 
             *              "OR"
             */
            if (!Page.IsPostBack)
            {
                spyCalendar.SelectedDate = DateTime.Now.Date;
                spyCalendar2.SelectedDate = DateTime.Now.Date.AddDays(14);
                spyCalendar3.SelectedDate = DateTime.Now.Date.AddDays(21);

            }
           

        }

        protected void okButton_Click(object sender, EventArgs e)
        {
            resultTextBox.Text = TextBox.Text + " - " 
                + myCalendar.SelectedDate.ToShortDateString();
        }

        protected void submitButton_Click(object sender, EventArgs e)
        {
            //string result = string.Format("Thank you {0}, for your business.", nameTextBox.Text );
            //string result = string.Format("Thank you {0}, for your business. Your Social Security number is: {1}", nameTextBox.Text, sssTextBox.Text );

            /*
             * concenate strings: + +=
             * To format sss # convert string to an int
             * then format placehoder to indicate the pattern :{1:000-00-0000} 
             */
            int socialSecurity;
            socialSecurity = int.Parse(sssTextBox.Text);
            //string result = string.Format("Thank you {0}, for your business.Your Social Security number is: {1:000-00-0000}", nameTextBox.Text, socialSecurity);

            /*
             * string formats: format specifiers
             * https://is.gd/formattingdates 
             */
            int phone = int.Parse(phnumberTextBox.Text);

            //string result = string.Format("Thank you {0}, for your business." +
            //    "Your Social Security number is: {1:000-00-0000}. " +
            //    "Phone: {2: (000) 000-0000}. " +
            //    "Loan Date: {3:ddd --d, M, yy} ",
            //    nameTextBox.Text,
            //    socialSecurity,
            //    phone,
            //    loanCalendar.SelectedDate);


            /*
             * Currency format
             * http://is.gd/formattingcurrency/
             */
            double salary = double.Parse(salaryTextBox.Text);

            string result = string.Format("Thank you {0} for your business." +
                "Your Social Security number is: {1:000-00-0000}. " +
                "Phone: {2: (000) 000-0000}. " +
                "Loan Date: {3:ddd --d, M, yy}. " +
                "Salary: {4:c}",
                nameTextBox.Text,
                socialSecurity,
                phone,
                loanCalendar.SelectedDate,
                salary);

            loanResultTextBox.Text = result;
        }

        protected void spyButton_Click(object sender, EventArgs e)
        {
            double totalcost;
                      
            //Business Rule: 3
            //spies cost 500 per day
            TimeSpan elaspedDays = spyCalendar2.SelectedDate.Subtract(spyCalendar3.SelectedDate);
            totalcost = elaspedDays.TotalDays * 500.0;

            //Business Rule: 4
            //if assignment period is greater than 3 weeks 
            //add an additional $1000
            //if > 21 days then add 1000
            if (elaspedDays.TotalDays > 21)
            {
                totalcost += 1000.0;
            }

            spyresultTextBox.Text = string.Format("Assignment of {0} to classified operation code name: {1} is authorised. Budget total: {2:c} ",
                   codenameTextBox.Text,
                   newnameTextBox.Text,
                   totalcost);

            //Business Rule 2:
            //if assignment period is less than 14days between assignments then decline
            TimeSpan timeBetweenAssignments = spyCalendar2.SelectedDate.Subtract(spyCalendar.SelectedDate);
            if (timeBetweenAssignments.TotalDays < 14)
            {
                spyresultTextBox.Text = "Error must Allow 2 weeks between previous assignment and new assignment";

                //and reset the calender date to the next possible start date
                DateTime earliestNewAssignmentDate = spyCalendar.SelectedDate.AddDays(14);
                spyCalendar2.SelectedDate = earliestNewAssignmentDate;
                spyCalendar2.VisibleDate = earliestNewAssignmentDate;
            }
        }
    }
}