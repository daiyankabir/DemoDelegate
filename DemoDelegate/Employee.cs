using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoDelegate
{
    public delegate bool IsPromotable(Employee emp);


    public class Employee
    {        
        public int ID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public int Age { get; set; }
        public int Experience { get; set; }

        public static void Promoteemployee(List<Employee> employeeList, IsPromotable IP)
        {
            foreach (Employee emp in employeeList)
            {
                if (IP(emp))
                {
                    Console.WriteLine(emp.Name+" is Promoted!!");
                }
            }
        }
    }
}
