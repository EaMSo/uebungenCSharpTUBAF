using System;
class Programm
{
    static void Main()
    {
        int? jahr = null;
        bool schaltjahr =false;
        string? n;
        while(true)
        {
        while(true)
        {
            Console.WriteLine("Jahr eingeben:");
            n = Console.ReadLine();
            try
            {
                jahr = Convert.ToInt32(n);
                break;
            }
            catch(FormatException)
            {
                 if(n== "")
                {
                    	break;
                }
                Console.WriteLine("Wrong input!");
            }
        }
        if(n == "")
        {
            break;
        }
        if(jahr % 4 == 0)
        {
           schaltjahr = true; 
        }
        if(jahr%100 == 0)
        {
           schaltjahr = false; 
        }
        if(jahr%400 == 0)
        {
           schaltjahr = true; 
        }
        Console.Clear();
        Console.WriteLine("Schaltjahr: " + $"{(schaltjahr? "Ja" : "Nein")}");
        Console.WriteLine(Convert.ToString(jahr));
        }
    }


}