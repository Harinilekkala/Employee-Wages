// See https://aka.ms/new-console-template for more information
using System;


namespace EmployeePresentorAbsent
{
    public class Program
    {
        public static void Main(string[] args)
        {
            presentorabsent presentabsent = new presentorabsent();
            presentabsent.checkStatus();
            presentabsent.dailyWages();
            presentabsent.AddPartTimeWages();

        }
    }
}
