class Program
{
    static void Main()
    {
        //declare variable
        int marks = 25;
        char gradeLetter;

        //show congratulations/ failed
        if(marks >= 35)
        {
            System.Console.WriteLine("Congratulations");
        }
        else
        {
            System.Console.WriteLine("Failed");
        }
        System.Console.WriteLine();


        //else if
        if(marks >= 85)
        {
            gradeLetter = 'O';
        }else if(marks >= 60 && marks < 85)
        {
            gradeLetter = 'A';
        }
        else if(marks >= 50 && marks < 60)
        {
            gradeLetter = 'B';
        }
        else if(marks >= 35 && marks < 50)
        {
            gradeLetter = 'C';
        }
        else
        {
            gradeLetter = 'F';
        }
        System.Console.WriteLine(gradeLetter);

        //nested Loops
        System.Console.WriteLine();
        if (marks >= 35)
        {
            if (marks >= 85)
            {
                gradeLetter = 'O';
            }
            else if (marks >= 60 && marks < 85)
            {
                gradeLetter = 'A';
            }
            else if (marks >= 50 && marks < 60)
            {
                gradeLetter = 'B';
            }
            else
            {
                gradeLetter = 'C';
            }
        }
        else
        {
            gradeLetter = 'F';
        }

        System.Console.WriteLine(gradeLetter);

        System.Console.ReadKey();  

    }
}