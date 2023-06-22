class Employee
{
    public int EmpID { get; set; }
    public string EmpName { get; set; }
}

class Program
{
    static void Main()
    {
        Employee[] employees = new Employee[] {
        new Employee(){EmpID = 101, EmpName = "Vasudha"},
        new Employee(){EmpID = 102, EmpName = "SHah"},
        new Employee(){EmpID = 103, EmpName = "John"}
        };

        foreach (Employee item in employees)
        {
            if (item.EmpID >= 102)
            {
                Console.WriteLine(item.EmpID + ", " + item.EmpName);
            }
        }

        Console.ReadKey();
    }
}