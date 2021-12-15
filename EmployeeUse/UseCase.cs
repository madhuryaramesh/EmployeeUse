using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeUse
{
    public class UseCase
    {
        public const int isParttime = 1;
        public const int isFulltime = 2;
        public const int empRateHrs = 20;
        public void UCaseMethod()
        {
            int empHrs = 0;
            int empWage = 0;
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
            Console.WriteLine("UC4");
            Console.WriteLine("-------------------------------");
            empWage = empHrs * empRateHrs;
            Console.WriteLine("Emp Wage is : " + empWage);
            Console.WriteLine("-------------------------------");
        }
    }
}
