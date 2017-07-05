using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroMonster
{
    public class Character
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
