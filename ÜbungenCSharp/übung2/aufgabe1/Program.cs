using System;
using System.Threading;

class Programm 
{
    const int langerIntervall = 900;    
    const int kurzerIntervall = 300; 
    const int ultralangesIntervall = 2100;  
    static public void Main()
    {
        Console.WriteLine("String eingeben:");  
        string morsecode ="";
        string eingabe = Console.ReadLine(); 
        foreach(char i in eingabe){   
        morsecode += MorseTable.GetMorseCode(i);
        }
        Console.WriteLine(morsecode);
        //Flash(langerIntervall);
        //Flash(kurzerIntervall);
        Morse(morsecode);
        Console.WriteLine(morsecode);
    }
    static void FlashBlack(int Intervall)
    {
        Console.BackgroundColor = ConsoleColor.Black; 
        Console.Clear();
        Thread.Sleep(Intervall);
    }

    static void Flash(int Intervall)
    {
        Console.BackgroundColor = ConsoleColor.White;
        Console.Clear();
        Thread.Sleep(Intervall);
        Console.BackgroundColor = ConsoleColor.Black; 
        Console.Clear();
        Thread.Sleep(300);
    }
    static void Morse(string morsecode)
    {
        foreach(char character in morsecode)
        {
            if(character == '.'){
                Flash(kurzerIntervall);
            }
            else if (character == '-'){
                Flash(langerIntervall);
            }
            else{
                FlashBlack(ultralangesIntervall-300);
            }
        }
    }
}
