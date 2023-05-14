using System;

class Energiewesen
{
    public string Bezeichnung { get; set; }
    public int Registernummer { get; set; }
    public Kategorie EnergiewesenKategorie { get; set; }
    public double Leistung { get; set; }

    public enum Kategorie
    {
        ELEKTRO,
        THERMO,
        NONE,
        UNKNOWN
    }

    public Energiewesen(string bezeichnung, int registernummer, Kategorie kategorie, double leistung)
    {
        Bezeichnung = bezeichnung;
        Registernummer = registernummer;
        EnergiewesenKategorie = kategorie;
        Leistung = leistung;
    }
    
    public Energiewesen()
    {
        Bezeichnung = "unknown";
        Registernummer = 0;
        EnergiewesenKategorie = Kategorie.UNKNOWN;
        Leistung = 0;
    }

    public void Print()
    {
        System.Console.WriteLine($"Bezeichnung: {Bezeichnung}\nRegisternummer: {Registernummer}\nKategorie: {EnergiewesenKategorie}\nLeistung: {Leistung}");
    }
}