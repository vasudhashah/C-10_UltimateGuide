public struct Category
{
    public int CategoryID { get; set; }
    public string CategoryName { get; set; }
    public int GetCategoryNameLength()
    {
        return CategoryName.Length;
    }
}