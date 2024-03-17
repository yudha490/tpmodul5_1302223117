public class HaloGeneric
{
    public void SapaUser<T>(T X)
    {
        Console.WriteLine($"Halo user {X}");
    }
}

public class DataGeneric<T>
{
    public T Data { get; set; }

    public DataGeneric(T data)
    {
        Data = data;
    }

    public void PrintData()
    {
        Console.WriteLine($"Data yang tersimpan adalah: {Data}");
    }
}


class Program
{
    static void Main(string[] args)
    {
        HaloGeneric halo = new HaloGeneric();

        halo.SapaUser("Yudha");

        DataGeneric<string> dataString = new DataGeneric<string>("1302223117");
        dataString.PrintData();
    }
}