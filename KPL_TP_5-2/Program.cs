// Class generic HaloGeneric
public class HaloGeneric
{
    public void SapaUser<T>(T user)
    {
        Console.WriteLine($"Halo user {user}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        var halo = new HaloGeneric();
        halo.SapaUser("Aldy"); // Nama panggilan praktikan
    }
}
