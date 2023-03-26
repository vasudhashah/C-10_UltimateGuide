class Program
{
    //application starts here
    static void Main()
    {
        //display Title
        System.Console.WriteLine("***** VASUDHA BANK *****");
        System.Console.WriteLine("LOGIN PAGE");

        //declare variables to store username and password
        string username = null, password = null;

        //read username from Keyboard
        System.Console.Write("Username: ");
        username = System.Console.ReadLine();

        //read password from keyboard only if username is entered
        if(username != null)
        {
            System.Console.Write("Password: ");
            password = System.Console.ReadLine();
        }

        //check username and password
        if(username == "system" && password== "manager")
        {
            System.Console.WriteLine("To Do: Main Menu Here");
        }

        //about to exit
        System.Console.WriteLine("Thank you! Visit again");
        System.Console.ReadKey();
    }
}