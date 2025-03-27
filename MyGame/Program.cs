using System;

namespace MyGame
{
    public class Program
    {
        private static void Main(string[] args)
        {
       

            Enemy[] inimigos = new Enemy[int.Parse(args[0])];

            for (int i = 0; i < int.Parse(args[0]); i++)
            {
                Console.Write($"Nome do inimigo {i + 1}: ");
                string name = Console.ReadLine();
                inimigos[i] = new Enemy(name);
            }

            foreach (var inimigo in inimigos)
            {
                Console.WriteLine($"{inimigo.GetName()} {inimigo.GetHealth()} {inimigo.GetShield()}");
            }
        }
    }
}
