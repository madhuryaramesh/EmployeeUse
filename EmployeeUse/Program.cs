using System;

namespace EmployeeUse
{
    public class Program
    {

        static void Main(string[] args)
        {
            
            EmpWageBuilder empWageBuilder = new EmpWageBuilder();
            empWageBuilder.addCompanyEmpWage("DMart", 20, 2, 10);
            empWageBuilder.addCompanyEmpWage("Reliance", 10, 4, 10);
            empWageBuilder.ComputeEmpWage();
            Console.WriteLine("Total wage for DMart Company " + empWageBuilder.getTotalWage("DMart"));
        }
    }
}