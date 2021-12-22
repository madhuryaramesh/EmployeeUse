using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeUse
{
    public class EmpWageBuilderObject
    {
        public const int isParttime = 1;
        public const int isFulltime = 2;

       
        private string company;
        private int empRateHrs;
        private int numWrkDays;
        private int maxHrMnth;
        private int totalEmpWage;

       
        public EmpWageBuilderObject(string company, int empRateHrs, int numWrkDays, int maxHrMnth)
        {

            this.company = company;
            this.empRateHrs = empRateHrs;
            this.numWrkDays = numWrkDays;
            this.maxHrMnth = maxHrMnth;

           
        }

     
        public void computeEmpWage()
        {

            int empHrs = 0;
           
            int totalEmpWage = 0;
            int totalEmpHrs = 0;
            int totalWrkDays = 0;
            Console.WriteLine("UC9");
            Console.WriteLine("-------------------------------");
            while (totalEmpHrs <= maxHrMnth && totalWrkDays < numWrkDays)
            {
                totalWrkDays++;
                Random rand = new Random();
                int empCheck = rand.Next(0, 3);

                switch (empCheck)
                {
                    case isParttime:
                        empHrs = 4;
                        break;

                    case isFulltime:
                        empHrs = 8;
                        break;

                    default:
                        empHrs = 0;
                        break;

                }
                
                totalEmpHrs = totalEmpHrs + empHrs;
                Console.WriteLine("Days :" + totalWrkDays + "Employment Hours : " + empHrs);

               

            }
            totalEmpWage = totalEmpHrs + empRateHrs;
            Console.WriteLine("Total Emp Wagefor company " + company + " is : " + totalEmpWage);


        }
        public string toString()
        {
            return "Total Emp Wagefor company " + this.company + " is : " + this.totalEmpWage;
            ;
        }
    }

}
