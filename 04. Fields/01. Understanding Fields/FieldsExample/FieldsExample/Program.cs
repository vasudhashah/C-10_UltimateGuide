
public class Sample
{
    static void Main()
    {
        //create reference variables
        Product product1, product2, product3;

        //create objects
        product1 = new Product();
        product2 = new Product();
        product3 = new Product();

        //initialize fields
        product1.productID = 101;
        product1.productName = "Mobile";
        product1.cost = 20000;
        product1.quantityInStock = 120;

        product2.productID = 102;
        product2.productName = "Laptop";
        product2.cost = 30000;
        product2.quantityInStock = 150;

        product3.productID = 103;
        product3.productName = "TV";
        product3.cost = 10000;
        product3.quantityInStock = 100;

        //get values from fields
        System.Console.WriteLine("Product 1");
        System.Console.WriteLine("Product ID: " + product1.productID);
        System.Console.WriteLine("Product Name: "+product1.productName);
        System.Console.WriteLine("Cost: "+product1.cost);
        System.Console.WriteLine("Quantity in Stock"+ product1.quantityInStock);

        System.Console.WriteLine("Product 2");
        System.Console.WriteLine("Product ID: " + product2.productID);
        System.Console.WriteLine("Product Name: " + product2.productName);
        System.Console.WriteLine("Cost: " + product2.cost);
        System.Console.WriteLine("Quantity in Stock" + product2.quantityInStock);

        System.Console.WriteLine("Product 3");
        System.Console.WriteLine("Product ID: " + product3.productID);
        System.Console.WriteLine("Product Name: " + product3.productName);
        System.Console.WriteLine("Cost: " + product3.cost);
        System.Console.WriteLine("Quantity in Stock" + product3.quantityInStock);

        System.Console.ReadKey();
    }
}