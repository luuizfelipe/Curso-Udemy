using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Var.switch1
{
    internal class Class1
    {  
        static void Main(string[] args)
        {
            int x =  int.Parse(Console.ReadLine());
            string day;

            switch (x){
                case 1:
                    day = "sunday";
                break;
                case 2:
                    day = "sunday";
                break;
                case 3:
                    day = "tuesday";
                break;
                case 4:
                    day = "Wednesday";
                break;
                case 5:
                    day = "Thursday";
                break;
                case 6:
                    day = "sunday";
                break;
                case 7:
                    day = "Saturday";
                break;

                default
                    day = "invalid value";
                break;
            }

            Console.WriteLine("day" + day);
        }
    }
}
