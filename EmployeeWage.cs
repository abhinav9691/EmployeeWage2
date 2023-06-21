using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage2
{
    public class EmployeeWage
    {
        public void EmpWage()
        {
            int is_full_time = 1;
            int emp_rate_per_hour = 20;

            int empHrs = 0;
            int empWage = 0;
            Random random1 = new Random();
            int empCheck1 = random1.Next(0, 2);
            Console.WriteLine(empCheck1);

            if (empCheck1 == is_full_time)
            {
                empHrs = 8;
            }
            else
            {
                empHrs = 0;
            }
            empWage = empHrs * emp_rate_per_hour;
            Console.WriteLine("Emp Wage " + empWage);


        }
    }
}
