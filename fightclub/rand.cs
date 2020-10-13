using System;
using System.Collections.Generic;
using System.Text;

namespace fightclub
{
    public static class rnd
    {
        public static double fl(double minimum, double maximum)
        {
            Random random = new Random();
            return random.NextDouble() * (maximum - minimum) + minimum;
        }
    }
}
