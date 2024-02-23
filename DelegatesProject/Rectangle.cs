using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//MultiCast Delegate
namespace DelegatesProject
{
    public delegate void RectDelegate(double Width, double Height);
    internal class Rectangle
    {
        public void GetArea(double Width,double Height)
        {
            Console.WriteLine("Area of Rectangle"+Width * Height);
        }
        public void GetPerimeter(double Width,double Height)
        {
            Console.WriteLine("Perimeter of Rectangle"+2*(Width + Height));

        }
        static void Main()
        {
            Rectangle rect = new Rectangle();
            RectDelegate obj = rect.GetArea;
            obj += rect.GetPerimeter; 
            obj.Invoke(12.34, 56.78);
            Console.WriteLine();
            obj.Invoke(47.87, 34.89);
            Console.ReadLine(); 
        }
    }
}
