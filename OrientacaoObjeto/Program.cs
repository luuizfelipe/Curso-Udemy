using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace OrientacaoObjeto
{
    internal class Program
    {
        static void mains54(string[] args)
        {
            Triangulo x, y;

            x = new Triangulo();
            y = new Triangulo();


            Console.WriteLine("entre com as medidas do triangulo X: ");
            x.A = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            Console.WriteLine("entre com as medidas do triangulo Y: ");
            y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);



            double areaX = x.Area();

           
            double areaY  = y.Area(); 

            Console.WriteLine("Area de X" + areaX.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("Area de Y" + areaY.ToString("F4", CultureInfo.InvariantCulture));

            if(areaX > areaY)
            {
                Console.WriteLine("Maior area é: X");
            }
            else
            {
                Console.WriteLine("Maior area: Y"); 
            }

        }
    }
}
