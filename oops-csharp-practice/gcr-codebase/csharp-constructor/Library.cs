using System;

class ReadItem
{
    public string uniqueCode;
    protected string itemName;
    private string writerName;

    public ReadItem(string code, string name, string writer)
    {
        this.uniqueCode = code;
        this.itemName = name;
        this.writerName = writer;
    }

    public string FetchWriter() => writerName;
    public void ModifyWriter(string w) => writerName = w;
}

class OnlineRead : ReadItem
{
    public double memorySize;

    public OnlineRead(string code, string name, string writer, double size) : base(code, name, writer)
    {
        this.memorySize = size;
    }

    public void PrintOnlineRead()
    {
        Console.WriteLine($"Digital Read: {itemName} | Code: {uniqueCode} | Space: {memorySize} MB");
    }
}

class StartPoint
{
    public static void Main()
    {
        OnlineRead obj = new OnlineRead("ID-5567", "Dotnet Guide", "Robert", 2.3);
        obj.PrintOnlineRead();
        Console.WriteLine("Writer: " + obj.FetchWriter());
    }
}
