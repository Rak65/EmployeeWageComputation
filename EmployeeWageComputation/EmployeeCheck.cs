using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation
{
    public class EmployeeCheck
    {
        const int IS_FUL_TIME = 1;
        const int IS_PART_TIME = 2;
        const int NO_OF_WORKING_DAYS = 20;        //20 working days per month
        const int EMP_RATE_PER_HOUR = 20;
        public static void MonthEmpWage() 
        {
            int dayHour = 0;
            int empWage = 0;
            int totalEmpWage = 0;
            for(int day = 0; day < NO_OF_WORKING_DAYS; day++)
            {
                Random random = new Random();
                int empCheck = random.Next(3);
                switch (empCheck)
                {
                    case IS_FUL_TIME:
                        dayHour = 8;
                        break;
                    case IS_PART_TIME :                
                        dayHour = 4;
                        break;
                    default:             
                        dayHour = 0;
                        break;

                }
                empWage = dayHour * EMP_RATE_PER_HOUR;
                Console.WriteLine("Employee wage = "+empWage);
                totalEmpWage += empWage;
            }
            Console .WriteLine ("Total Employee wage = "+totalEmpWage );

        }
    }
}
