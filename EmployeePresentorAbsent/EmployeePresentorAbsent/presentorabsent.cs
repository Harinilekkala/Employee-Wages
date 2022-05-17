using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePresentorAbsent
{
    class presentorabsent

    {
        int empHrs = 0, empWage=0, Emprateperhr = 20, IspartTime = 2, totalEmpWage = 0, NumOfWorkingDays = 10, totalEmpHrs = 0, MAX_HRS_IN_MONTH = 40, totalWorkingDays = 0, NUM_OF_WORKING_DAYS = 10;
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
        public void dailyWages()
        {
            Random rand = new Random();
            int empCheck = rand.Next(0, 3);
            if (empCheck == 1)
            {
                Console.WriteLine("Employee is present");
                empHrs = 8;
            }
            else
            {
                Console.WriteLine("Employee is absent");
                empHrs = 0;
            }
            empWage = empHrs * Emprateperhr;
            Console.WriteLine("Daily employee wage " + empWage + "\n");
        }

        public void AddPartTimeWages()
        {

            Random rand = new Random();
            int empCheck = rand.Next(0, 3);

            if (empCheck == 1)
            {
                Console.WriteLine("Employee is present full time");
                empHrs = 8;
            }
            else if (empCheck == IspartTime )
            {
                Console.WriteLine("Employee is present part time");
                empHrs = 4;
            }
            else
            {
                Console.WriteLine("Employee is absent");
                empHrs = 0;
            }
            empWage = empHrs * Emprateperhr;
            Console.WriteLine("Daily employee wage " + empWage + "\n");
        }
        public void EmpWageUsingSwitch()
        {
            Random rand = new Random();
            int empCheck = rand.Next(0, 3);

            switch (empCheck)
            {
                case 1:
                    Console.WriteLine("Employee is present full time");
                    empHrs = 8;
                    break;

                case 2:
                    Console.WriteLine("Employee is present part time");
                    empHrs = 4;
                    break;

                default:
                    Console.WriteLine("Employee is absent");
                    empHrs = 0;
                    break;
            }
            empWage = empHrs * Emprateperhr;
            Console.WriteLine("Daily employee wage " + empWage + "\n");
        }
        public void calculateMonthlyWage()
        {
            for (int days = 0; days < NumOfWorkingDays; days++)
            {
                Random rand = new Random();
                int empCheck = rand.Next(0, 3);
                switch (empCheck)
                {
                    case 1:
                        Console.WriteLine("Employee is present full time");
                        empHrs = 8;
                        break;

                    case 2:
                        Console.WriteLine("Employee is present part time");
                        empHrs = 4;
                        break;

                    default:
                        Console.WriteLine("Employee is absent");
                        empHrs = 0;
                        break;
                }
                empWage = empHrs * Emprateperhr;
                totalEmpWage += empWage;
                Console.WriteLine("Daily employee wage " + empWage);
            }
            Console.WriteLine("Total employee wage for month " + totalEmpWage + "\n");
        }
        public void calculateTotalEmpWage()
        {
            while (totalEmpHrs < MAX_HRS_IN_MONTH && totalWorkingDays < NUM_OF_WORKING_DAYS)
            {
                totalWorkingDays++;
                Random rand = new Random();
                int empCheck = rand.Next(0, 3);
                switch (empCheck)
                {
                    case 1:
                        Console.WriteLine("Employee is present full time");
                        empHrs = 8;
                        break;

                    case 2:
                        Console.WriteLine("Employee is present part time");
                        empHrs = 4;
                        break;

                    default:
                        Console.WriteLine("Employee is absent");
                        empHrs = 0;
                        break;
                }
                totalEmpHrs += empHrs;
                Console.WriteLine("Days " + totalWorkingDays + " " + "Employee Hours " + totalEmpHrs);
            }
            int totalEmpWage = totalEmpHrs * Emprateperhr;
            Console.WriteLine("Total employee wage " + totalEmpWage);
        }

    }
}






    

