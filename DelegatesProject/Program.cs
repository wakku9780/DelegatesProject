namespace DelegatesProject
{
    //Defining a Delegeta 
    public delegate void AddDelegate(int x, int y);
    public delegate string  SayDelegate(string str);
    public  class Program
    {
        public void AddNums(int a,int b)
        {
            Console.WriteLine(a + b);
        }
        public static string SayHello(string name)
        {
            return "Hello " + name;
        }
       static void Main(string[] args)
        {
            Program p = new Program();
            // p.AddNums(100, 50);

            //string str = Program.SayHello("waqar");
            //Console.WriteLine(str);
            //Console.ReadLine();


            AddDelegate ad = new AddDelegate(p.AddNums);
            ad(100, 50);
            SayDelegate sd = new SayDelegate(Program.SayHello);
            string str = sd("Raju"); 

            string str1 = Program.SayHello("Raju");

            Console.WriteLine(str1);

            Console.ReadLine(); 
        }
    }
}
