using FrontOffice;
using HR.Mgr;
using System.Security.Policy;

class Program
{
    static void Main()
    {
        IManager manager1 = new Manager();
        IManager manager2 = new Manager();
        IManager manager3 = new Manager();

        FrontOfficeExecutive frontOfficeExecutive = new FrontOfficeExecutive();
        System.Console.ReadKey();
    }
}