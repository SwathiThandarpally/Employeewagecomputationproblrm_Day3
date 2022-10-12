using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employeewageproblem
{
    public static class Employeecheck
    {
        public static void  checkattendance()
        {
            int IS_FULL_TIME = 1;

            Random random = new Random();
            int empcheck = random.Next(2);
            if(empcheck == IS_FULL_TIME)
            {
                Console.WriteLine("Employee is present");
            }
            else
            {
                Console.WriteLine("Employee is absent");

            }
        }
    }
}
