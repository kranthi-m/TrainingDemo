using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism // behave in multi ways..
{
    //1. Compile Time --Overloading Methods
    //2. Run Time --Virtual/Overide ( Inheritance)

        /// <summary>
        /// Encapsulation : Achieve by using Access Modifiers like Private, Protected, Internal, Protected Internal, Public
        /// </summary>
     internal class Program : Math
     {
        private int a;
        public override void Sum()
        {
             Console.WriteLine("Sum method with no param-Program class");
        }
        //Add Method behave as Compile Time Polymorphism with single, two and no parameters
        public void Add(int a)  
        {
            Console.WriteLine("single param" + a);
        }
        public void Add(int a, int b, int c)
        {
            Console.WriteLine("single param" + a);
        }
        public void Add(int a, int b)
        {
            Console.WriteLine("two param" + a + b);
        }
        public void Add()
        {
            Console.WriteLine("no param");
        }
       
        static void Main(string[] args)
        {
            Program pg = new Program();
            pg.Add(); //
            pg.Add(10, 20);
             pg.Add(2,2,3);
            Console.ReadLine();

            Math objMath = new Math();
            objMath.Sum(); // printing  the parent method
            Math objMat = new Program();
            objMat.Sum(); // print /call the child method..hiding the parent class method-> Method hiding

            pg.Sum(); // child class method

            //=============
            //Employee objemp = new Employee { Id = 100, Name = "Raj", Address = "Hyderabad" };
            //Employee objemp1 = new Employee { Id = 101, Name = "Ravi", Address = "Hyderabad" };
            //Employee objemp2= new Employee { Id = 102, Name = "Rahul", Address = "Goa" };
            //List<Employee> liemp = new List<Employee>();
            //liemp.Add(objemp);
            //liemp.Add(objemp1);
            //liemp.Add(objemp2);
            ////var vlist = liemp.OrderBy(x => x.Name).ThenBy(x => x.Address).Where(x =>x.Address.Equals("Hyderabad")).Select(x => new {x.Name, x.Address }).ToList();
            ////    var vlist = liemp.GroupBy(m =>m.Address).OrderBy(k => k.OrderBy(m => m.Name)).ThenBy(k => k.OrderBy(m => m.Address)).Select(x => new {id= x.Key,qty=x.ToList() }).ToList();
            //var vlist = liemp.GroupBy(m => m.Address, m => m.Name, (key, p) => new { addr = key, namelist = p.ToList() }).OrderBy(k => k.addr).ThenBy(k => k.namelist);
            //var filtervlist = vlist.Where(x => x.addr.Equals("Hyderabad")).ToList();
            
            //foreach (var item in filtervlist)
            //{
            //    Console.WriteLine(item.addr);
            //    foreach (var pname in item.namelist)
            //    {
            //        Console.WriteLine(pname);

            //    }
            //}
            //Console.ReadLine();


            //        var results = liemp.GroupBy(
            //p => p.Name,
            //p => p.Address,
            //(key, g) => new { name = key, addr = g.ToList() });


            Program obj = new Program();
            obj.Add();
            obj.Add(5);
            obj.Add(5,10);

            obj.Sum();

            Math objt = new Math();
            objt.Sum();


            Console.ReadLine();
        }
    }

    class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string Address { get; set; }
    }
    
    class Math
    {
        public virtual void Sum()
        {
            Console.WriteLine("Sum method with no param- Math class");
        }

    }
}
