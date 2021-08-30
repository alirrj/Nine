using Nine_Ali.Helpers;
using Nine_Ali.Models;
using Nine_Ali.Services;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Nine_Ali
{
    class Program
    {
        static void Main(string[] args)
        {
            var commercialList = FillHelper.FillCommercial();
            var breakList = FillHelper.FillBreak();


            var combination = new CombinationService();
            //All possible 3 commercials with all commercial break restrictions
            var allResult = combination.GetAll(breakList, commercialList);

            //Best result with biggest total rating
            var result = combination.GetAll(breakList, commercialList).FirstOrDefault();

            var bestResult = new Result();

            for (int i = 0; i < 3; i++)
            {
                bestResult.CommercialList.Add(result.CommercialList[i]); 
            }
            
            bestResult.TotalRating = result.TotalRating;

            Console.WriteLine("Total best rating is " + bestResult.TotalRating);
            Console.WriteLine("With the commercials below:");
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(bestResult.CommercialList[i].Name + " " 
                    + bestResult.CommercialList[i].CommercialTypes + " "
                    + bestResult.CommercialList[i].DemographicTypes
                    );
            }

        }

    }
}
