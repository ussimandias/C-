using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPApplications
{
    public partial class DataTypeConversion : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //if (!IsPostBack)
            //{
            //    firstNameTextBox.Text = string.Empty;
            //    lastNameTextBox.Text = string.Empty;
            //}
            
        }

        protected void submit_Button1_Click(object sender, EventArgs e)
        {
            //Lesson 1: Building your first Web App (Server Controls) -- Passing data from Backend to UI.
            string firstName = firstNameTextBox.Text;
            string lastName = lastNameTextBox.Text;
            string result;

            result = "Hello " + firstName + " " + lastName;

            resultLabel.Text = result;
            
        }

        protected void goButton1_Click(object sender, EventArgs e)
        {
            //Lesson 2: Data Conversion

            /*
            int i;
            i = "Hello World!";
            */

            /*int i;
            i = "3";
            */

            /*Upcasting:
            int i = 2000000000;
            long j = i;
            */

            /*
            long i = 200000000000;
            int j = i;
            */

            /*Downcasting
            long i = 200000000000;
            int j = (int)i;
            */

            //double k = 2.5;
            //int j = (int)k;

            /*          
            dataLabel.Text = j;
             */

            /*number to string does not work this way!
             dataLabel.Text = (string)j;
             */

            /*
             * Thanks for Helper Methods!! - use ToString() 
             */

            //dataLabel.Text = j.ToString();

            string i = dataTextBox.Text;
            //Casting does not working between categories of types -- Use Helper methods.
            int j = int.Parse(i);
            int k = j + 2;
            dataLabel.Text = k.ToString();

        }

        protected void mathButton_Click(object sender, EventArgs e)
        {
            /* = is an assingment operator
             * + - / * arithematic operators
             */
            int i = 1;
            int j = 2;
            //int result = i + j;
            //int result = i - j;
            //int result = i * j;
            //int result = i / j;

            /*addition assignment
             * i = i + 1;
             * i += 1;          
             */

            /*i = i + 5; this will be 6 
             * i += 4; this will be 5.
             */


            /* increment operator - only works with 1's
             * i++; this will be 2.
             */

            /* decrement operator - only works with 1's
             * i--; this will be 0.
             */

            /*beware of order precedence
             *  int myInteger = 5 + 1 * 7;
             *  int myInteger = (5 + 1) * 7;
             *  mathLabel.Text = myInteger.ToString();
             */

            /*
             * double myDouble = 5.5;
             * int myInteger = 7;
             * int myOtherInteger = 4;
             * double myResult = myDouble + myInteger;  --upcasting
             * int myResult = (int)myDouble + myInteger;  --downcasting
             * int myResult = myInteger / myOtherInteger; --loses precision 
             * double myResult = (double)myInteger / (double)myOtherInteger;
             * mathLabel.Text = myResult.ToString();
             */

            /*overflow and handling exceptions
             * int firstNumber = 200000000;
             * int secondNumber = 200000000;
             * long resultNumber;
             * //int resultNumber = firstNumber * secondNumber;
             * //mathLabel.Text = resultNumber.ToString();
             
            checked
              {
                resultNumber = firstNumber * secondNumber;
              }
            
            mathLabel.Text = resultNumber.ToString();
            */

        }

        protected void addButton_Click(object sender, EventArgs e)
        {
            string firstNum = firstValueTextBox.Text;
            string secondNum = secondValueTextBox.Text;
         
            int resultFormuler = int.Parse(firstNum) + int.Parse(secondNum); ;          
          
            resultTextBox.Text = resultFormuler.ToString();

        }

        protected void subtractButton_Click(object sender, EventArgs e)
        {
            int firstNum = int.Parse(firstValueTextBox.Text);
            int secondNum = int.Parse(secondValueTextBox.Text);   
            int resultFormuler = firstNum - secondNum; ;

            resultTextBox.Text = resultFormuler.ToString();

        }

        protected void multiplyButton_Click(object sender, EventArgs e)
        {
            string firstNum = firstValueTextBox.Text;
            string secondNum = secondValueTextBox.Text;
            
            int resultFormuler = int.Parse(firstNum) * int.Parse(secondNum);
            
            resultTextBox.Text = resultFormuler.ToString();
        }

        protected void divideButton_Click(object sender, EventArgs e)
        {
            double firstNum = double.Parse(firstValueTextBox.Text);
            double secondNum = double.Parse(secondValueTextBox.Text);
            double resultFormuler = firstNum / secondNum; ;
         
            resultTextBox.Text = resultFormuler.ToString();
        }

        protected void okConditionButton_Click(object sender, EventArgs e)
        {
            resultCondidtionTextBox.Text = "";

            /*
             * if (conditionTextBox.Text == secondConditionTextBox.Text)
            {
                resultCondidtionTextBox.Text = "Yes! They're equal... ";
            }
            else
            {
                resultCondidtionTextBox.Text = "No! They're not equal...";
            }

            if (coolCheckBox.Checked)
            {
                resultCondidtionTextBox.Text = "Yes you are definitely cool.";
            }
            else
            {
                resultCondidtionTextBox.Text = "Don't be so hard on yourself...";
            }
             */

            /*
             if (conditionTextBox.Text == secondConditionTextBox.Text)
            {
                resultCondidtionTextBox.Text = "Yes! They're equal... ";
            }
            else
            {
                resultCondidtionTextBox.Text = "No! They're not equal...";
            }

            if (coolCheckBox.Checked)
            {
                resultCondidtionTextBox.Text = "Yes you are definitely cool.";
            }
            else
            {
                resultCondidtionTextBox.Text = "Don't be so hard on yourself...";
            }
             */

            /*Radio buttons are selective
             * GroupName property in behavior should be given a name that matches all radio buttons. 
             * else if - evaluates mutually exclusively options
             * 
             *  if (pizzaRadioButton.Checked)
            {
                resultCondidtionTextBox.Text = "you must be from chicago";
            }
            else if (saladRadioButton2.Checked)
            {
                resultCondidtionTextBox.Text = "you must be healthy";
            }
            else if (pbjRadioButton3.Checked)
            {
                resultCondidtionTextBox.Text = "you must be a fun loving person";
            }
            else
            {
                resultCondidtionTextBox.Text = "Please select one of the options ";
            }
             */

            /*The conditional Ternary Operator
             * resultCondidtionTextBox.Text = (conditionTextBox.Text == secondConditionTextBox.Text) ? "Yes" : "No";
             *  resultCondidtionTextBox.Text = (coolCheckBox.Checked) ? "Yes i am" : "i am working on it";
             */
            resultCondidtionTextBox.Text = (conditionTextBox.Text == secondConditionTextBox.Text) ? "Yes" : "No";



        }

        protected void choiceButton_Click(object sender, EventArgs e)
        {
            choicePickLabel.Text = "";
            /*
            if (pencilRadioButton.Checked)
            {
                choicePickLabel.Text = "You selected Pencil";
                myImage.ImageUrl = "pen.jpg";
            }
            else if (pencilRadioButton.Checked)
            {
                choicePickLabel.Text = "You selected Pen";
            }
            else if (phoneRadioButton.Checked)
            {
                choicePickLabel.Text = "You selected Phone";
            }
            else if (tabletRadioButton.Checked)
            {
                choicePickLabel.Text = "You selected Tablet";
            }
            else
            {
                choicePickLabel.Text = "Please select an option!";
            }
            */

            if (pencilRadioButton.Checked)
            {
                myImage.ImageUrl = "/Images/pencil.jpg";
                choicePickLabel.Text = "You selected Pencil";
            }
            else if (penRadioButton.Checked)
            {
                myImage.ImageUrl = "/Images/pen.jpg";
                choicePickLabel.Text = "You selected Pen";
            }
            else if (phoneRadioButton.Checked)
            {
                myImage.ImageUrl = "/Images/phone.jpg";
                choicePickLabel.Text = "You selected Phone";
            }
            else if (tabletRadioButton.Checked)
            {
                myImage.ImageUrl = "/Images/tablet.jpg";
                choicePickLabel.Text = "You selected Tablet";
            }
            else
            {
                choicePickLabel.Text = "Please select an option!";
            }
        }

    }
}