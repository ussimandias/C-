using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPApplications
{
    public partial class ChallengeHeroMonsterClassesPart2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Character hero = new Character();
            hero.Name = "Voltron";
            hero.Health = 35;
            hero.DamageMaximum = 20;
            hero.AttackBonus = false;

            Character monster = new Character();
            monster.Name = "Beast";
            monster.Health = 21;
            monster.DamageMaximum = 25;
            monster.AttackBonus = false;

            Dice shootingDice = new Dice();

            //bonus
            if (hero.AttackBonus)
                monster.Defend(hero.Attack(shootingDice));
            if (monster.AttackBonus)
                hero.Defend(monster.Attack(shootingDice));

            while (hero.Health > 0 && monster.Health > 0)
            {
                monster.Defend(hero.Attack(shootingDice));
                hero.Defend(monster.Attack(shootingDice));

                printResults(hero);
                printResults(monster);
            }

            displayResults(hero, monster);
        }

        private void displayResults(Character opponent1, Character opponent2)
        {
            if (opponent1.Health <= 0 && opponent2.Health <= 0)
            {
                resultLabel.Text += string.Format("Both {0} and {1} died", opponent1.Name, opponent2.Name);
            }
            else if (opponent1.Health <= 0)
            {
                resultLabel.Text += string.Format("opponent2 {0} defeated {1} opponent1", opponent2.Name, opponent1.Name);
            }
            else
            {
                resultLabel.Text += string.Format("opponent1 {0} defeated {1} opponent2", opponent1.Name, opponent2.Name);
            }
        }

        private void printResults(Character character)
        {
            resultLabel.Text += string.Format("<p>Name: {0} <br/> Health: {1} <br/> DamageMaximum: {2} </p>",
                character.Name,
                character.Health,
                character.DamageMaximum);
        }

        class Character
        {
            public string Name { get; set; }
            public int Health { get; set; }
            public int DamageMaximum { get; set; }
            public bool AttackBonus { get; set; }

            public int Attack( Dice myDiceRolled)
            {
                myDiceRolled.Sides = this.DamageMaximum;
                return myDiceRolled.Roll();
            }

            public void Defend(int damage)
            {
                this.Health -= damage;
            }
        }

        class Dice
        {
            public int Sides { get; set; }

            //Create instance of Random class
            Random randomHit = new Random();
            public int Roll()
            {
                //use the sides property as maximum value
                //used by the Random.next()
                //int diceCasted = randomHit.Next(Sides);
                //return diceCasted; 

                return randomHit.Next(this.Sides);
            }
        }

    }

}