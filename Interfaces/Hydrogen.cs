using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    public class Hydrogen : IFuel
    {
        public float Efficiency => 12.3f;

        public void Burn()
        {
            Console.WriteLine("Hydrogen is burning!");
        }
    }
}
