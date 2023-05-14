using System;

public class Customer
{
        private double Geld;
        private string Kundenname;
        private string Passwort;

        public Customer(double geld, string name, string passwort)
        {
            Geld = geld;
            Kundenname = name;
            Passwort = passwort;   
        }

        public void bezahlen(double kosten)
        {
            string? eingabe;
            int k = 0;
            do{
            System.Console.WriteLine("Zum bezahlen Passwort eingeben!:");
            eingabe = Console.ReadLine();
            if(eingabe == this.Passwort)
            {
            break;
            }
            k++;
            }while(k<3);
            if(eingabe != this.Passwort)
            {
            System.Console.WriteLine("Passwort zu oft falsch eingegeben Alamiere Polizei!");
            return;
            }
            this.Geld -= kosten;
        }
        public void kontostand()
        {
            Console.WriteLine("Kontostand: {0:F2}EUR", this.Geld);
        }
}


