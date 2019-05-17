using System;
using System.Collections.Generic;
using System.Text;

namespace Agents
{
    public class Player : Agent
    {
        public Player(string name) : base(name)
        {

        }

        public override char Move()
        {
            char input;

            Console.WriteLine("What direction will you move to?\n" +
                "N, S, W, E?");

            input = Console.ReadLine().ToUpper()[0];

            // Longer code 
            // input = Convert.ToChar(Console.ReadLine().ToUpper());

            if (input == 'N' || input == 'S' || input == 'W' || input == 'E')
                return input;
            else return '?';
        }

        public override string ToString()
        {
            return $"I'm a Player and my name is {Name}";
        }
    }
}
