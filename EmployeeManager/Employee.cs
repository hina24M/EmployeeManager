using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace EmployeeManager
{
    public class Employee
    { public string Name { get; set; }
        public string Id { get; set; }
        public int HoursWorked { get; set; }
        public double HourlyRate { get; set; }


        public Employee(string name, string id, int hoursWorked)
        {
            Name = name;
            Id = id;
            HoursWorked = hoursWorked;
            this.HourlyRate = 9.5;
        }
        public override string ToString()
        {
            return $"{Name} ({Id})";
        }

        public double Wage()
        {
            return HoursWorked * HourlyRate;
        }

        public static bool IsValidName(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                return false;
            }
            bool hasLetter = false;
            foreach (char c in name)
            {
                if (char.IsLetter(c))
                {
                    hasLetter = true;
                    break;
                }
            }
            return hasLetter && name.Length >= 1 && name.Length <= 50;
        }

        public static bool IsValidId(string id)
        {
            //check if id is empty or length is greater than 3
            if (string.IsNullOrEmpty(id) || id.Length !=3)
            {
                return false;
            }

            return char.IsLetter(id[0]) && char.IsDigit(id[1]) && char.IsDigit(id[2]);

        }

        public static bool IsValidHours(int hoursWorked)
        {
            //check if hours worked is between 1 to 100
            return hoursWorked >= 1 && hoursWorked <= 100;
        }
    }
}
