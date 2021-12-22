using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeUse
{
    public class EmpWageBuilderArray
    {
        public const int isParttime = 1;
        public const int isFulltime = 2;

        private int numofCompany;
        private CompanyEmpWage[] computeEmpWageArray;

        
        public EmpWageBuilderArray()
        {
            this.computeEmpWageArray = new CompanyEmpWage[5];
           

        }
        public void addCompanyEmpWage(string company, int empRateHrs, int numWrkDays, int maxHrMnth)
        {
            computeEmpWageArray[this.numofCompany] = new CompanyEmpWage(company, empRateHrs, numWrkDays, maxHrMnth);
            numofCompany++;

        }
        public void computeEmpWage()
        {
            for (int i = 0; i < numofCompany; i++)
            {
                computeEmpWageArray[i].setTotalEmpWage(this.computeEmpWage(this.computeEmpWageArray[i]));
                Console.WriteLine(this.computeEmpWageArray[i].toString());
            }
        }
        private int computeEmpWage(CompanyEmpWage companyEmpWage)
        {
            int empHrs = 0;
            
            int totalEmpWage = 0;
            int totalEmpHrs = 0;
            int totalWrkDays = 0;
            Console.WriteLine("UC10");
            Console.WriteLine("-------------------------------");
            while (totalEmpHrs <= companyEmpWage.maxHrMnth && totalWrkDays < companyEmpWage.numWrkDays)
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
            return totalEmpHrs * companyEmpWage.empRateHrs;
          


        }
      
    }

}