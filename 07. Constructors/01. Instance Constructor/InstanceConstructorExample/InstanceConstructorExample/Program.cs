class Program
{
    static void Main()
    {
        //create three objects for Employee
        Employee emp1 = new Employee(101, "Vasudha", "Manager");
        Employee emp2 = new Employee(102, "Vanshika", "Ast. Manager");
        Employee emp3 = new Employee(103, "Anjali", "Clerk");

        //display fields
        System.Console.WriteLine("First Employee:");
        System.Console.WriteLine(emp1.empID);
        System.Console.WriteLine(emp1.empName);
        System.Console.WriteLine(emp1.job);
        System.Console.WriteLine();

        System.Console.WriteLine("Second employee");
        System.Console.WriteLine(emp2.empID);
        System.Console.WriteLine(emp2.empName);
        System.Console.WriteLine(emp2.job);

        System.Console.WriteLine("Third employee");
        System.Console.WriteLine(emp3.empID);
        System.Console.WriteLine(emp3.empName);
        System.Console.WriteLine(emp3.job);
        System.Console.WriteLine();

        System.Console.ReadKey();
    }
}