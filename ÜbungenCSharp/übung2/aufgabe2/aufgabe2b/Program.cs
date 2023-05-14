using System;

class Program
{
    static void Main()
    {
        var hades = new Energiewesen("Hades", 1223345, Energiewesen.Kategorie.UNKNOWN, 10.1325);
        var jannik = new Energiewesen();
        hades.Print();
        Console.WriteLine(hades.Bezeichnung);
        System.Console.WriteLine(hades.Registernummer);
        jannik.Bezeichnung = "Jannik";
        jannik.Print();
    }
}
