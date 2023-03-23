class Program
{
    static void Main()
    {
        decimal a = 10M;
        decimal b = 3M;
        decimal c = a + b;
        decimal d = a - b;
        decimal e = a * b;
        decimal f = a / b;
        decimal g = a % b;

        System.Console.WriteLine(c);
        System.Console.WriteLine(d);
        System.Console.WriteLine(e);
        System.Console.WriteLine(f);
        System.Console.WriteLine(g);

        //Assignment Operators
        a += 20M;
        System.Console.WriteLine(a);
        a -= 20M;
        System.Console.WriteLine(a);
        a *= 3M;
        System.Console.WriteLine(a);
        a /= 3M;
        System.Console.WriteLine(a);
        a %= 3M;
        System.Console.WriteLine(a);

        //Increment/Decrement Operators
        a = 10M;
        System.Console.WriteLine();
        System.Console.WriteLine(++a);
        System.Console.WriteLine(a++);
        System.Console.WriteLine(a);
        System.Console.WriteLine(--a);
        System.Console.WriteLine(a--);
        System.Console.WriteLine(a);

        //Comparison Operators
        System.Console.WriteLine();
        bool b1 = a == 10;
        System.Console.WriteLine(b1);
        bool b2 = a != 10;
        System.Console.WriteLine(b2);
        bool b3 = a<10;
        System.Console.WriteLine(b3);
        bool b4 = a > 10;
        System.Console.WriteLine(b4);
        bool b5 = a<= 10;
        System.Console.WriteLine(b5);
        bool b6 = a>= 10;
        System.Console.WriteLine(b6);

        //logical Operators
        System.Console.WriteLine();
        bool b7 = a == 10 & b == 10; //output - false
        System.Console.WriteLine(b7);
        bool b8 = a == 10 && b == 10; //output - false
        System.Console.WriteLine(b8);
        bool b9 = a == 10 | b == 10; 
        System.Console.WriteLine(b9); //output - true;
        bool b10 = a == 10 || b== 10;
        System.Console.WriteLine(b10); //output - true;
        bool b11 = !(a == 10);
        System.Console.WriteLine(b11);  //output - false;
        bool b12 = a == 10 ^ b == 10;
        System.Console.WriteLine(b12); //output - true

        //concatenation Operator
        string name = "Scott";
        int age = 20;
        string message = "Hey " + name + ", your age is " + age + ".";
        System.Console.WriteLine(message);

        //ternary operator
        string title = (age < 13) ? "Child" : (age >= 13 && age <= 19) ? "Teenager" : "Adult";
        System.Console.WriteLine(title);

        //operator precedence
        double z = 10 + 4 * 30 / 10;
        System.Console.WriteLine(z);

        System.Console.ReadKey();


    }
}