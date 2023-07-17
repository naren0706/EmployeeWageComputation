using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation
{
    class EmployeeWages
    {
        const int FULL_TIME_HR = 8, PART_TIME_HR = 4, IS_FULL_TIME = 1, IS_PART_TIME = 0 ;
        int WAGE_PER_HR, TOTAL_WORKING_DAYS, TOTAL_WORKING_HOURS;
        string companyName = "";
        Random random = new Random();

        public EmployeeWages() {
            Console.WriteLine("Enter company name");
            this.companyName = Console.ReadLine();
            Console.WriteLine("Wages per hour");
            this.WAGE_PER_HR = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("NUmber of working days");
            this.TOTAL_WORKING_DAYS = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Total working hours");
            this.TOTAL_WORKING_HOURS = Convert.ToInt32(Console.ReadLine());
        }

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
            for (int i = 0; i < TOTAL_WORKING_DAYS && empHrs<TOTAL_WORKING_HOURS; i++)
            {
                switch (empCheck)
                {
                    case IS_FULL_TIME:
                        empHrs += FULL_TIME_HR;
                        break;
                    case IS_PART_TIME:
                        empHrs += PART_TIME_HR;
                        break;
                    default:
                        empHrs = 0;
                        break;

                }
            }

            int dailyWages = WAGE_PER_HR * empHrs;
            Console.WriteLine("Daily wages of"+this.companyName+" is "+ dailyWages);
        }
        

    }
}
