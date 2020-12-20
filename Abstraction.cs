using System;
using System.Collections.Generic;
using System.Text;

namespace Arrays
{
    public abstract class Employee
    {
        public Employee()
        {

        }
        public int ID { get; set; }
        public string FullName { get; set; }
        public int Age { get; set; }

        public decimal Salary { get; set; }

        public decimal HourlyRate { get; set; }

        public decimal Hours { get; set; }

        public abstract float CalculateEmployeeSalary();

    }

    public class FullTimeEmployee : Employee
    {
        public override float CalculateEmployeeSalary()
        {
            return Convert.ToSingle(Hours * HourlyRate);
        }

    }

    public class ContractEmployee : Employee
    {
        public override float CalculateEmployeeSalary()
        {
            return Convert.ToSingle(Salary);
        }
    }
}
