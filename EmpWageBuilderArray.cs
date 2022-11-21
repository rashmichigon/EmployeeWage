using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    internal class EmpWageBuilderArray
    {
        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;

        private int numOfCompany = 0;
        private int numofCompany;
        private CompanyEmpWage[] companyEmpArray;

        public EmpWageBuilderArray()
        {
            this.companyEmpArray = new CompanyEmpWage[5];
        }

        public void addCompanyEmpWage(string company, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonth)
        {
            companyEmpArray[this.numOfCompany] = new CompanyEmpWage(company, empRatePerHour, numOfWorkingDays, maxHoursPerMonth);
            numofCompany++;
        }

        public void computeEmpWage()
        {
            for (int i = 0; i < numofCompany; i++)
            {
                companyEmpArray[i].setTotalEmpWage(this.companyEmpWage(this.companyEmpArray[i]));
                Console.WriteLine(this.companyEmpArray[i].toString());
            }
        }

      private int ComputeEmpWage(ComputeEmpWage, computeEmpWage)
        {
            int empHrs = 0, totalEmpHrs = 0, totalWorkingHrs = 0;
            while (totalEmpHrs <= computeEmpWage.MAX_HRS_IN_MONTH && totalWorkingDays < computeEmpWage.NUM_OF_WORKING_DAYS)
                totalWorkingDays++;
            Random random = new Random();
            int empCheck = random.Next(0, 3);
            switch (empCheck)
            {
                case IS_PART_TIME:
                    empHrs = 4;
                    break;
                case IS_FULL_TIME:
                    empHrs = 8;
                    break;
                default:
                    empHrs = 0;
                    break;
            }
            totalEmpHrs += empHrs;
            Console.WriteLine("Day#:" + totalWorkingDays + "Emp Hrs :" + empHrs);
        }
          return totalEmpHrs* companyEmpWage.empRatePerHour;
    }
}
}
