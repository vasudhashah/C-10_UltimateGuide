public class Manager: Employee
{
    public string DepartmentName { get; set; }

    public long GetTotalSalesOfTheYear()
    {
        return 1000;

    }
    public string GetFullDepartmentName()
    {
        return DepartmentName + " at " + base.Location;
    }
}