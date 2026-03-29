// Class generic HaloGeneric
public class HaloGeneric
{
    public void SapaUser<T>(T user)
    {
        Console.WriteLine($"Halo user {user}");
    }
}

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
        var halo = new HaloGeneric();
        halo.SapaUser("Aldy"); // Nama panggilan praktikan

        var data = new DataGeneric<string>("SE0702");
        data.PrintData();
    }
}
