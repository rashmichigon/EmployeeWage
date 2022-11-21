
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace EmployeeWage
{
    internal class Program
    {

        static void Main(String[] args)
        {
            EmployeeWageBuilderObject dMart = new EmployeeWageBuilderObject("Dmart", 20, 2, 10);
            EmployeeWageBuilderObject reliance = new EmployeeWageBuilderObject("reliance", 10, 4, 20);
            dMart.computeEmpWage();
            Console.WriteLine(dMart.toString());
            reliance.computeEmpWage();
            Console.WriteLine(reliance.toString());
        }
    }
}
  