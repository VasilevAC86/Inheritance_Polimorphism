using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Xml.Linq;

namespace Inheritance_Polimorphism
{
    internal class International: Passport
    {
        public International():base() { }
        public int Visa { get; set; }
    }
}
