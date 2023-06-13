using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqExample
{
    class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Job { get; set; }
        public string City { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>() { 
            new Employee(){ Id=101, Name= "Henry", Job = "Teacher", City="Japan"},
            new Employee(){ Id=102, Name= "Sinchan", Job="Comedian", City="Tokyo"},
            };

            IEnumerable<Employee> result = employees.Where(emp => emp.City == "Tokyo");
            foreach(Employee emp in result)
            {
                Console.WriteLine(emp.Id + ", " + emp.Name);
            }
            Console.ReadKey();
        }
    }
}
