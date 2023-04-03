class Program
{
    static void Main()
    {
        Car c = new Car();

        //call get accessor of indexer
        System.Console.WriteLine(c[0]); //Output : BMW
        System.Console.WriteLine(c["first"]); 

        //call set accessor of Index
        c[0] = "Nissan";
        System.Console.WriteLine(c[0]);
        System.Console.ReadKey();
    }
}