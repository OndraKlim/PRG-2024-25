using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tridy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player(100,10,"Ignác");
            Enemy enemy = new Enemy(20,2,1);

            while (!player.IsDead() && !enemy.IsDead())
            {
                if (!player.IsDead())
                {
                    enemy.Hurt(player.GetRandomDamage()); //Utok hrace na enemy
                }
                if (!enemy.IsDead())
                {
                    player.Hurt(enemy.GetRandomDamage()); //Utok enemy na hrace
                }
            }

            Console.WriteLine("Player's health " + player.GetHealth()); //Vypis zdravi hrace
            Console.WriteLine("Enemy's health " + enemy.GetHealth()); //Vypis zdravi enemy


            Console.ReadKey();
        }
    }
}
