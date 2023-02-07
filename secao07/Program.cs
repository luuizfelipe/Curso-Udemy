using System;

namespace secao07
{
    class Program
    {
        static void main03(string[] args)
        {
            Point p;
            p.X = 10;
            p.Y = 20;
            Console.WriteLine(p);
            p =new Point();
            Console.WriteLine(p);
        }
    }
}
