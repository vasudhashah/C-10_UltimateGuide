public class Employee
{
    //instance fields
    private int _empID;
    private string _empName;
    private string _job;
    private double _salary;
    private double _tax;

    public int EmpID { get { return _empID; } set { _empID = value; } }
    public string EmpName { get { return _empName; } set { _empName = value; } }
    public string Job { get { return _job; } set { _job = value; } }

    //constructor 3
    public Employee()
    {
        _empID = 1;
        this._salary = 1000;
    }

    //readonly property
    public double Salary
    {
        get
        {
            return _salary;
        }
    }

    //writeonly property
    public double Tax
    {
        set
        {
            if (value >= 0 && value <= 100)
            {
                _tax = value;
            }
        }
    }

    //method
    public double CalculateNetSalary()
    {
        double t = Salary - _tax;
        return t;
    }
}