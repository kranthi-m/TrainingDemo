using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleInheritance
{
    class Program : Math1, Math2 // multiple inheritance by using interfaces
    {
        public void Add()
        {
            Console.WriteLine("add called");
        }
        public void Sub()
        {

            Console.WriteLine("sub called");
        }
        public void Mul()
        {
            Console.WriteLine("Mul called");
        }
        public void Div()
        {

            Console.WriteLine("Div called");
        }
        static void Main(string[] args)
        {
            Program obj = new Program();
            obj.Add();
            obj.Sub();
            obj.Mul();
            obj.Div();
            Console.ReadLine();
        }
    }


    interface Math1 //like contract.. will have only method definations, no implemenation
    {
        void Add();
        void Sub();
    }
    interface Math2 //like contract.. will have only method definations, no implemenation
    {
        void Mul();
        void Div();
    }
}
