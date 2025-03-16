// See https://aka.ms/new-console-template for more information

public class HaloGeneric
{
    public void SapaUser<T>(T user)
    {
        Console.WriteLine("Halo user " + user);
    }
}

public class Program
{
    public static void Main()
    {
        HaloGeneric sapa = new HaloGeneric();
        sapa.SapaUser("Rafa");
    }
}