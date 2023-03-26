﻿class Program
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
        if (username != null)
        {
            System.Console.Write("Password: ");
            password = System.Console.ReadLine();
        }

        //check username and password
        if (username == "system" && password == "manager")
        {
            //declare variable to store menu choice
            int mainMenuChoice = -1;

            do
            {
                //show main menu
                System.Console.WriteLine("\n:::Main Menu:::");
                System.Console.WriteLine("1. Customers");
                System.Console.WriteLine("2. Accounts");
                System.Console.WriteLine("3. Funds Transfer");
                System.Console.WriteLine("4. Funds Transfer Statement");
                System.Console.WriteLine("5. Account Statement");
                System.Console.WriteLine("0. Exit");

                //accept menu from Keyboard
                System.Console.Write("Enter Choice: ");
                mainMenuChoice = int.Parse(System.Console.ReadLine());

                //switch-case to check menu choice
                switch (mainMenuChoice)
                {
                    case 1: 
                        CustomersMenu();
                        break;
                    case 2:
                        AccountsMenu();
                        break;
                    case 3: //TO DO: Display funds transfer menu
                        break;
                    case 4: //TO DO: Display funds transfer statement menu
                        break;
                    case 5: //TO DO: Display account statement menu
                        break;
                }

            } while (mainMenuChoice != 0);

        }
        else
        {
            System.Console.WriteLine("Invalid Username or Password");
        }

        //about to exit
        System.Console.WriteLine("Thank you! Visit again");
        System.Console.ReadKey();
    }

    static void CustomersMenu()
    {
        //variable to store customers menu choice
        int customerMenuChoice = -1;

        //do-while loop starts
        do
        {
            //print customers menu
            System.Console.WriteLine("\n:::Customers menu:::");
            System.Console.WriteLine("1. Add Customer");
            System.Console.WriteLine("2. Delete Customer");
            System.Console.WriteLine("3. Update Customer");
            System.Console.WriteLine("4. View Customers");
            System.Console.WriteLine("0. Back to Main Menu");

            //accept customers menu choice
            System.Console.Write("Enter choice: ");
            customerMenuChoice = System.Convert.ToInt32(System.Console.ReadLine());
        } while (customerMenuChoice != 0);
    }

    static void AccountsMenu()
    {
        //variable to store accounts menu choice
        int accountsMenuChoice = -1;

        //do-while loop starts
        do
        {
            //print  accounts menu
            System.Console.WriteLine("\n:::Accounts menu:::");
            System.Console.WriteLine("1. Add Account");
            System.Console.WriteLine("2. Delete Account");
            System.Console.WriteLine("3. Update Account");
            System.Console.WriteLine("4. View Accounts");
            System.Console.WriteLine("0. Back to Main Menu");

            //accept accounts menu choice
            System.Console.Write("Enter choice: ");
            accountsMenuChoice = System.Convert.ToInt32(System.Console.ReadLine());
        } while (accountsMenuChoice != 0);
    }
}