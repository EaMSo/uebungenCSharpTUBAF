using System;

class Energiewesen
{
    private string? bezeichung;
    private int registernummer;
    private Kategorie kategorie;
    private double leistung;
    
    public enum Kategorie
    {
        ELEKTRO,
        THERMO,
        NONE,
        UNKNOWN
    }
    public void SetInformation(string bezeichung, int registernummer, Kategorie kategorie, double leistung)
    {
        this.bezeichung = bezeichung;
        this.registernummer = registernummer;
        this.kategorie = kategorie;
        this.leistung = leistung;
    }
    public void SetInformation(string bezeichung)
    {
        this.bezeichung = bezeichung;
        this.registernummer = 0;
        this.kategorie = Kategorie.UNKNOWN;
        this.leistung = 0;
       
    }
    public void SetInformation()
    {
        this.bezeichung = "unknown";
        this.registernummer = 0;
        this.kategorie = Kategorie.UNKNOWN;
        this.leistung = 0;
       
    }
    public string? GetBezeichnung()
    {
        return this.bezeichung;
    }
     public int GetRegisternummer()
    {
        return this.registernummer;
    }
    public Kategorie GetKategorie()
    {
        return this.kategorie;
    }
    public double GetLeistung()
    {
        return this.leistung;
    }
    public string Print()
    {
        return $"Bezeichung: {bezeichung}\nRegisternummer: {registernummer}\nKategorie: {kategorie}\nLeistung: {leistung}";
    }
}
