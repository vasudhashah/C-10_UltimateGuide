public partial class Product
{
    private int _productID;
    public int ProductID { get; set; }

    //declaration of partial method
    partial void GetTax();
   
}