class Program
{
    static void Main()
    {
        //variable to store grade letter of student
        char gradeLetter = 'A';
        string gradeDescription;
        switch (gradeLetter)
        {
            case 'O': 
                gradeDescription = "Outstanding"; 
                break;
            case 'A':
                gradeDescription = "Excellent";
                break;
            case 'B':
                gradeDescription = "Good";
                break;
            case 'C':
                gradeDescription = "Fail";
                break;
            case 'F':
                gradeDescription = "Fail";
                break;
            default:
                gradeDescription = "None";
                break;
        }
        System.Console.WriteLine(gradeDescription);
        System.Console.ReadKey();

         
    }
}