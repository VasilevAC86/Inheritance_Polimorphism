using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooPark
{
    internal class Tiger: Animal
    {
        public Tiger():base("Тигр") { }
        public override void Speak()
        {
            Console.WriteLine("Тигр рычит");
        }
    }
}
