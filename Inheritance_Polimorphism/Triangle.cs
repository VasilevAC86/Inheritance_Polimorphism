using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Polimorphism
{
    public class Triangle : Geometric // Класс-наслдение "Треугольник"
    {
        public int A { get; set; }
        public int B { get; set; }
        public int C { get; set; }
        public Triangle(int A, int B, int C)
        {
            this.A = A;
            this.B = B;
            this.C = C;
        }
        public override double S() { return A * B * C; }
        public override double P() { return A + B + C; }
    }
}
