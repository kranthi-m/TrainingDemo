using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{

    //Inheritance, Polymorphism, Encapsulation and Abstraction
    //abstract class - Base Class ..can not have obj , only inherit the class and extend and have obj to child class..
     class Program : Math
    {
        private int i;
        public override void Add()  //new will hide , override will overide the parent method
        {  int j;
        Console.WriteLine("add method implemented");
        }
        public void Mul()
        {
            Console.WriteLine("mul method implemented");
        }
      public  static void Main(string[] args)
        {
            // Math objM = new Math();  //can not create obj as Math is abstract class
            Program obj = new Program();
            obj.Add();
            obj.Sub();
            obj.Mul();

            Console.ReadLine();
        }
    }

  abstract  class Math //can have method definitions, implementation and both..
    {
        public abstract void Add();// declaration, no implemenation        
        //definitions with abstract keyword , abstract method as default virtual

        public void Sub()  //implemented method
        {
            Console.WriteLine("abstract Sub called");
        }
    }
}
