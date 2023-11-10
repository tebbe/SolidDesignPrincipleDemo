using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidDesignPrincipleDemo.SOLID.DIP
{
    //Validate DIP
    public interface ISalaryCalculator
    {
        float CalculateSalary(double x, double y);
    }

    public class SalaryCalculator : ISalaryCalculator
    {
        public float CalculateSalary(double x, double y) => (float)(x * y);
        
    }
    public class EmployeeSalaryDetails
    {
        private readonly ISalaryCalculator _salaryCalculator;
        public int WorkedHours { get; set; }
        public float HourlyRate { get; set; }   

        public EmployeeSalaryDetails(ISalaryCalculator salaryCalculator) 
        {
            _salaryCalculator = salaryCalculator;
        }

        public float GetSalary()
        {
            return _salaryCalculator.CalculateSalary(WorkedHours, HourlyRate);
        }
    }

    /*
    In the above code, we see that we have created an interface ISalaryCalculator, 
    and then we have a class called SalaryCalculator that implements this interface.
    Finally, in the higher-level class EmployeeSalaryDetails, we only depend upon 
    the ISalaryCalculator interface and not the concrete class. Hence,
    when we create the EmployeeSalaryDetails class,
    we specify the abstraction implementation to use. In addition to this, 
    the details of the CalculateSalary function are hidden from the EmployeeSalaryDetails class,
    and any changes to this function will not affect the interface being used. 

     */
}
