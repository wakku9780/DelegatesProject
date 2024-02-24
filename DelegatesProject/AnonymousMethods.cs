using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DelegatesProject
{
    public delegate string GreetingsDelegate(string name);
    internal class AnonymousMethods
    {
        
        static void Main()
        {
            GreetingsDelegate obj = delegate (string name)
            {
                return "Heollo" + name + "a very good  morning";
            };
;
            string str=obj.Invoke("Scott");
            Console.WriteLine(str);
             
        }
                                   
    }
}
