using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation
{
    class EmployeeWages
    {
        const int WAGE_PER_HR = 20, FULL_TIME_HR = 8, PART_TIME_HR = 4, IS_FULL_TIME = 1, IS_PART_TIME = 0 , TOTAL_WORKING_DAYS=20;
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
            for (int i = 0; i < TOTAL_WORKING_DAYS; i++)
            {
                switch (empCheck)
                {
                    case 0:
                        empHrs += FULL_TIME_HR;
                        break;
                    case 1:
                        empHrs += PART_TIME_HR;
                        break;
                    default:
                        empHrs = 0;
                        break;

                }
            }

            int dailyWages = WAGE_PER_HR * empHrs;
            Console.WriteLine(dailyWages);
        }
        

    }
}
