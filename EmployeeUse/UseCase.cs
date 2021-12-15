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
            if (empCheck == isParttime)
            {
                empHrs = 4;
            }
            else if (empCheck == isFulltime)
            {
                empHrs = 8;
            }
            else
            {
                empHrs = 0;
            }
            Console.WriteLine("UC3");
            Console.WriteLine("-------------------------------");
            empWage = empHrs * empRateHrs;
            Console.WriteLine("Emp Wage is : " + empWage);
            Console.WriteLine("-------------------------------");
        }
    }
}
