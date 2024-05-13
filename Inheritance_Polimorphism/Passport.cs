using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Polimorphism
{
    internal class Passport
    {
        public string Name { get; set; }
        public int Number {  get; set; }
        public string Country { get; set; }
        public Passport() 
        { 
            
        }
        public string Type { get; set; }
    }
}
