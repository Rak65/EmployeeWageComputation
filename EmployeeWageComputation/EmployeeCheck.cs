using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation
{
    public class EmployeeCheck
    {
        public static void PartFullEmpWage() 
        {
            //int IS_FULL_TIME = 1;
            //int IS_PART_TIME = 2;
            int dayHour = 0;
            int dailyEmpWage = 0;
            int WAGE_PER_HOUR = 20;
            Random random = new Random();
            int empCheck=random.Next(3);
            switch(empCheck)
            {
                case 0:
                    dayHour = 0;
                    break;
                case 1:
                    dayHour = 8;
                    break;
                case 2:
                    dayHour = 4;
                    break;

            }
            //if (empCheck == IS_FULL//_TIME)
            //{
            //    dayHour = 8;
            //}
            //else if(empCheck == IS_PART_TIME)
            //{
            //    dayHour = 4;
            //}
            //else
            //{
            //    dayHour = 0;
            //}
            dailyEmpWage = dayHour * WAGE_PER_HOUR;
            Console .WriteLine("Daily Employee wage = "+dailyEmpWage);
        }
    }
}
