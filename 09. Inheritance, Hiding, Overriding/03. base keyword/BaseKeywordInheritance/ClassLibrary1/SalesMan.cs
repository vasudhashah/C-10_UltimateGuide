public class SalesMan: Employee
{
    public string Region { get; set; }
    public long GetSalesOfTheCurrentMonth()
    {
        return 1000;
    }
}