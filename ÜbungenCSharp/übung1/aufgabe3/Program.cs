using System;
class programm
{
    static void Main()
    {  
        string? a1, a2, a3;
        double a=0, e=0, schrittweite=0, x,y;
        int k=0;
        while(true)
        {
            Console.WriteLine("kleiners Intervall eingeben:");
            a1 = Console.ReadLine();
            Console.WriteLine("größer Intervall eingeben:");
            a2 = Console.ReadLine();
            Console.WriteLine("Schrittweite eingeben:");
            a3 = Console.ReadLine();
            try
            {
                a = Convert.ToDouble(a1);
                e = Convert.ToDouble(a2);
                schrittweite = Convert.ToDouble(a3);
                break;
            }
            catch(FormatException)
            {
                Console.WriteLine("Wrong input!");
            }
        }
            int anzahl = Convert.ToInt32(Math.Ceiling((e - a)/schrittweite));
            double[] xwerte = new double[anzahl+1];
            double[] ywerte = new double[anzahl+1];
            x=a;
            while(e>=x)
            {
                y = (3.0*x-6.0)/((x+2)*((x-1)*(x-1)));
                xwerte[k]= x;
                ywerte[k]= y;
                x += schrittweite;
                k++;
            }
            Console.Clear();
            string output;
            output  = "| ";
            output += "X-Werte".PadRight(2, ' ') + "| Y-Werte ".PadRight(22, ' ') +"|\n";
            output += "|:"+ "".PadRight(7, '-') + "|:--------------------|\n";
            for (int i = 0; i < xwerte.Length; i++)
            {
            output += String.Format("| {0:F4}".PadRight(9,' ')+"| {1, -20:F4}|\n",(xwerte[i]), ywerte[i]);
            }
            Console.WriteLine(output);

    	






    }











}