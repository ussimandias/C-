using HeroMonster;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Windows_CS_ASP_41
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       private void Form1_Load(object sender, EventArgs e)
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
            resultLabel.Text += string.Format("\r\nName: {0} ** Health: {1} ** DamageMaximum: {2} ",
                character.Name,
                character.Health,
                character.DamageMaximum);
        }
    }
    
}
