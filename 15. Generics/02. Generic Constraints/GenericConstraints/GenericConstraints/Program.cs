class Program
{
    static void Main()
    {
        //create object of generic class
        MarksPrinter<GraduateStudent> mp = new MarksPrinter<GraduateStudent>();
        mp.student = new GraduateStudent() { Marks = 80 };
        mp.PrintMarks();
        System.Console.ReadKey();
    }
}