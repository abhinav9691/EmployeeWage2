using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage2
{
    public class PartTime
    {
        public void EmployeeWage()
        {
            int parttime = 1;
            int fulltime = 2;
            int wageperhr = 20;

            int empwage = 0;
            int emphrs = 0;

            Random random = new Random();
            int empcheck = random.Next(0, 3);
            Console.WriteLine(empcheck);
            if (empcheck == parttime)
            {
                emphrs = 8;
                empwage = emphrs * wageperhr;
                Console.WriteLine("Employee Part Time Wage--" + empwage);
            }
            else if (empcheck == fulltime)
            {
                emphrs = 16;
                empwage = emphrs * wageperhr;
                Console.WriteLine("Employee Full Time Wage--" + empwage);
            }
            else
            {
                emphrs = 0;
                empwage = emphrs * wageperhr;
                Console.WriteLine("Employee is Absent");
            }



        }
    }
}
