class FileType
{
    public string ? Extension, Description;

    public void ShowType()
    {
        Console.WriteLine("\n--- Type Details ---");
        Console.WriteLine("Type   :" + Extension);
    }

    public void ShowType(string title)
    {
        Console.WriteLine("\n---" + title + "---");
        ShowType();
    }
}