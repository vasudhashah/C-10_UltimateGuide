class Program
{
    static void Main()
    {
        //Category category = null;
        //can't declare null as structure is non-nullable fields
        
        Category category = new Category();
        category.CategoryID = 10;
        category.CategoryName = "General";

       System.Console.WriteLine(category.CategoryID);
        System.Console.WriteLine(category.CategoryName);
        System.Console.WriteLine(category.GetCategoryNameLength());
        System.Console.ReadKey();

    }
}