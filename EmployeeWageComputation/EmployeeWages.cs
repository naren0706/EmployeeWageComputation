using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation
{
    class EmployeeWages
    {
        const int WAGE_PER_HR = 20, FULL_TIME_HR = 8, PART_TIME_HR = 4, IS_FULL_TIME = 1, IS_PART_TIME = 0;
        Random random = new Random();

        public void EmployeeAttendance()
        {
            int empCheck = random.Next(0, 2);
            if (empCheck == 0 )
                Console.WriteLine("Employee is Absent");
            else
                Console.WriteLine("Employee is present");
            
        }
        public void CalculateEmpWages()
        {

            int empCheck = random.Next(0,3);
            int empHrs = 0;
            if (empCheck == IS_FULL_TIME)
                empHrs = FULL_TIME_HR;
            else if (empCheck == IS_PART_TIME)
                empHrs = PART_TIME_HR;
            int dailyWages = WAGE_PER_HR * empHrs;
            Console.WriteLine(dailyWages);
        }
        

    }
}
