using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodReturningObject
{
    class rect
    {
        int height, width;
        public rect(int h, int w)
        {
            height = h;
            width = w;
        }
        public void Show()
        {
            Console.WriteLine("Height = {0} Width =  {1}", height,width);
        }
        public rect factor(int factor , rect obj )
        {
            obj.height = obj.height * 2;
            obj.width = obj.width * 2;
            return obj;
        }
        public int area()
        {
            return (this.height * this.width);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            rect rectangleobj = new rect(5,7);
            Console.WriteLine("Displaying Rectangle Before Enlarging");
            rectangleobj.Show();
            Console.WriteLine("Displaying Rectangle Area Before Enlarging");
            Console.WriteLine("{0}",rectangleobj.area());
            Console.Read();

        }
    }
}
