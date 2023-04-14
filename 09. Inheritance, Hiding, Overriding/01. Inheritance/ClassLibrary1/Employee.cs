public class Employee
{
    //fields
    private int _empID;
    private string _empName;
    private string _location;

    //properties
    public int EmpID
    {
        get { return _empID; }
        set { _empID = value; }
    }
    public string EmpName
    {
        get { return _empName; }
        set { _empName = value; }
    }
    public string Location
    {
        get { return _location; }
        set { _location = value; }
    }
}