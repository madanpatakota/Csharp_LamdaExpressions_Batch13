using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class DelegatesRealtimeExample
{

    public delegate double BonusCalculator(double salary);
    class Employee
    {
        public string Name { get; set; }
        public double Salary { get; set; }
        public Employee(string name, double salary)
        {
            Name = name;
            Salary = salary;
        }
        public double CalculateBonus(BonusCalculator bonusCalculator)
        {
            return bonusCalculator(Salary);
        }
    }

    class Program
    {
        public static double StandardBonus(double salary)
        {
            // Standard bonus calculation: 5% of salary
            return salary * 0.05;  //5% hike
        }

        public static double HighPerformanceBonus(double salary)
        {
            // High-performance bonus calculation: 10% of salary
            return salary * 0.15; //15% hike
        }

        static void Main()
        {
            Employee employee1 = new Employee("John", 10000);
            Employee employee2 = new Employee("Sarah", 10000);

            double employee1Bonus = employee1.CalculateBonus(StandardBonus);
            Console.WriteLine($"Empoloyee 1 bonus is {employee1Bonus}");

            double employee2Bonus = employee2.CalculateBonus(HighPerformanceBonus);
            Console.WriteLine($"Empoloyee 2 bonus is {employee2Bonus}");


            Console.ReadLine();

        }



    }




}

