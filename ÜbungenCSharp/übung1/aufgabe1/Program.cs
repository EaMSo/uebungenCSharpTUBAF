using System;
class Programm
{
    static void Main()
    {
        int minuten;
        double kosten = 3.99;
        char[] tarif = { 'S', 'M', 'L'};
        char vertrag;
        while(true)
        {
            Console.WriteLine("Minuten eingeben:");
            try
            {
                minuten = Convert.ToInt32(Console.ReadLine());
                break;
            }
            catch(FormatException)
            {
                Console.WriteLine("Wrong input!");
            }
        }
        while(true)
        {
            Console.WriteLine("Vertrag eingeben:");
            try
            {
                vertrag = Convert.ToChar(Console.ReadLine());//?
            }
            catch(ArgumentNullException)
            {
                continue;
            }
            catch(FormatException)
            {
                continue;
            }
            if (tarif.Contains(char.ToUpper(vertrag)))
            {
                break;
            }
            Console.WriteLine("Wrong Input!");
        }
        if(minuten>100)
        {
            kosten = (minuten -100) * 0.099; 
        }
        vertrag=char.ToUpper(vertrag);
        
        switch (vertrag)
        {
            case 'S': kosten +=5;
            break;
            case 'M': kosten +=7;
            break;
            case 'L': kosten +=10;
            break;
        }
        Console.Clear();
        Console.WriteLine($"Tarif: {vertrag}");
        Console.WriteLine($"Minuten: {minuten}");
        Console.WriteLine($"Kosten: {kosten:f2}");
    }

        
}