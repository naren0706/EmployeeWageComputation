using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation
{
    class EmployeeWages
    {
        const int WAGE_PER_HR = 20, FULL_DAY_HR = 8, PART_TIME_HR=8;
        public void EmployeeAttendance()
        {
            Random random = new Random();
            int empCheck = random.Next(0, 2);
            if (empCheck == 0 )
                Console.WriteLine("Employee is Absent");
            else
                Console.WriteLine("Employee is present");
            
        }
        public void CalculateEmpFullTimeWages()
        {
            int dailyWages = WAGE_PER_HR * FULL_DAY_HR;
            Console.WriteLine(dailyWages);
        }
        public void CalculateEmpPartTimeWages()
        {
            int dailyWages = WAGE_PER_HR * PART_TIME_HR;
            Console.WriteLine(dailyWages);
        }

    }
}
