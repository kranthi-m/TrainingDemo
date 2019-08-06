using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    interface ISum
    { }
    interface ISub
    { }
    // class Program : ISub, ISum  // Interfaces we can do multiple inheritance
    // sealed mean no inheritance possible..
    class Program : Math // Math is parent, Program is child/derived class
    { // class - no multple inheritance, multi level possible,
        public void Sub(int a, int b)
        {
            Console.WriteLine(a - b);
        }
        // Single Level Inheritance, Multi Level Inheritance
        //Multiple Inheritance is possible only by Interfaces / can not by classes
        static void Main(string[] args)
        {

            //Math obj = new Math();
            //obj.Sum(10, 20);
            //Console.ReadLine();

            Program objc = new Program();
            objc.Sub(10, 20);
            objc.Sum(20, 30);
            objc.Multiple(10, 40);
            Console.ReadLine();
        }
    }

    class Math: MulMath  //math will have 2 methods..1 is multiple and another is sum.
    {
        int a, b;

        public void Sum(int a, int b)
        {
            Console.WriteLine(a + b);
        }
    }
    class MulMath
    {
        public void Multiple(int a, int b)
        {
            Console.WriteLine(a * b);
        }

    }



    ////Delegate declaration
    //public delegate void SampleDelegate(string Text);
    //class DelegatesDemo
    //{
    //    public static void Display(string Text)
    //{
    //    Console.WriteLine("The string you entered is : " + Text);
    //}
    //public static void Main()
    //        {
    //            double[] darray = new double[5];
    //            char[] charArray = new char[5];
    //            bool[] boolArray = new bool[2];
    //            string[] stringArray = new string[10];
    //            stringArray[0] = "test";
    //            stringArray[1] = "12";
    //            foreach (string value in stringArray)
    //            {
    //                Console.WriteLine(value);

    //            }

    //            List<string> list = new List<string>();
    //            list.Add("10");
    //            list.Add("test");

    //            Dictionary<int, string> dict = new Dictionary<int, string>();
    //            dict.Add(1, "Myfavbook");
    //            dict.Add(2, "socialBook");
    //            foreach (KeyValuePair<int, string> val in dict)
    //            {
    //                Console.WriteLine("Key is "+  val.Key.ToString() + "Value is : " + val.Value);
    //            }
    //            Console.ReadLine();


    //            //Instantiate the delegate and pass the reference of the 
    //            //Display() method. 
    //            SampleDelegate S = new SampleDelegate(Display);
    //    Console.WriteLine("Enter your text to display");
    //    string Text = Console.ReadLine();
    //    //Invoke the delegate, which inturn will invoke the Display() method
    //    S(Text);
    //}
    //}
}
