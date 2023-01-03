using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageproblem
{
    public class EmployeeAttendance
    {
        public  void CheckAttendance()
        {
            int IS_FULL_TIME = 1;
            int EMP_RATE_PER_HOUR = 20;

            int empHrs = 0;
            int empWage = 0;
           
            Random random = new Random();
            int empCheck = random.Next(3);

            if(empCheck == IS_FULL_TIME)
            {
                Console.WriteLine("Employee is present");
                empHrs = 8;
            }
           else if (empCheck == 2)
            {
                Console.WriteLine("Employee is parttime");
                empHrs = 4;
            }
            else
            {
                Console.WriteLine("Employee is absent");
                empWage = 0;
            }
            empWage = empHrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("Emp Wage :" +empWage);

        }
    }
}
