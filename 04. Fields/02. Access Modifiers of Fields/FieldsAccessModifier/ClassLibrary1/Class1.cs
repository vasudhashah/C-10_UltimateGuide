public class Product
{
    //fields
    private int productId;
    protected string productName;
    protected internal double cost;
    public int quantityInStock;
}

//child class at same assembly
public class DomesticProduct : Product
{
    public void Method1()
    {
        //productId = 1 not valid
        productName = "abc"; //accessible
        cost = 100; //accessible
        quantityInStock = 1; //accessible
    }
}

//Other class at same Assembly
public class OtherClass
{
    public void Method1()
    {
        Product product = new Product();
        //product.productID = 1; not valid
        //product.productName = "abc"; not valid
        product.cost = 2000; //accessible
        product.quantityInStock = 1;

    }
}