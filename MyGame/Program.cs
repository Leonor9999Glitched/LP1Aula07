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
            }

            //Para cada inimigo, impimir seu nome
            foreach (Enemy enemy in enemies)
            {
                Console.WriteLine(enemy.GetName());
            }
        }
    }
}
