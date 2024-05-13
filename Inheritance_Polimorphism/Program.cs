using Inheritance_Polimorphism;
using System.Globalization;
using System.Numerics;
using System.Runtime.ConstrainedExecution;
using ZooPark;

namespace Inheritance_Polimorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Tiger tiger = new Tiger();
            tiger.Name = "Вася";
            Crocodail crocodail = new Crocodail();
            crocodail.Name = "Петя";
            Kangaroo kangaroo = new Kangaroo();
            kangaroo.Name = "Женя";
            Console.Write("Тигр: " + tiger.Name + ", ");
            tiger.Speak();
            Console.Write("Крокодил: " + crocodail.Name + ", ");
            crocodail.Speak();
            Console.Write("Кенгуру: " + kangaroo.Name + ", ");
            kangaroo.Speak();

            International ip = new International();
            ip.Name = "Vasia";
            ip.Type = "International passport";
            ip.Number = 1111111;
            ip.Visa = 2222;
            ip.Country = "Russia";

            Passport p = new Passport();
            p.Name = "Вася";
            p.Number = 11111111;
            p.Country = "Россия";
            p.Type = "Внутренний паспорт";

            Console.WriteLine("Внутренний паспорт: ");
            Console.WriteLine(p.Name + ", " + p.Number + ", " + p.Country + ", " + p.Type);
            Console.WriteLine();
            Console.WriteLine("Заграничный паспорт: ");
            Console.WriteLine(ip.Name + ", " + ip.Number + ", " + ip.Country + ", " + ip.Type + ", " + ip.Visa);
        }
    }
    public abstract class CDA
    {
        protected CDA() { }
        public abstract void B(int x); // Абстрактные методы могут быть только в абстрактном классе
    }
    public class ABC // Чтобы запретить наследование от класса ABC надо написать слово sealed перед словом class
    {
        public ABC() { }
        public virtual void A()
        {

        }
    }
    public class BCA : ABC // Класс BCA наследуется от класса ABC
    {
        public BCA() : base() { } // Конструктор наследуется от базового
    }   
       
}
