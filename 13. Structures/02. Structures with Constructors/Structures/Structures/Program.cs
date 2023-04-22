using System;

class Program
{
    static void Main()
    {
        Category category = new Category(20, "General");
        Console.WriteLine(category.CategoryID);
        Console.WriteLine(category.CategoryName);
        Console.WriteLine(category.GetCategoryNameLength());

        Console.ReadKey();
    }
}