using System;
using System.Collections.Generic;
using System.Text;

namespace BadgerHoldingsTechnical
{
    static class Petshop
    {
    
        public static double basePrice(int biscuits ,int chewies, int vitamins, string bucketSize)
        {
            double bPriceN = 2;
            double bPriceL = 3.75;
            double cPriceN = 4.10;
            double cPriceL = 4.50;
            double vPriceN = 2.50;
            double vPriceL = 4.15;
            double curPrice = 0.00;

            if (bucketSize == "Normal")
            {
                curPrice =  (biscuits * bPriceN) + (chewies * cPriceN) + (vitamins * vPriceN);
            } else
            {
                curPrice = (biscuits * bPriceL) + (chewies * cPriceL) + (vitamins * vPriceL);
            }

            return curPrice;
        }
        public static double applyWeekend(string isWeekend, string bucketSize,  double curPrice, int biscuits, int chewies, int vitamins)
        {
            double weekendPrice = 0.00;
            double totalTreats = biscuits + chewies + vitamins;

            if (isWeekend == "Y")
            {
                weekendPrice = curPrice + (curPrice * 0.15);
            }
            else
            {
                weekendPrice = curPrice;
            }

            if (totalTreats > 20)
            {
                weekendPrice = weekendPrice - (weekendPrice * 0.2);
            }

            if (vitamins > 7 && bucketSize == "Normal")
            {
                weekendPrice = weekendPrice - (weekendPrice * 0.05);
            }

            if (chewies >= 10 && bucketSize == "Large")
            {
                weekendPrice = weekendPrice - (weekendPrice * 0.1);
            }

            return weekendPrice;
        }

        



    }
    
}
