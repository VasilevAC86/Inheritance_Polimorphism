using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Polimorphism
{
    public class Rhombus : Geometric
    {
        public int D1 { get; set; }
        public int D2 { get; set; }
        public Rhombus(int D1, int D2)
        {
            this.D1 = D1;
            this.D2 = D2;
        }
        public override double S() { return D1 * D2 / 2; }
        public override double P() { return 2*Math.Sqrt(D1*D1 + D2*D2); }
    }
}
