using System;
class Programm
{
    static string[] GetErstplatziertenArray()
    {      
        string[] Erstplatzierten = new string[] {"Marte Olsbu Röiseland", "Elvira Öberg", "Lisa Theresa Hauser",
        "Hanna Öberg", "Anais Chevalier-Bouchet", "Denise Herrmann", "Dzinara Alimbekava", "Justine Braisaz-Bouchet", "Dorothea Wierer", "Marketa Davidova"};
        return Erstplatzierten;
    }

    static void Main()
    {
        int k = 0;
        int Platzierung;
        string? stop;
        string[] Erstplatzierten = GetErstplatziertenArray();
        string output;

        output  = "| ";
        output += "Platzierung".PadRight(2, ' ') + "| Name ".PadRight(24, ' ') +"|\n";
        output += "|:"+ "".PadRight(11, '-') + "|:----------------------|\n";
        foreach (string Name in Erstplatzierten)
        {
            k++;
            output += "| "+ Convert.ToString(k).PadRight(11, ' ')+ '|'+ Name.PadRight(23, ' ')+"|\n";
        }
        Console.WriteLine(output);

        while(true)
        {
            Console.WriteLine("Platzierung angeben!: ");
            try
            {
                Platzierung = Convert.ToInt32(Console.ReadLine());
            }
            catch(IndexOutOfRangeException)
            {
                Console.WriteLine("Index zu hoch!");
                Console.ReadLine();
                continue;
            }
            catch(FormatException)
            {
                Console.WriteLine("Falsches Format!");
                continue;
            }
            Console.WriteLine(Erstplatzierten[Platzierung-1]);
            Console.WriteLine();
            do
            {
                Console.WriteLine("Type s to stopp! and Enter to Continue!");
                stop = Console.ReadLine();
                if(stop == "s")
                    return;
                else 
                    break;
            }while(true);
        }

    }
}