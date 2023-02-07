using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List
{
    internal class ExercicioList
    {
        static void Main(string[] args)
        {

            Console.Write("How many employees will be registered ? ");
            int n = int.Parse(Console.ReadLine());

            List<employees> list = new List<employees>();

            for (int i = i; i <= n; i++)
            {
                Console.WriteLine("Emplyoee #" + i + ":");

                Console.WriteLine("ID:");
                int id = int.Parse(Console.ReadLine());

                Console.WriteLine("Name: ");
                string name = Console.ReadLine();
                Console.Write("Salary: ");
                double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                list.Add(new employees(id, name, salary));
                Console.WriteLine();

            }

            Console.WriteLine("Enter the employee id that will have salary increase : ");
            int searcId = int.Parse(Console.ReadLine());

            employees emp = list.Find(x => x.Id == searcId);
            if (emp != null)
            {
                Console.Write("Enter the percentage:");
                double percetage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                emp.IncreaseSalary(percetage);
            }
            else
            {
                Console.WriteLine("This id does not exist!");
            }

            Console.WriteLine();
            Console.WriteLine("Updated list of employees:");
            foreach (employees obj in list)
            {
                Console.WriteLine(obj);
            }
        }
    }
}
