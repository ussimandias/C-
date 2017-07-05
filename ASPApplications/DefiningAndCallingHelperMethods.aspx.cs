using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPApplications
{
    public partial class DefiningAndCallingHelperMethods : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void convertTextBox_TextChanged(object sender, EventArgs e)
        {
            //calculateCups();
        }

        protected void cupsRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            calculateCups();
            //calculateCups(1.0);
            //calculateCups(1.0, "Cups");
        }

        protected void pintsRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            //calculateCups();
            calculateCups(2.0);
            //calculateCups(2.0, "Pints");
        }

        protected void quartsRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            //calculateCups();
            //calculateCups(4.0);
            calculateCups(4.0, "Quarts");
        }

        protected void gallonsRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            //calculateCups();
            //calculateCups(16.0);
            calculateCups(16.0, "Gallons");
        }

        //Helper Methods: Does not return anything 
        private void calculateCups()
        {
            if (convertTextBox.Text.Trim().Length == 0)
                return;

            double quantity = 0.0;
            if (!Double.TryParse(convertTextBox.Text, out quantity))
                return;

            double cups = 0.0;
            if (cupsRadioButton.Checked) cups = quantity;
            else if (pintsRadioButton.Checked) cups = quantity * 2;
            else if (quartsRadioButton.Checked) cups = quantity * 4;
            else if (gallonsRadioButton.Checked) cups = quantity * 16;
            else return;

            resultTextBox.Text = "The number of cups: " + cups.ToString();
        }

        //Helper Methods: Creating methods with single Input Parameters
        private void calculateCups(double measureToCupRatio)
        {
            if (convertTextBox.Text.Trim().Length == 0)            
                return;
            
            double quantity = 0.0;
            if (!Double.TryParse(convertTextBox.Text, out quantity))            
                return;
            
            double cups = quantity * measureToCupRatio;

            resultTextBox.Text = "The number of cups: " + cups.ToString();
        }

        //Helper Methods: Creating methods with more than one Input Parameters
        private void calculateCups(double measureToCupRatio, string measureName)
        {
            if (convertTextBox.Text.Trim().Length == 0)           
                return;
            
            double quantity = 0.0;
            if (!Double.TryParse(convertTextBox.Text, out quantity))           
                return;
            
            double cups = quantity * measureToCupRatio;

            resultTextBox.Text = string.Format("{0:N2} {1} is equal {2:N2} cups: ", quantity, measureName, cups);
        }

        /*
         * Creating overloaded methods
         * ****************************
         * Different method signature but same basic function.
         * METHOD SIGNATURE ... the number and types of parameters
         * Can have different return types.
         */

        /*
         * Creating Optional Parameters
         * **************************** 
         * Optonal parameters provide default values when you define
         * the method. so if you don't supply a value, the default 
         * will be used
         *
         *      private void myMethod(string myRequiredParam, int myOptionalParam -1, int myOtherOptionalParam = 5); 
         * 
         *Can be called ...
         * 
         *      myMethod("Hello Required Param!");
         * 
         * or ...
         * 
         *      myMethod("Hello Required Param!", 100);
         * 
         * or
         * 
         *      myMethod("Hello Required Param!", 100, 500);
         * 
         * you cannot skip an optional parameter:
         * 
         *      myMethod("Hello Required Param!", , 500); -- ERROR!!
         * 
         */

        /*
         * Passing Named arguments into input Parameters
         * **********************************************
         * Allows us to send in parameter arguments OUT OF ORDER!
         * We  just prefix the the input parameter argument with the name
         * of the parameter we're passing in, a colon, then the value:
         * 
         *      myMethod(myOtherOptionalParam: 500, myRequiredParam: "Hello Required Param", myOptionalParam: 100);
         * 
         * you still have to pass in REQUIRED param
         * 
         */

        /*
         * Creating Methods with Output Parameters
         * ****************************************
         * Allow you to return a value the normal way AND
         * return a value via a method parameter:
         * 
         *      private bool myMethod(string myRequiredParam, out int myOptionalParam){}
         * 
         *      int myValue = 0;
         *      if(myMethod("some required text", out value))
         *      {return "Hello World"};
         */
    }
}