using System;

namespace MyGame
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declarar variáveis
            int numEnemies;
            Enemy[] enemies; 
            Random random = new Random();

            //Quantos inimigos o utilizador quer
            Console.WriteLine("How many enemies?");
            numEnemies = Int32.Parse(Console.ReadLine());

            //Cada inimigo, cada nome dado
            //Criar objecto inimigoe guardá-lo num array
            enemies = new Enemy[numEnemies];

            for (int i = 0; i < numEnemies; i++)
            {
                string name;
                Console.Write("Escreva un nome: ");
                name = Console.ReadLine();
                enemies[i] = new Enemy(name);

                if(random.NextDouble() < 0.5)
                {
                    enemies[i].PickupPowerUp(PowerUp.Shield, 50);
                    Console.WriteLine("Apanhou o powerup");
                }
                else
                {
                    enemies[i].TakeDamage(random.Next(100));
                    Console.WriteLine("AUps! levou dano");
                }
            }

            //Para cada inimigo, impimir seu nome
            foreach (Enemy enemy in enemies)
            {
                Console.WriteLine(enemy.GetName());
                Console.WriteLine(enemy.GetHealth());
                Console.WriteLine(enemy.GetShield());
            }

            Console.WriteLine(Enemy.GetPowerupCount());
        }
    }
}
