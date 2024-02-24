using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesProject
{
    public class LambdaExpressions
    {
        public static string Greetings(string name)
        {
            return "Hello" + name + "a very good morning"; 
        }

        static void Main()
        {
            GreetingsDelegate obj = new GreetingsDelegate(Greetings);
            GreetingsDelegate obj1 =( name)=>
            {
                return "Hello" + name + "a very good morning";
            };
            string str=obj.Invoke("Mubarakpur");
            Console.WriteLine(str);
            Console.ReadLine();
        }
    }
}
