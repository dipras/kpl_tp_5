
// Class generic DataGeneric
public class DataGeneric<T>
{
    public T data;
    public DataGeneric(T data)
    {
        this.data = data;
    }
    public void PrintData()
    {
        Console.WriteLine($"Data yang tersimpan adalah: {data}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        var data = new DataGeneric<string>("SE0702");
        data.PrintData();
    }
}
Console.WriteLine("Hello, World!");
