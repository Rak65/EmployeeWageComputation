using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation
{
    public class EmployeeCheck
    {
        public static void MonthEmpWage() 
        {
            int WORKING_DAYS = 20;        //20 working days per month
            int dayHour = 0;
            int monthEmpWage;
            int WAGE_PER_HOUR = 20;
            Random random = new Random();
            int empCheck=random.Next(3);
            switch(empCheck)
            {
                case 0:                //Employee is abscent so dayhour=0
                    dayHour = 0;
                    break;
                case 1:                //Employee is present for Full Time so working hour is 8
                    dayHour = 8;       
                    break;
                case 2:                //Employee is working as Part Time so working hour is 4
                    dayHour = 4;
                    break;

            }
            monthEmpWage = dayHour * WAGE_PER_HOUR * WORKING_DAYS;
            Console .WriteLine("Monthly Employee wage = "+monthEmpWage);
        }
    }
}
