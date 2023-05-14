using System;
using System.IO;
using System.Globalization;
 
class Datentypen 
{
     
    // Main Method
    static void Main()
    {
        string? bezeichnung;
        string? registernummer;
        char klasse;
        string? klass;
        string? leuchtkraft;
        double leucht;
        int n;

        //Eingabe Bezeichung
        Console.WriteLine("Gebe Bezeichnung ein: ");
        bezeichnung = Console.ReadLine();
        Console.Clear();
        while(bezeichnung == null || bezeichnung.Length <2 )
        {
            Console.WriteLine("Falsche eingabe! Gebe eine Bezeichnung ein!: " );
            bezeichnung = Console.ReadLine();
            Console.Clear();
        }

        //Eingabe Registernummer mit Überprüfung ob 5 Stellige Zahl eingegeben wurde
        Console.WriteLine("Gebe Registernummer ein(5 Stellen): ");
        registernummer = Console.ReadLine();
        Console.Clear();
        while((registernummer is not null && 5 != registernummer.Length) || false == Int32.TryParse(registernummer, out n))
        {
            Console.WriteLine("Gebe eine 5 Stellige Registernummer ein!: ");
            registernummer = Console.ReadLine();  
            Console.Clear();
        }

        //Eingabe Kategorie mit Überprüfung ob A, B oder C eingegeben wurde
        Console.WriteLine("Gebe Kategorie A,B oder C an!: ");
        klass = (Console.ReadLine());
        Console.Clear();
        while(klass != "a" && klass != "b" && klass !="c"&& klass != "A" && klass != "B" && klass !="C")
        {
            Console.WriteLine("Falsche eingabe! Gebe A, B oder C an!: " );
            klass = (Console.ReadLine());
            Console.Clear();
        }
        klasse = Convert.ToChar(klass);
    	Console.Clear();
       
        //Eingabe Leuchtkraft mit Überprüfung ob Double eingegeben wurde
        Console.WriteLine("Gebe Leuchtkraft ein: ");
        leuchtkraft = Console.ReadLine();
        while(!(double.TryParse(leuchtkraft, out leucht)))
        {
            Console.WriteLine("Gebe Leuchtkraft ein(Kommazahl): ");
            leuchtkraft = Console.ReadLine();  
        }

        //Ausgabe Daten
        Console.Clear();
        Console.WriteLine("Die Daten sind: ");
        Console.WriteLine(bezeichnung);
        Console.WriteLine(registernummer);
        Console.WriteLine(Char.ToUpper(klasse));
        Console.WriteLine("{0:N}", leucht);
    }
}