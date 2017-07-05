using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPApplications
{
    public partial class DevSheet6 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Returning values from Methods
            int heroHealth = 100;
            int monsterHealth = 100;

            //TODO: create method.
            displayBattleHeader();

            //Hero gets bonus first attack
            monsterHealth = performAttack(monsterHealth, 20, "Hero", "Monster");

            while (heroHealth > 0 && monsterHealth > 0)
            {
                //TODO: create method.
                displayRoundHeader();

                //Perform battle here!
                heroHealth = performAttack(heroHealth, 20, "Monster", "Hero");
                monsterHealth = performAttack(monsterHealth, 20, "Hero", "Monster");


            }

            //TODO: create method
            displayResult(heroHealth, monsterHealth );
        }

        private void displayBattleHeader()
        {
            //throw new NotImplementedException();
            resultLabel.Text += "<h3>Battle the Hero (you!) and the Monster</h3>";
        }

        private void displayRoundHeader()
        {
            //throw new NotImplementedException();
            resultLabel.Text += "<hr /><p>Round Begins...</p>";
        }

        Random random = new Random();
        //Helper Method:
        private int performAttack(int defenderHealth, int attackerDamageMax, string attackerName, string defenderName)
        {
            //Create an instance of a random class:
            //Random random = new Random();

            //to determine the damage
            int damage = random.Next(1, attackerDamageMax);
            defenderHealth -= damage;

            resultLabel.Text += "<hr /> <p style='color:red;'>ROLL: " + damage.ToString() + "</p>";

            describeRound(attackerName, defenderName, defenderHealth);
            return defenderHealth;
        }

        private void describeRound(string attackerName, string defenderName, int defenderHealth )
        {
            if (defenderHealth <= 0)
            {
                resultLabel.Text += string.Format("<br />{0} attacks {1} and vanquishes the {2} with {3}. ", attackerName, defenderName, defenderName, defenderHealth );
            }
            else
            {
                resultLabel.Text += string.Format("<br />{0} attacks {1} leaving {2} with {3} healing ", attackerName, defenderName, defenderName, defenderHealth);
            }
        }

        private void displayResult(int heroHealth, int monsterHealth)
        {
            //throw new NotImplementedException();
            if (heroHealth <= 0)
            {
                resultLabel.Text += "<h3>Monster wins!</h3>";
            }
            else if(monsterHealth <= 0)
            {
                resultLabel.Text += "<h3>Hero wins!</h3>";
            }
            else
            {
                    resultLabel.Text += "<h3>They are both losers!</h3>";
            }
        }

        protected void convertTextBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        protected void cupsRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            calculateCups();
            //calculateCups(1.0);
            //calculateCups(1.0, "Cups");
        }

        protected void pintsRadioButton_CheckedChanged(object sender, EventArgs e)
        {

            //if (convertTextBox.Text.Trim().Length == 0)
            //{
            //    return;
            //}

            //double quantity = 0.0;
            //if (!Double.TryParse(convertTextBox.Text, out quantity))
            //{
            //    return;
            //}

            //double cups = quantity * 2.0;
            //resultTextBox.Text = "The number of cups: " + cups.ToString();

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

        private void calculateCups()
        {
            if (convertTextBox.Text.Trim().Length == 0)
            {
                return;
            }

            double quantity = 0.0;
            if (!Double.TryParse(convertTextBox.Text, out quantity))
            {
                return;
            }

            double cups = 0.0;

            if (cupsRadioButton.Checked) cups = quantity;
            else if (pintsRadioButton.Checked) cups = quantity * 2;
            else if (quartsRadioButton.Checked) cups = quantity * 4;
            else if (gallonsRadioButton.Checked) cups = quantity * 16;
            else return;

            resultTextBox.Text = "The number of cups: " + cups.ToString();
        }

        private void calculateCups(double measureToCupRatio)
        {
            if (convertTextBox.Text.Trim().Length == 0)
            {
                return;
            }

            double quantity = 0.0;
            if (!Double.TryParse(convertTextBox.Text, out quantity))
            {
                return;
            }

            double cups = quantity * measureToCupRatio;


            resultTextBox.Text = "The number of cups: " + cups.ToString();
        }

        private void calculateCups(double measureToCupRatio, string measureName)
        {
            if (convertTextBox.Text.Trim().Length == 0)
            {
                return;
            }

            double quantity = 0.0;
            if (!Double.TryParse(convertTextBox.Text, out quantity))
            {
                return;
            }

            double cups = quantity * measureToCupRatio;


            resultTextBox.Text = string.Format("{0:N} {1} is equal {2:N2} cups: ", quantity, measureName, cups);
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
         * will be usd
         *
         *private void myMethod(string myRequiredParam, int myOptionalParam -1, int myOtherOptionalParam = 5); 
         * 
         *Can be called ...
         * myMethod("Hello Required Param!");
         * 
         * or ...
         * 
         * myMethod("Hello Required Param!", 100);
         * 
         * or
         * 
         * myMethod("Hello Required Param!", 100, 500);
         * 
         * you cannot skip an optional parameter:
         * 
         * myMethod("Hello Required Param!", , 500); -- ERROR!!
         * 
         */

        /*
         * Passing Named arguments into input Parameters
         * **********************************************
         * Allows us to send in parameter arguments OUT OF ORDER!
         * We  just prefix the the input parameter argument with the name
         * of the parameter we're passing in, a colon, then the value:
         * 
         * myMethod(myOtherOptionalParam: 500, myRequiredParam: "Hello Required Param", myOptionalParam: 100);
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
         * private bool myMethod(string myRequiredParam, out int myOptionalParam){}
         * 
         * int myValue = 0;
         * if(myMethod("some required text", out value)){return "Hello World"};
         */
    }
}