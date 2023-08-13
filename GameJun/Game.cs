using GameJun.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameJun
{
    public class Game : AbstractGame
    {
        public override void SelectPlayers()
        {
            string classCharacter;
            Console.WriteLine($"Вам доступны классы: Archer, Melee");

            Console.Write($"Класс первого игрока: ");
            classCharacter = Console.ReadLine();
            if (classCharacter == "Archer") { player1 = new Archer(); }
            else if (classCharacter == "Melee") { player1 = new Melee(); }
            Console.WriteLine();
            Console.Write($"Класс второго игрока: ");
            classCharacter = Console.ReadLine();
            if (classCharacter == "Archer") { player2 = new Archer(); }
            else if (classCharacter == "Melee") { player2 = new Melee(); }
        }

        public override void Start()
        {
            if (!player1.IsAlive())
            {
                Console.WriteLine(player1.Name());
            }
            else
            {
                Console.WriteLine(player2.Name());
            }

            Random random = new Random();
            int a = random.Next(1, 3);
            if (a == 1)
            {
                firstStep = 1;
            }
            else if (a == 2)
            {
                firstStep = 2;
            }

            while (player1.IsAlive() && player2.IsAlive())
            {
                GameStep();
            }
            Console.WriteLine("\nИгра окончена!");
            if (!player1.IsAlive())
            {
                Console.WriteLine($"\nПобедил {player2.Name()}");
            }
            else if (!player2.IsAlive())
            {
                Console.WriteLine($"\nПобедил {player1.Name()}");
            }
        }

        protected override void GameStep()
        {
            if (firstStep == 1)
            {
                Console.WriteLine($"\n\n{player1.Name()} атакует первым!");
                player1.Attack(player2);
                Console.WriteLine($"{player2.Name()} наносит ответный удар!");
                player2.Attack(player1);
                Console.WriteLine($"\nХод окончен! Итоги хода:\n{player1.Name()}: {player1.Health} здоровья\n{player2.Name()}: {player2.Health} здоровья");
                firstStep++;
            }
            else
            {
                Console.WriteLine($"\n\n{player2.Name()} атакует первым!");
                player2.Attack(player1);
                Console.WriteLine($"{player1.Name()} наносит ответный удар!");
                player1.Attack(player2);
                Console.WriteLine($"\nХод окончен! Итоги хода:\n{player1.Name()}: {player1.Health} здоровья\n{player2.Name()}: {player2.Health} здоровья");
                firstStep--;
            }
        }
    }
}
