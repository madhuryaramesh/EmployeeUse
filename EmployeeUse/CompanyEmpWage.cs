using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeUse
{
    public interface IComputeEmpWage
    {
        public void addCompanyEmpWage(string company, int empRateHrs, int numWrkDays, int maxHrMnth);
        public void ComputeEmpWage();
        public int getTotalWage(string company);
    }
    public class CompanyEmpWage
    {
        public string company;
        public int empRateHrs;
        public int numWrkDays;
        public int maxHrMnth;
        public int totalEmpWage;
        public CompanyEmpWage(string company, int empRateHrs, int numWrkDays, int maxHrMnth)
        {
           
            this.company = company;
            this.empRateHrs = empRateHrs;
            this.numWrkDays = numWrkDays;
            this.maxHrMnth = maxHrMnth;

            this.totalEmpWage = 0;
        }

        public void setTotalEmpWage(int totalEmpWage)
        {
            this.totalEmpWage = totalEmpWage;
        }
        public string toString()
        {
            return "Total Emp Wagefor company " + this.company + " is : " + this.totalEmpWage;
        }
    }
}