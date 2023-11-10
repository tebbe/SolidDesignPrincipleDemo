using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidDesignPrincipleDemo.SOLID.DIP
{
    //Violate DIP
    public class SalaryCalcuator
    {
        public float CalculateSalary(int workedHours,float rate)=>workedHours*rate;
    }
    public class EmployeeDetails
    {
        public int WorkedHours { get; set; }
        public float HourlyRate { get; set; } 

        public float GetSalary()
        {
          var salaryCalculate = new SalaryCalcuator();

          return salaryCalculate.CalculateSalary(WorkedHours, HourlyRate);
        }
    }

    /* These classes do not follow the “Dependency Inversion Principle” 
     * as the higher-level class EmployeeDetails is directly dependent upon
     * the lower-level SalaryCalculator class.*/
}
