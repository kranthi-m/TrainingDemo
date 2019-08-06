using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiers  // Encapsulation - container...we will achieve Encapsulation with help of AccessModifiers
{
    /*
     * 1. Private (with in method/class..specified block : can not access outside block)
     * 2.Protected (with in block, but also access in inherited class)
     * 3.Internal (acccess with in project..)
     * 4. Protected Internal (with in project and access in another proj of inherited class)
     * 5. Public ( access every where)
     * */

    class Program : Details// internal class program
    {
    //   private int a;
        static void Main(string[] args)
        {
            Program pg = new Program();
            pg.address = "hyd"; // protected var access by child objs
            Details obj = new Details();
            obj.sal = 200;
            obj.age = 10; //age is accessible as its mentioned internal..its project lvl scope
                          // obj.name = "raj"; //name is not accessible since it is private
                          // obj.address = "hyd"; // can not access as its protected

            Program objp = new Program();
            objp.address = "chennai";
            objp.age = 30;
         
        }
    }
  
    class Details // internal - within project
    {
        private int Salry = 10000;
         string name; // private 
        internal int age; // project level
        protected string address; // this and its child
        public int sal;
        protected internal int id;
        public void Info1()
        {
            Salry = 2000;
            
            name = "test";
            age = 30;
            sal = 20000; 
        }
            public void Info()
        {          
            Details obj = new Details();
            obj.age = 20;
            obj.address = "delhi";
            Console.WriteLine("Parent address is " + obj.address);
        }
       
    }

    class DChild : Details  //single level inheritance..Derived Class : Parent Class
    {
        public void ChildInfo()
        {
            Details obj = new Details();
            obj.age = 20;

            DChild objc = new DChild(); //can access protected variables using child/dericed class object
            objc.address = "pune";
            Console.WriteLine("child address is " + objc.address);
        }

    }
    
}
