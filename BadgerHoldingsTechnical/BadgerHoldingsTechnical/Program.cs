using System;

namespace BadgerHoldingsTechnical
{
    class Program
    {
        static void Main(string[] args)
        { try
            {
                Console.WriteLine("Please enter the number of biscuits");
                int biscuits = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please enter the number of chewies");
                int chewies = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please enter the number of vitamins");
                int vitamins = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please enter the bucket size as Large or Normal");
                string bucketSize = Console.ReadLine();
                Console.WriteLine("Is this over a weekend? Y/N");
                string isWeekend = Console.ReadLine();

                var basePrice = Petshop.basePrice(biscuits, chewies, vitamins, bucketSize);
                var weekendPrice = (Petshop.applyWeekend(isWeekend, bucketSize, basePrice, biscuits, chewies, vitamins));
                var bucketFillCharge = 2;

                var finPrice = weekendPrice + bucketFillCharge;

                Console.WriteLine( "The final price is :" + finPrice.ToString());
            } 
            catch (Exception ex)
            {
                Console.WriteLine("Invalid Input");
            }

        }

       
    }

}

