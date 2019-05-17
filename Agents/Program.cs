using System;

namespace Agents
{
    class Program
    {
        static void Main(string[] args)
        {
            Agent[] agents = new Agent[] 
            {
                new NPC("Yeetus"),
                new NPC("Vormetius, Destroyer of Memes"),
                new Player("Yeetangelo, Memus Maggitus")
            };
            // new Agent[] {  };

            foreach (Agent a in agents)
            {
                Console.WriteLine(a + " and my movement is " + a.Move());
                Console.ReadKey();
            }
        }
    }
}
