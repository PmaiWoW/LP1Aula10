using System;
using System.Collections.Generic;
using System.Text;

namespace AnimInterf
{
    public class Bee : Animal, ICanFly
    {
        public int NumberOfWings => 4;

        public override string Sound() => "bzzzzzzzzzz!";
    }
}
