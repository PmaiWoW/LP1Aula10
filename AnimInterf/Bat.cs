using System;
using System.Collections.Generic;
using System.Text;

namespace AnimInterf
{
    public class Bat : Animal, ICanFly, IMammal
    {
        public int NumberOfNipples => 2;

        public int NumberOfWings => 2;

        public override string Sound() => "screech!";
    }
}
