using System;
using System.Collections.Generic;
using System.Text;

namespace fightclub
{
    class kleinkatzenarena
    {       

        public static int fight(kleinkatze kk1, kleinkatze kk2)
        {
            while (kk1.lebendig && kk2.lebendig)
            {
                int rval;
                int ang1 = (kk1.angriff + kk1.angriffslust) / 2;
                int ver1 = kk1.verteidigung;
                int ges_bew1 = kk1.beweglichkeit + kk1.geschwindigkeit;

                int ges_ang1 = ang1 + ges_bew1;
                int ges_ver1 = ver1 + ges_bew1;


                int ang2 = (kk2.angriff + kk2.angriffslust) / 2;
                int ver2 = kk2.verteidigung;
                int ges_bew2 = kk2.beweglichkeit + kk2.geschwindigkeit;

                int ges_ang2 = ang2 + ges_bew2;
                int ges_ver2 = ver2 + ges_bew2;
   
            }           
              return rval;                 
        }
    }
}
