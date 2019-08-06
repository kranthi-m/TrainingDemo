using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiers
{
    class Class1
    {
        public void Test()
        {
            Details obj = new Details();
            obj.age = 50; //age is accessible as its internal..accessed in current project level
            obj.sal = 300000;

            
        }
    }
}
