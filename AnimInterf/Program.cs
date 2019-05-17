using System;

namespace AnimInterf
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declarar Variáveis
            int numOfAnimals = 10;
            Random rnd;
            Animal[] animals = new Animal[numOfAnimals];

            Animal[] animalRaces = new Animal[]
            {
                new Cat(),
                new Dog(),
                new Bat(),
                new Bee()
            };

            for(int i = 0; i < animals.Length; i++)
            {
                animals[i] = Spawn();
            }

            foreach (Animal a in animals)
            {
                string sound = $"{a.Sound()}\n";
                string nipples = (a is IMammal) ? $"Number of Nipples = {(a as IMammal)}\n" : "";
                string wings = (a is ICanFly) ? $"Number of Wings = {a as ICanFly}\n" : "";
                Console.WriteLine($sound);

             }

            // Função de spawn
            Animal Spawn()
            {
                // Declarar Variáveis
                rnd = new Random();
                int result = rnd.Next(animalRaces.Length);
                return animalRaces[result];
            }
        }
    }
}
