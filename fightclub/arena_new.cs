using System;
using System.Collections.Generic;
using System.Text;

namespace fightclub
{
    public class fight_result
    {
        public List<tier> uberlebende { get; }
        public List<tier> tote { get; }
        public int runde { get; }

        public fight_result(List<tier> uberlebende, List<tier> tote, int runde)
        {
            this.uberlebende = uberlebende;
            this.tote = tote;
            this.runde = runde;
        }
    }
    
    public class fight_arena
    {
        List<tier> teilnehmer;
        private int round { get; set; }

        public fight_arena(List<tier> teilnehmer)
        {
            this.teilnehmer = teilnehmer;
            this.round = 0;
        }

        public fight_result fight()
        {
            List<tier> lebend = new List<tier>();
            List<tier> tot = new List<tier>();
            int lebendCount = 0;
            int totCount = 0;

            foreach (var t in teilnehmer)
            {
                if (t.lebendig)
                {
                    lebend.Add(t);
                    lebendCount++;
                }
                else
                {
                    tot.Add(t);
                    totCount++;
                }
            }

            if (lebendCount < 2)
            {
                return new fight_result(lebend, tot, round);
            }

            // objListOrder.Sort((x, y) => x.OrderDate.CompareTo(y.OrderDate));
            lebend.Sort((x, y) => y.agilitaet().CompareTo(x.agilitaet()));

            return new fight_result(lebend, tot, round);
        }
    }
}
