using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Polimorphism
{
    internal class Parallelogram:Geometric
    {
        public int A { get; set; }
        public int B { get; set; }
        public int H { get; set; }
        public Parallelogram(int A, int B, int H)
        {
            this.A = A;
            this.B = B;
            this.H = H;
        }
        public override double S() { return A * H; }
        public override double P() { return 2*(A + B); }
    }
}
