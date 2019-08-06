using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{ // Generics and Non Generic (old) Collections
    /// <summary>
    /// Non Generic - Array, stack, queue, hashtable (key, value) - mostly run time issues - not strongly typed -- not particular data type
    /// Generics -Array, List, Dictionary(key, value)  (Strongly Typed)- Avoid run time issues
    /// </summary>
    public class Program
    {
        static void Main(string[] args)
       {
   // Array ar = { 1, "test", 1.0 };

        // Generic type Array - Strongly typed  , no type case, no run time issues
        double[] darray = new double[5];
            int[] ages = new int[10];
            ages[0] = 10;
            ages[0] = 20;
            ages[0] = 30;
            foreach (int val in ages)
            {
                Console.WriteLine(val);

            }
            char[] charArray = new char[5];
            bool[] boolArray = new bool[2];
            string[] stringArray = new string[10];
            stringArray[0] = "test";
            stringArray[1] ="12sfdsf";
            stringArray[2] = "true";
            foreach (string value in stringArray)
            {
                Console.WriteLine(value);

            }

            List<string> list = new List<string>();
            list.Add("10");
            list.Add("test");

            Dictionary<int, string> dict = new Dictionary<int, string>();
            dict.Add(1, "Myfavbook");
            dict.Add(2, "socialBook");
            foreach (KeyValuePair<int, string> val in dict)
            {
                  Console.WriteLine(val.Key.ToString(), val.Value);
            }
            Console.ReadLine();
        }
    }
}
