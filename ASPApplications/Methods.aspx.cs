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
            resultLabel.Text += "<h3>Battle the Hero (you!) and the Monster</h3>";
        }

        private void displayRoundHeader()
        {          
            resultLabel.Text += "<hr/><p>Round Begins...</p>";
        }

        Random random = new Random();
        //Helper Method: Returning Values from Methods
        private int performAttack(int defenderHealth, int attackerDamageMax, string attackerName, string defenderName)
        {
            //Create an instance of a random class:
            //Random random = new Random();

            //to determine the damage
            int damage = random.Next(1, attackerDamageMax);
            defenderHealth -= damage;

            resultLabel.Text += "<hr /> <p style='color:red;'>ROLL: " + damage.ToString() + "</p>";

            //Yes!! Calling a Helper Method in another Helper Method is possible! 
            describeRound(attackerName, defenderName, defenderHealth);

            return defenderHealth;
        }

        private void describeRound(string attackerName, string defenderName, int defenderHealth )
        {
            if (defenderHealth <= 0)            
                resultLabel.Text += string.Format("<br />{0} attacks {1} and vanquishes the {2} with {3}. ", attackerName, defenderName, defenderName, defenderHealth );           
            else           
                resultLabel.Text += string.Format("<br />{0} attacks {1} leaving {2} with {3} health. ", attackerName, defenderName, defenderName, defenderHealth);           
        }

        private void displayResult(int heroHealth, int monsterHealth)
        {           
            if (heroHealth <= 0)           
                resultLabel.Text += "<h3>Monster wins!</h3>";           
            else if(monsterHealth <= 0)           
                resultLabel.Text += "<h3>Hero wins!</h3>";            
            else
                resultLabel.Text += "<h3>They are both losers!</h3>";          
        }    
    }
}