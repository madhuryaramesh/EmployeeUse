using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeUse
{
    public class UCase2
    {
        public void UCase2Method()
        {
            int Is_Fulltime = 1;
            int Emp_Rate_PerHour = 20;

            int emphrs = 0;
            int empwage = 0;
            Random random = new Random();
            int empcheck = random.Next(0, 2);
            if (empcheck == Is_Fulltime)
            {
                emphrs=8;
            }
            else
            {
                emphrs = 0;
            }
            empwage = emphrs * Emp_Rate_PerHour;
            Console.WriteLine("Employee Wage is " + empwage);
        }
    }
}
