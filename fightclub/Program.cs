using System;

namespace fightclub
{
    class Program
    {
        static void Main(string[] args)
        {

            kleinkatze kleinkatze1 = new kleinkatze(1, 1.5f);

            Console.WriteLine("angriff: " + kleinkatze1.angriff);
            Console.WriteLine("verteidigung: " + kleinkatze1.verteidigung);
            Console.WriteLine("beweglichkeit: " + kleinkatze1.beweglichkeit);
            Console.WriteLine("angriffslust: " + kleinkatze1.angriffslust);
            Console.WriteLine("geschindigkeit: " + kleinkatze1.geschwindigkeit );
            Console.WriteLine("Lebenspunkte: " + kleinkatze1.lebenspunkte + "\n");

            kleinkatze kleinkatze2 = new kleinkatze(5, 12.5f);

            Console.WriteLine("angriff: " + kleinkatze2.angriff);
            Console.WriteLine("verteidigung: " + kleinkatze2.verteidigung);
            Console.WriteLine("beweglichkeit: " + kleinkatze2.beweglichkeit);
            Console.WriteLine("angriffslust: " + kleinkatze2.angriffslust);
            Console.WriteLine("geschindigkeit: " + kleinkatze2.geschwindigkeit);
            Console.WriteLine("Lebenspunkte: " + kleinkatze2.lebenspunkte + "\n");

            int ges = fightclub.kleinkatzenarena.fight(kleinkatze1, kleinkatze2) ;
            
            Console.WriteLine(ges);
            
            Console.ReadKey();

        }
      
    }

}
