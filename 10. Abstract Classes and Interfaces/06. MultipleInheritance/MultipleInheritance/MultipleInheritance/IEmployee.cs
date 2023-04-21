//interface
public interface IEmployee
{
    //abstract method
    string GetHealthInsuranceAmount();

    //auto-properties
    int EmpID { set; get; }
    string EmpName { set; get; }
    string Location { set; get; }
}