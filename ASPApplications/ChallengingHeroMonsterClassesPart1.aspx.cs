using HeroMonster;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPApplications
{
    public partial class ChallengingHeroMonsterClassesPart1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Character hero = new Character();
            hero.Name = "Voltron";
            hero.Health = 10;
            hero.DamageMaximum = 8;
            //hero.AttackBonus = false;

            Character monster = new Character();
            monster.Name = "Beast";
            monster.Health = 10;
            monster.DamageMaximum = 9;
            //monster.AttackBonus = false;

            //The hero damage inflicted is based on the Attack()
            int heroDamage = hero.Attack();
            //Hero attackS and Monster Defends
            monster.Defend(heroDamage);

            //The monster damage inflicted is based on the Attack()
            int monsterDamage = monster.Attack();
            //Monster attackS and Hero Defends
            hero.Defend(monsterDamage);

            printResults(hero);
            printResults(monster);
        }



        private void printResults(Character character)
        {
            resultLabel.Text += string.Format("<p>Name: {0} <br/> Health: {1} <br/> DamageMaximum: {2} </p>", 
                character.Name, 
                character.Health, 
                character.DamageMaximum);       
        }
    }

    /*****************************************************
     * 
     * Character class library created as HeroMonster dll
     * 
     * ****************************************************/
    class Character
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public int DamageMaximum { get; set; }
        //public bool AttackBonus { get; set; }

        public int Attack()
        {
            //return int
            //use Random Class

            Random random = new Random();
            int damagedealth = random.Next(this.DamageMaximum);
            return damagedealth;

        }

        public void Defend(int damage)
        {
            //subtract damage from health
            //Health = Health - damage;
            this.Health -= damage;
        }

        }
    }