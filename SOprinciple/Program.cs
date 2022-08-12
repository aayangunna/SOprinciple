using System; 
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SOP_Principle

{

    /// <summary>
    /// A program that calculates the salary of Developers
    /// </summary>
    class Program
    {

        static void Main(string[] args)
        {
            var devCalculations = new List<BaseSalaryCalculator>
            {
                new SeniorDevSalaryCalculator(new DeveloperReport {Id = 1, Name = "Dev1", Level = "Senior developer", HourlyRate = 30.5, WorkingHours = 160 }),
                new JuniorDevSalaryCalculator(new DeveloperReport {Id = 2, Name = "Dev2", Level = "Junior developer", HourlyRate = 20, WorkingHours = 150 }),
           
            };

            var calculator = new SalaryCalculator(devCalculations);
            Console.WriteLine($"The sum of all the developer salaries is {calculator.CalculateTotalSalaries()} dollars");
        }
    }
}