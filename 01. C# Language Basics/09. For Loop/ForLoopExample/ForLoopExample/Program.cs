class Program
{
    static void Main()
    {
        //1 to 10
        for(int i=1; i<=10; i++)
        {
            System.Console.Write(i+" ");
        }
        System.Console.WriteLine();

        //nested for loop
        for(int i=1; i <= 5; i++)
        {
            for(int j = 1;j <= i; j++)
            {
                System.Console.Write(j);
                System.Console.Write(" ");
            }
            System.Console.WriteLine();
        }
        System.Console.ReadKey();
    }
}