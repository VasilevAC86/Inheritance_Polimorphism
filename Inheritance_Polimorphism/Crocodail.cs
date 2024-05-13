using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooPark
{
    internal class Crocodail:Animal
    {
        public Crocodail() : base("Крокодил") { }
        public override void Speak()
        {
            Console.WriteLine("Крокодил прячется");
        }
    }
}
