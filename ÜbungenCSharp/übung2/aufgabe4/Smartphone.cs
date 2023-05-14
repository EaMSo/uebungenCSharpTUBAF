using System;
public class Smartphone
{
    private int? Pin;
    private int fehlversuche;
    private bool AuthentifizierungPin()
    {
        if(Pin==null)
        return true;
        int passwort = 0;
        string? vorpasswort;
        while(fehlversuche<3)
        {
            System.Console.WriteLine("Gebe Pin ein:");
            try
            {
                passwort = Int32.Parse(Console.ReadLine());
            }
            catch(System.FormatException)
            {
                System.Console.WriteLine("Pin besteht nur aus Zahlen!");
                continue;
            }
            if(this.Pin==passwort)
            {
                fehlversuche = 0;
                return true;
            }
            fehlversuche++;
            Console.WriteLine("Falscher Pin! Noch {0} Versuche!", 3-fehlversuche);
        }
        System.Console.WriteLine("Passwort zu oft falsch eingeben, Handy gesperrt!");
        return false;
    }
    public void PinÄndern()
    {
        string? vorpasswort;
        if(AuthentifizierungPin() == true)
        {
            while(true)
            {
                System.Console.WriteLine("Gebe neue Pin ein:");
            try
            {
                vorpasswort = Console.ReadLine();
                if(vorpasswort=="")
                {
                    this.Pin = null;
                    return;
                }
                this.Pin = Int32.Parse(vorpasswort);
                return;
            }
            catch(System.FormatException)
            {
                System.Console.WriteLine("Pin darf nur aus Zahlen bestehen!");
                continue;
            }
            } 
        }
    }
    public void PinAusgeben()
    {
        if(this.Pin == null)
        System.Console.WriteLine("Keine Pin");
        else
        System.Console.WriteLine("Die Pin ist: {0}",this.Pin);
    }
}