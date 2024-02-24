using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesProject
{
    //public delegate double Delegate1(int x,float y,double z);
    //public delegate void Delegate2(int x,float y,double z);
    //public delegate bool Delegate3(string str);
    internal class GenericDelegates
    {
        public static double AddNums1(int x,float y,double z)
        {
            return x + y + z;
        }

        public static void AddNums2(int x,float y,double z)
        {
            Console.WriteLine(x + y + z);
        }
        public static bool CheckLength(string str)
        {
            if (str.Length > 5)
                return true;
            return false;
        }
        static void Main()
        {
            // Delegate1 obj1 = AddNums1;
            Func<int, float, double, double> obj1 = AddNums1;
            double result = obj1.Invoke(100, 34.5f, 193.465);
            Console.WriteLine(result);

            // Delegate2 obj2 = AddNums2;
            Action<int, float, double> obj2 = AddNums2;
            obj2.Invoke(100, 34.5f, 193.465);

            //Delegate3 obj3 = CheckLength;
            Predicate<string> obj3 = CheckLength; 
            bool status = obj3.Invoke("Hello");
            Console.WriteLine(status); 

            Console.ReadLine();

        }
    }
}
