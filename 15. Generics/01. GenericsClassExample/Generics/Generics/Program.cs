class Program
{
    static void Main()
    {
        //create user of generic class
        User<int> user1 = new User<int>();
        User<bool> user2 = new User<bool>();

        //set value into generic field
        user1.RegistrationStatus = 1234;
        user2.RegistrationStatus = false;

        System.Console.WriteLine(user1.RegistrationStatus);
        System.Console.WriteLine(user2.RegistrationStatus);

        //multiple generic parameters
        Customer<int, int> customer1 = new Customer<int, int>();
        Customer<bool, string> customer2 = new Customer<bool, string>();

        customer1.Age = 22;
        customer2.Age = "35 - 40";

        System.Console.WriteLine(customer1.LoginStatus);
        System.Console.WriteLine(customer2.LoginStatus);

        System.Console.WriteLine(customer1.Age);
        System.Console.WriteLine(customer2.Age);

        System.Console.ReadKey();
    }
}