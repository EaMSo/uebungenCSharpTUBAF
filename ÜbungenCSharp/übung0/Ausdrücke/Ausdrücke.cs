using System;


class Program
{
        static void Main()
        {
            int a = 1, b = 2, c = 3, r = 4;
            double y = 4.0 , d, f, A, Z;
            //a)
            d=(double) (a/(double)b);
            f=(double)((a+b)/(c-y)-(a/(double)b));
            Z=(double)(-b+Math.Sqrt(Math.Pow(b,2)-4*c*a))/2*a;
            A=Math.PI*r*r;

            Console.WriteLine("d:{0}", d);
            Console.WriteLine("f:{0}", f);
            Console.WriteLine("f:{0}", Z);
            Console.WriteLine("A:{0}", A);
            
            //X im Bereich?
            int x, x1=10, x2=10, y1=30, y2=30;
            int.TryParse(Console.ReadLine(), out x);
            if(x<= x2 && x>=x1){
                Console.WriteLine("X ist im Bereich!");
            }
            else{
                Console.WriteLine("X ist nicht im Bereich");
            }
        

            //Definierter Punkt im Rechteck
            if(x <= x2 && x >= x1 && y <= y2 && y >= y1){
                Console.WriteLine("Pxy ist im Rechteck!");
            }
            else{
                Console.WriteLine("Punkt ist nicht im Rechteck!");
            }
            //Punkte gleiche Koordinaten
            if(x1==x2 && y1==y2)
            {
                Console.WriteLine("Punkte sind gleich!");
            }
            else
            {
                Console.WriteLine("Punkte verschieden!");
            }
            //Bedingung trifft zu?
            if(x1<=x && x<=x2){
                Console.WriteLine("Aussage x1<=x<=x2 trifft zu!");
            }
            else if(y1<=y && y<=y2){
                Console.WriteLine("Aussage y1<=y<=y2 trifft zu!");
            }

            //Aufgabe 3

            int xb =0b0001_0001, yb=0b1000_1000, zb=0b1111;
            
            Console.WriteLine("{0:X}",xb&yb&zb);
            Console.WriteLine("{0:X}",(xb|yb)&zb);
            Console.WriteLine("{0:X}",~(xb^yb));
            Console.WriteLine("{0:X}",~(xb^yb)&byte.MaxValue);
        }
}

