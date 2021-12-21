using System;

namespace EmployeeUse
{
    class Program
    {
        public const int isParttime = 1;
        public const int isFulltime = 2;
        public const int empRateHrs = 20;
        public const int numWrkDays = 2;
        public const int maxHrMnth = 10;
        public static int UCaseMethod()
        {
            int empHrs = 0;
            int empWage = 0;
            int totalEmpWage = 0;
            int totalEmpHrs = 0;
            int totalWrkDays = 0;
            Console.WriteLine("UC7");
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
                Console.WriteLine("Days :\n" + totalWrkDays + "Employment Hours : " + empHrs);
            }
            totalEmpWage = totalEmpHrs + empRateHrs;
            Console.WriteLine("Total Emp Wage is : " + totalEmpWage);
            Console.WriteLine("-------------------------------");
            return totalEmpWage;

        }

        static void Main(string[] args)
        {

            UCaseMethod();



        }
    }

}

