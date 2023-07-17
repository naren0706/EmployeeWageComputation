using System;

namespace EmployeeWageComputation
{
    class Program
    {
        public static void Main(string[] args)
        {            

            EmployeeWages Apple = new EmployeeWages();
            Apple.EmployeeAttendance();
            Apple.CalculateEmpWages();
            EmployeeWages Amazon = new EmployeeWages();
            Amazon.EmployeeAttendance();
            Amazon.CalculateEmpWages();
        }
    }
}