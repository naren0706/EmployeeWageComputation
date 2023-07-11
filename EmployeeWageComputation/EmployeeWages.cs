using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation
{
    class EmployeeWages
    {
        const int WAGE_PER_HR = 0, FULL_DAY_HR = 0;
        public void EmployeeAttendance()
        {
            Random random = new Random();
            int empCheck = random.Next(0, 2);
            if (empCheck == 0 )
                Console.WriteLine("Employee is Absent");
            else
                Console.WriteLine("Employee is present");
            
        }
        public void CalculateEmpWages()
        {
            int dailyWages = WAGE_PER_HR * FULL_DAY_HR;
            Console.WriteLine(dailyWages);
        }
    }
}
