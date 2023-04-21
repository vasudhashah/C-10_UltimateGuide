public partial class Product
{
    private double _cost;
    public double Cost { get; set; }
    //public method to call partial method
    public void CallGetTax()
    {
        GetTax();
    }
}