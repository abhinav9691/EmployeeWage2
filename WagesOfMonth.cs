using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage2
{
    public class WagesOfMonth
    {
        public void EmployeeWage()
        {
            
            int day = 1;
            int parttime = 1;
            int fulltime = 2;
            int wageperhr = 20;
            int maxworkingdays = 20;
            
            int empwage = 0;
            int emphrs = 0;
            int totalwage = 0;
            
            for (day = 1; day <= maxworkingdays; day++)
            {
               
                Random random = new Random();

                int empcheck = random.Next(0, 3);

                switch (empcheck)
                {
                    case 1:
                        emphrs = 8;
                        empwage = emphrs * wageperhr;
                        Console.WriteLine("Employee Part Time Wage--" + empwage);
                        totalwage += empwage;
                        break;
                    case 2:
                        emphrs = 16;
                        empwage = emphrs * wageperhr;
                        Console.WriteLine("Employee Full Time Wage--" + empwage);
                        totalwage += empwage;
                        break;
                    default:
                        emphrs = 0;
                        empwage = emphrs * wageperhr;
                        Console.WriteLine("Employee is Absent");
                        totalwage += empwage;
                        break;
                }


            }
            Console.WriteLine("Employe Total Wage for the Month--" + totalwage);

        }
    }
}
