using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Tridy
{
    internal class Enemy
    {
        int healthBase;
        int health;
        int damageBase;
        int damage;
        private Random rng;
        int level;

        public Enemy (int healthBase, int damageBase, int level)
        {
            this.healthBase = healthBase;
            health = this.healthBase * level;

            this.damageBase = damageBase;
            damage = damageBase * level;

            this.level = level;
            rng = new Random();

        }

        public void Hurt(int amount)
        {
            health -= amount;
            Console.WriteLine("Enemy got hit for " + amount + " damage");

            if (health <= 0) { Console.WriteLine("Enemy is dead"); }
        }

        public int GetHealth() { return health; }
        public int GetDamage() { return damageBase; }
        public int GetRandomDamage()
        {
            return rng.Next(damageBase / 2, damageBase + 1); 
        }
        public bool IsDead() { return health <= 0; }


    }
}
