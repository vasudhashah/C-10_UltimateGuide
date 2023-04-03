class Program
{
    static void Main()
    {
        //create three objects for Employee
        Employee emp1 = new Employee(); 
        emp1.EmpID = 10;
        emp1.EmpName = "Scott";
        emp1.Job = "Manager";
        emp1.Tax = 50;

        System.Console.WriteLine("\nFirst employee:");
        System.Console.WriteLine(emp1.EmpID);
        System.Console.WriteLine(emp1.EmpName);
        System.Console.WriteLine(emp1.Job);
        System.Console.WriteLine(emp1.Salary);
        System.Console.WriteLine(emp1.CalculateNetSalary());
        System.Console.ReadKey();
    }
}