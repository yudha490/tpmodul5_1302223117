public class HaloGeneric
{
    public void SapaUser<T>(T X)
    {
        Console.WriteLine($"Halo user {X}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        HaloGeneric halo = new HaloGeneric();

        halo.SapaUser("Yudha");

    }
}