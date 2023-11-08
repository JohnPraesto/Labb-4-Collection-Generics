using System.Reflection;
using System.Security.Cryptography;
using System.Xml.Linq;
using static System.Console; // Hämtar jag Console här behöver jag inte skriva det där nere hela tiden!!

            //===========================//
            //    JOHN PRAESTO SUT-23    //
            //===========================//

namespace Labb_4_Collection_Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp1 = new Employee(001, "Gordon", true, 60000);
            Employee emp2 = new Employee(002, "Esmeralda", false, 25000);
            Employee emp3 = new Employee(003, "Rener", true, 30000);
            Employee emp4 = new Employee(004, "Spencer", true, 220000);
            Employee emp5 = new Employee(005, "Sarah", false, 42000);

            while (true)
            {
                Clear();
                WriteLine("To see Stack enter 1\nTo see List enter enything else");
                string selection = ReadLine();
                Clear();
                if (selection == "1")
                {
                    Stack<Employee> employees = new Stack<Employee>();

                    employees.Push(emp1);
                    employees.Push(emp2);
                    employees.Push(emp3);
                    employees.Push(emp4);
                    employees.Push(emp5); // Kan man pusha in dessa i nån sorts loop?

                    WriteLine("Listing empolyees in stack without removing them. (ToString method)\n");
                    WriteLine($"{"ID",-5}{"NAME",-10}{"GENDER",-10}{"SALARY",-10}{"STACK SIZE",-10}\n");
                    foreach (Employee item in employees)
                    {
                        Write(item.ToString());
                        WriteLine(employees.Count());
                    }

                    WriteLine("\nListing empolyees in stack and removing them. (Push method)\n");
                    while (employees.Count > 0)
                    {
                        Write(employees.Pop());
                        WriteLine(employees.Count());
                    }

                    employees.Push(emp1);
                    employees.Push(emp2);
                    employees.Push(emp3);
                    employees.Push(emp4);
                    employees.Push(emp5);

                    WriteLine("\nLooking at top of stack without removing. (Peek method)\n");

                    Write(employees.Peek());
                    WriteLine(employees.Count());
                    Write(employees.Peek());
                    WriteLine(employees.Count());

                    WriteLine("\nChecking if emp3 is in stack. (Contains method)\n");

                    if (employees.Contains(emp3))
                        WriteLine("emp3 is in stack");
                    else
                        WriteLine("emp3 is not in stack");

                    WriteLine("\nPress Enter to return to menu");
                    ReadLine();
                }
                else
                {
                    List<Employee> empList = new List<Employee>() { emp1, emp2, emp3, emp4, emp5 };

                    WriteLine("\nChecking if emp2 is in list (Contains method):");

                    if (empList.Contains(emp2))
                        WriteLine("Employee 2 exists in the list");
                    else
                        WriteLine("Employee 2 does not exist in the list");

                    WriteLine("\nPrinting first male in the list (Find method):");

                    Employee.IsMaleOne(empList);

                    WriteLine("\nPrinting all males in the list (FindAll method):");

                    Employee.IsMaleAll(empList);

                    WriteLine("\nPress Enter to return to menu");
                    ReadLine();
                }
            }
        }
    }
}