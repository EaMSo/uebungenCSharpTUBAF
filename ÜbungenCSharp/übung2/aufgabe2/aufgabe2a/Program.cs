class Program
{
    static void Main()
    {
        Energiewesen hades = new Energiewesen();
        Energiewesen mado = new Energiewesen();
        Energiewesen detectiv = new Energiewesen();
        
        mado.SetInformation("Mado", 123, Energiewesen.Kategorie.ELEKTRO, 10.5);
        hades.SetInformation("Hades", 12321, Energiewesen.Kategorie.THERMO, 10.123);
        detectiv.SetInformation("Shady");

        Console.WriteLine(hades.Print());
        Console.WriteLine();
        Console.WriteLine(mado.Print());
        Console.WriteLine();
        Console.WriteLine(detectiv.Print());
        Console.WriteLine(hades.GetRegisternummer());
    }
}
