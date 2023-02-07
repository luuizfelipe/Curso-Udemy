using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List
{
    internal class employees
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double salary { get; set; }


        public employees(int id, string name, double salary)
        {
            Id = id;
            Name = name;
            salary = salary;
        }

        public void IncreaseSalary(double percetage)
        {
            salary += salary * percetage / 100.0;
        }

        public override string ToString()
        {
            return Id
                + ", "
                + Name
                + ", "
                + salary.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
