using System;
using System.Collections.Generic;
using System.Text;

namespace Agents
{
    public class NPC : Agent
    {
        private Random rnd;
        private readonly string dirs;

        public NPC(string name) : base(name)
        {
            rnd = new Random();
            dirs = "NSWE";
        }

        public override char Move()
        {
            int i = rnd.Next(dirs.Length);

            return dirs[i];
        }

        public override string ToString() => $"I'm an NPC and my name is {Name}";
    }
}
