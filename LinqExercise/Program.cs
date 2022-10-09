using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqExercise
{
    class Program
    {
        //Static array of integers
        private static int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };

        static void Main(string[] args)
        {
            /*
             * Complete every task using Method OR Query syntax. 
             * You may find that Method syntax is easier to use since it is most like C#
             * Every one of these can be completed using Linq and then printing with a foreach loop.
             * Push to your github when completed!
             */

            //TODO: Print the Sum of numbers

            Console.WriteLine("Print the Sum of numbers");
            var sum = numbers.Sum();
            Console.WriteLine(sum);

            //TODO: Print the Average of numbers

            Console.WriteLine("Print the Average of numbers");
            var average = numbers.Average();
            Console.WriteLine(average);

            //TODO: Order numbers in ascending order and print to the console

            Console.WriteLine("Order numbers in ascending order and print to the console");
            var ascendingOrder = numbers.OrderBy(x => x);
            foreach(var x in ascendingOrder) { Console.WriteLine(x); }

            //TODO: Order numbers in decsending order and print to the console

            Console.WriteLine("Order numbers in decsending order and print to the console");
            var descendingOrder = numbers.OrderByDescending(x => x);
            foreach (var x in descendingOrder) { Console.WriteLine(x); }

            //TODO: Print to the console only the numbers greater than 6
            
            Console.WriteLine("Print to the console only the numbers greater than 6");
            var greaterThanSix = numbers.Where(x => x > 6);
            foreach (var x in greaterThanSix) { Console.WriteLine(x); }

            //TODO: Order numbers in any order (acsending or desc) but only print 4 of them **foreach loop only!**

            Console.WriteLine("Order numbers in any order (acsending or desc) but only print 4 of them **foreach loop only!**");
            var fourOrderedNumbers = numbers.OrderBy(x => x).Take(4);
            foreach (var x in fourOrderedNumbers) { Console.WriteLine(x); }

            //TODO: Change the value at index 4 to your age, then print the numbers in decsending order

            Console.WriteLine("Change the value at index 4 to your age, then print the numbers in decsending order");
            var indexFourIsAge = numbers;
            indexFourIsAge[4] = 21;
            foreach (int x in indexFourIsAge.OrderByDescending(x => x)) { Console.WriteLine(x); }

            // List of employees ****Do not remove this****
            var employees = CreateEmployees();

            //TODO: Print all the employees' FullName properties to the console only if their FirstName starts with a C OR an S and order this in ascending order by FirstName.

            Console.WriteLine("Print all the employees' FullName properties to the console only if their FirstName starts with a C OR an S and order this in ascending order by FirstName.");
            var firstNameListCorS = employees.Where(name => name.FirstName[0] == 'S' || name.FirstName[0] == 'C').OrderBy(x => x.FirstName);
            foreach(var employee in firstNameListCorS) { Console.WriteLine(employee.FullName); }

            //TODO: Print all the employees' FullName and Age who are over the age 26 to the console and order this by Age first and then by FirstName in the same result.

            Console.WriteLine("Print all the employees' FullName and Age who are over the age 26 to the console and order this by Age first and then by FirstName in the same result.");
            var employersTwentySixNamedOrder = employees.Where(employee => employee.Age > 26).OrderBy(employee => employee.FirstName).OrderBy(employee => employee.Age);
            foreach (var employee in employersTwentySixNamedOrder) { Console.WriteLine(employee.FullName + " " + employee.Age); }

            //TODO: Print the Sum and then the Average of the employees' YearsOfExperience if their YOE is less than or equal to 10 AND Age is greater than 35.

            Console.WriteLine("Print the Sum and then the Average of the employees' YearsOfExperience if their YOE is less than or equal to 10 AND Age is greater than 35.");
            var sumAndAverageOfEmployees = employees.Where(employee => employee.Age > 35).Where(employee => employee.YearsOfExperience <= 10);
            Console.WriteLine("Sum: " + sumAndAverageOfEmployees.Sum(x => x.Age));
            Console.WriteLine("Sum: " + sumAndAverageOfEmployees.Average(x => x.Age));

            //TODO: Add an employee to the end of the list without using employees.Add()

            Console.WriteLine("Add an employee to the end of the list without using employees.Add()");
            employees.Insert(employees.Count, new Employee("Dwayne", "Carter", 35, 9));
            Console.WriteLine(employees[(employees.Count-1)].FullName);

            Console.WriteLine();

            Console.ReadLine();
        }

        #region CreateEmployeesMethod
        private static List<Employee> CreateEmployees()
        {
            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee("Cruz", "Sanchez", 25, 10));
            employees.Add(new Employee("Steven", "Bustamento", 56, 5));
            employees.Add(new Employee("Micheal", "Doyle", 36, 8));
            employees.Add(new Employee("Daniel", "Walsh", 72, 22));
            employees.Add(new Employee("Jill", "Valentine", 32, 43));
            employees.Add(new Employee("Yusuke", "Urameshi", 14, 1));
            employees.Add(new Employee("Big", "Boss", 23, 14));
            employees.Add(new Employee("Solid", "Snake", 18, 3));
            employees.Add(new Employee("Chris", "Redfield", 44, 7));
            employees.Add(new Employee("Faye", "Valentine", 32, 10));

            return employees;
        }
        #endregion
    }
}
