public class Manager: Employee
{
    private string _departmentName;

    public Manager(int empID, string empName, string location, string departmentName): base(empID, empName, location)
    {
        this._departmentName = departmentName;
    }
    public string DepartmentName
    {
        set
        {
            _departmentName = value;
        }
        get
        {
            return _departmentName;
        }
    }

    //method
    public long GetTotalSalesOfTheYear()
    {
        return 10000;
    }

    //method
    public string GetFullDepartmentName()
    {
        return _departmentName + " at " + base._location;
    }
}