using Nine_Ali.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Nine_Ali.Helpers
{
    public class FillHelper
    {
        public static List<Commercial> FillCommercial()
        {
            return new List<Commercial>()
            {
                new Commercial{  Id =1, Name = "Commercial 1", CommercialTypes = CommercialTypes.Automotive, DemographicTypes=DemographicTypes.W25_30},
                new Commercial{  Id =2, Name = "Commercial 2", CommercialTypes = CommercialTypes.Travel, DemographicTypes=DemographicTypes.M18_35},
                new Commercial{  Id =3, Name = "Commercial 3", CommercialTypes = CommercialTypes.Travel, DemographicTypes=DemographicTypes.T18_40},
                new Commercial{  Id =4, Name = "Commercial 4", CommercialTypes = CommercialTypes.Automotive, DemographicTypes=DemographicTypes.M18_35},
                new Commercial{  Id =5, Name = "Commercial 5", CommercialTypes = CommercialTypes.Automotive, DemographicTypes=DemographicTypes.M18_35},
                new Commercial{  Id =6, Name = "Commercial 6", CommercialTypes = CommercialTypes.Finance, DemographicTypes=DemographicTypes.W25_30},
                new Commercial{  Id =7, Name = "Commercial 7", CommercialTypes = CommercialTypes.Finance, DemographicTypes=DemographicTypes.M18_35},
                new Commercial{  Id =8, Name = "Commercial 8", CommercialTypes = CommercialTypes.Automotive, DemographicTypes=DemographicTypes.T18_40},
                new Commercial{  Id =9, Name = "Commercial 9", CommercialTypes = CommercialTypes.Travel, DemographicTypes=DemographicTypes.W25_30}
            };
        }

        public static List<Break> FillBreak()
        {
            return new List<Break>()
            {
                new Break { Id =1, Name = "Break1", DemographicTypes = DemographicTypes.W25_30, Rating=80},
                new Break { Id =2, Name = "Break1", DemographicTypes = DemographicTypes.M18_35, Rating=100},
                new Break { Id =3, Name = "Break1", DemographicTypes = DemographicTypes.T18_40, Rating=250},
                new Break { Id =4, Name = "Break2", DemographicTypes = DemographicTypes.W25_30, Rating=50},
                new Break { Id =5, Name = "Break2", DemographicTypes = DemographicTypes.M18_35, Rating=120},
                new Break { Id =6, Name = "Break2", DemographicTypes = DemographicTypes.T18_40, Rating=200},
                new Break { Id =7, Name = "Break3", DemographicTypes = DemographicTypes.W25_30, Rating=350},
                new Break { Id =8, Name = "Break3", DemographicTypes = DemographicTypes.M18_35, Rating=150},
                new Break { Id =9, Name = "Break3", DemographicTypes = DemographicTypes.T18_40, Rating=500}
            };
        }
    }
}
