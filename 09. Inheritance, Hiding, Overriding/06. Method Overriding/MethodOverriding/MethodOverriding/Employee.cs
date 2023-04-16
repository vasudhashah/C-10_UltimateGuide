public class Employee
{
    //fields
    private int _empID;
    private string _empName;
    protected string _location;

    //constructor of parent class
    public Employee(int empId, string empName, string location)
    {
        _empID = empId;
        _empName = empName;
        _location = location;
    }

    //virtual method
    public virtual string GetHealthInsuranceAmount()
    {
        return "Health Insurance amount is: " + 500;
    }

    //properties
    public int EmpID
    {
        set
        {
            _empID = value;
        }
        get
        {
            return _empID;
        }
    }

    public string EmpName
    {
        set
        {
            _empName = value;
        }
        get
        {
            return _empName;
        }
    }

    public string Location
    {
        set
        {
            _location = value;
        }
        get
        {
            return _location;
        }
    }
}