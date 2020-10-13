using System;
using System.Collections.Generic;

namespace fightclub
{
    class Program
    {
        static void Main(string[] args)
        {

            List<tier> t = new List<tier>();

            for (int i = 0; i < 10; i++)
            {
                t.Add(new kleinkatze(3, 5));
            }

            fight_arena arena = new fight_arena(t);

            fight_result res = arena.fight();

            foreach (var v in res.uberlebende)
            {
                Console.WriteLine(v.agilitaet());
            }
            
            Console.ReadKey();

        }
      
    }

}
