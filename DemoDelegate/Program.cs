using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoDelegate
{
    //Set the definition
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> emp = new List<Employee>();
            emp.Add(new Employee() { ID = 101, Name = "Zahid", Salary = 100000, Age = 18, Experience = 33 });
            emp.Add(new Employee() { ID = 102, Name = "Alamin", Salary = 10000, Age = 28, Experience = 4 });
            emp.Add(new Employee() { ID = 103, Name = "Asif", Salary = 100000, Age = 38, Experience = 5 });
            emp.Add(new Employee() { ID = 104, Name = "Ahmed", Salary = 15000, Age = 48, Experience = 5 });
            emp.Add(new Employee() { ID = 105, Name = "Mohaimen", Salary = 31000, Age = 180, Experience = 30 });

            IsPromotable p = new IsPromotable(Promote);
            Employee.Promoteemployee(emp,p);

            
           
            Console.ReadKey();
        }

        public static bool Promote(Employee emp)
        {
            if (emp.Experience > 5)
                return true;
            return false;
        }
    }
}
