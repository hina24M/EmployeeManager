using System;

namespace EmployeeManager
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = GetValidName();

            string id = GetValidId();

            int hoursWorked = GetValidHours();

            Employee myEmployee = new Employee(name, id, hoursWorked);
            myEmployee.Wage();
            Console.WriteLine($"The weekly wage is £{myEmployee.Wage():F2}");

            
        }
        static string GetValidName()
        {
            string name;
            do
            {
                Console.Write("Employee Name: ");
                name = Console.ReadLine() ?? "";

                if(!Employee.IsValidName(name))
                {
                    Console.WriteLine("Error: Name must be in letters and must be between 1 - 50 characters.");
                }
            }
            while (!Employee.IsValidName(name));
            return name;
        }

        static string GetValidId()
        {
            string id;
            do
            {
                Console.Write("Employee ID: ");
                id = Console.ReadLine() ?? "";

                if (!Employee.IsValidId(id))
                {
                    Console.WriteLine("Error: Employee ID should start with 1 letter and end with 2 digits., example: D65");
                }
            }
            while (!Employee.IsValidId(id));
            return id;
        }

        static int GetValidHours()
        {
            int hoursWorked;
            do
            {
                Console.Write("Hours Worked: ");
                if (!int.TryParse(Console.ReadLine(), out hoursWorked) 
                    || !Employee.IsValidHours(hoursWorked))
                {
                    Console.WriteLine("Error: Hours worked must be between 1 till 100.");
                    hoursWorked = 0;
                }
            }
            while (!Employee.IsValidHours(hoursWorked));
            return hoursWorked;
        }

    }
}