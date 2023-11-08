using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_4_Collection_Generics
{
    internal class Employee
    {
        private int _id;
        private string _name;
        private bool _isMale;
        private int _salary;
        public Employee(int id, string name, bool isMale, int salary)
        {
            _id = id;
            _name = name;
            _isMale = isMale;
            _salary = salary;
        }
        public override string ToString()
        {
            string gender = IsMale(_isMale);
            return $"{_id, -5}{_name,-10}{gender,-10}{_salary,-10}"; // Siffrorna avgör avståndet mellan utskrifterna. Minus betyder left alignt, inte minus betuder right aligned.
        }
        public static string IsMale(bool _isMale)
        {
            if (_isMale)
                return "Male";
            else
                return "Female";
        }
        public static void IsMaleOne(List<Employee> empList)
        {
            Employee findMale = empList.Find(e => e._isMale == true);
            Console.WriteLine(findMale.ToString()) ;
        }
        public static void IsMaleAll(List<Employee> empList)
        {
            List<Employee> findMales = new List<Employee>();
            findMales = empList.FindAll(e => e._isMale == true);
            foreach (Employee item in findMales)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}
