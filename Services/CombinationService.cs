using Nine_Ali.Helpers;
using Nine_Ali.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Nine_Ali.Services
{
    public class CombinationService
    {
        public List<Result> GetAll(List<Break> breakList, List<Commercial> commercialList)
        {
            var selection = breakList.SelectMany(b => commercialList, (b, c) => new
            {
                Break = b,
                Commercial = c
            })
               .Where(s => s.Break.DemographicTypes == s.Commercial.DemographicTypes);


            var combinationOfTwo = selection.SelectMany(p => selection, (s1, s2) => new
            {
                Selection1 = s1,
                Selection2 = s2,
            })
                .Where(s => s.Selection1.Break.Name == "Break1"
            && s.Selection2.Break.Name == "Break2"
            && s.Selection2.Commercial.CommercialTypes != CommercialTypes.Finance
            && s.Selection1.Commercial.CommercialTypes != s.Selection2.Commercial.CommercialTypes);

            var combinationOfThree = combinationOfTwo.SelectMany(p => selection, (s2, s3) => new
            {
                Selection2 = s2,
                Selection3 = s3,
                Sum = s2.Selection1.Break.Rating + s2.Selection2.Break.Rating + s3.Break.Rating
            })
                .Where(s => s.Selection3.Break.Name == "Break3"
           && s.Selection2.Selection2.Commercial.CommercialTypes != s.Selection3.Commercial.CommercialTypes)
                .OrderByDescending(s => s.Sum);

            var resultList = new List<Result>();
            foreach (var res in combinationOfThree)
            {
                var result = new Result();
                result.TotalRating = res.Sum;
                result.CommercialList.Add(res.Selection2.Selection1.Commercial);
                result.CommercialList.Add(res.Selection2.Selection2.Commercial);
                result.CommercialList.Add(res.Selection3.Commercial);
                resultList.Add(result);
            }
            return resultList;
        }

    }
}
