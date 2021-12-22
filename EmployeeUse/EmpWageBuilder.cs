using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeUse
{
    public class EmpWageBuilder : IComputeEmpWage
    {
        public const int isParttime = 1;
        public const int isFulltime = 2;

       
       

        private LinkedList<CompanyEmpWage> companyEmpWagesList;
        private Dictionary<string, CompanyEmpWage> companyToEmpWageMap;

       
        public EmpWageBuilder()
        {
           
            this.companyEmpWagesList = new LinkedList<CompanyEmpWage>();
            this.companyToEmpWageMap = new Dictionary<string, CompanyEmpWage>();
           

        }

       

        public void addCompanyEmpWage(string company, int empRateHrs, int numWrkDays, int maxHrMnth)
        {
            
            CompanyEmpWage companyEmpWage = new CompanyEmpWage(company, empRateHrs, numWrkDays, maxHrMnth);
           
            this.companyEmpWagesList.AddLast(companyEmpWage);
            this.companyToEmpWageMap.Add(company, companyEmpWage);

        }
       
        public void ComputeEmpWage()
        {
            
                foreach (CompanyEmpWage companyEmpWage in this.companyEmpWagesList)
                {

                companyEmpWage.setTotalEmpWage(this.computeEmpWage(companyEmpWage));
                Console.WriteLine(companyEmpWage.toString());
            }
           
        }

        private int computeEmpWage(CompanyEmpWage companyEmpWage)
        {
            throw new NotImplementedException();
        }


       

        public int getTotalWage(string company)
        {
            return this.companyToEmpWageMap[company].totalEmpWage;
        }

    }

}
