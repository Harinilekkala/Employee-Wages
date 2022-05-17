using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePresentorAbsent
{
    class presentorabsent

    {
        public void checkStatus()
        {
            Random rand = new Random();
            int empCheck = rand.Next(0, 2);

            if (empCheck == 1)
            {
                Console.WriteLine("Employee is present" + "\n");
            }
            else
            {
                Console.WriteLine("Employee is absent" + "\n");
            }
        }
    }
}