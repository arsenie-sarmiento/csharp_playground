using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DelegatesAndEvents;

namespace DelegatesAndEvents
{
    class Program
    {
        static void Main()
        {
            Game game = new Game(5);

            game.Start();
            
            game.GoalReached += (OnGoalReached);

            Console.ReadKey();
        }

        static void OnGoalReached(int moves)
        {
            Console.WriteLine($"Congrats! Goal reached with {moves} moves!");

        }
    }
}
