using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooPark
{
    internal class Kangaroo:Animal
    {
        public Kangaroo() : base("Кенгуру") { }
        public override void Speak()
        {
            Console.WriteLine("Кенгуру прыгает");
        }
    }
}
