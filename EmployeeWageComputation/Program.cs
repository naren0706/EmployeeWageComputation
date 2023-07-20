using System;

namespace EmployeeWageComputation
{
    class Program
    {
        public static void Main(string[] args)
        {            

            EmployeeWages company1 = new EmployeeWages();
            company1.EmployeeAttendance();
            company1.CalculateEmpWages();
            company1.toString();
            EmployeeWages company2 = new EmployeeWages();
            company2.EmployeeAttendance();
            company2.CalculateEmpWages();
            company2.toString();

        }
    }
}