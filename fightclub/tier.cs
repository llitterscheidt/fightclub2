using System;
using System.Collections.Generic;
using System.Text;

namespace fightclub
{
    public class tier
    {
        public float alter;
        public float gewicht;
        
        public int angriff;
        public int verteidigung;
        public int beweglichkeit;
        public int angriffslust;
        public int geschwindigkeit;

        public int lebenspunkte;
        public bool lebendig;
       
    }

    public class kleinkatze : tier
    {
        public bool jung;
        public bool fett;
        public float jung_threshold = 1.5f;
        public float fett_thrashold = 7.5f;

        //angriff
        public static int angriff_min_jung = 1;
        public static int angriff_max_jung = 60;
        public static int angriff_min = 25;
        public static int angriff_max = 60;

        //verteidigung
        public static int verteidigung_min_jung = 1;
        public static int verteidigung_max_jung = 30;
        public static int verteidigung_min = 15;
        public static int verteidigung_max = 30;

        //beweglichkeit
        public static int beweglichkeit_min_jung = 1;
        public static int beweglichkeit_max_jung = 80;
        public static int beweglichkeit_min = 50;
        public static int beweglichkeit_max = 80;

        //angriffslust
        public static int angriffslust_min_jung = 0;
        public static int angriffslust_max_jung = 99;
        public static int angriffslust_min = 0;
        public static int angriffslust_max = 99;

        //geschwindigkeit
        public static int geschwindigkeit_min_jung = 1;
        public static int geschwindigkeit_max_jung = 75;
        public static int geschwindigkeit_min = 30;
        public static int geschwindigkeit_max = 75;


        public kleinkatze(float alter, float gewicht)
        {
            Random rand = new Random();
            this.alter = alter;
            this.gewicht = gewicht;
            this.jung = alter < jung_threshold;
            this.fett = gewicht > fett_thrashold;

            this.angriff = rand.Next(jung ? angriff_min_jung : angriff_min, jung ? angriff_max_jung : angriff_max);
            this.verteidigung = rand.Next(jung ? verteidigung_min_jung : verteidigung_min, jung ? verteidigung_max_jung : verteidigung_max);
            this.beweglichkeit = rand.Next(jung ? beweglichkeit_min_jung : beweglichkeit_min, jung ? beweglichkeit_max_jung : beweglichkeit_max);
            this.angriffslust = rand.Next(jung ? angriffslust_min_jung : angriffslust_min, jung ? angriffslust_max_jung : angriffslust_max);
            this.geschwindigkeit = rand.Next(jung ? geschwindigkeit_min_jung : geschwindigkeit_min, jung ? geschwindigkeit_max_jung : geschwindigkeit_max);

            this.lebenspunkte = 100;
            this.lebendig = lebenspunkte > 0;
        }

    }

   
}

