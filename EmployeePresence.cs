using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage2
{
    public class EmployeePresence
    {
        public void EmpPresentAbsent()
        {
            
            int fulltime = 1;
            Random random = new Random();
            int empcheck = random.Next(0, 2);
            Console.WriteLine(empcheck);
            if (empcheck == fulltime)
            {
                Console.WriteLine("Employee is Present");
            }
            else
            {
                Console.WriteLine("Employee is Absent");
            }
        }
    }
}
