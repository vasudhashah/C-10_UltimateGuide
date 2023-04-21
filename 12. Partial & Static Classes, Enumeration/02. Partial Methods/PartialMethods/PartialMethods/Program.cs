using System.Net.Http.Headers;

class Program
{
    static void Main()
    {
        //create object of Partial Class
        Product product = new Product();
        product.ProductID = 101;
        product.Cost = 1000;
        product.CallGetTax();

        System.Console.ReadKey();
    }
}