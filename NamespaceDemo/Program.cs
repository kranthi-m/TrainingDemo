using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using SavingAc;
//using CurrentAc;
namespace NamespaceDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Customer obj = new Customer();
            //obj.SavingAc();
            SavingAc.Customer obj = new SavingAc.Customer();
            obj.SavingAc();

            CurrentAc.Customer objs = new CurrentAc.Customer();
            objs.CurrentAc();

            Console.ReadLine();
        }
    }
}
