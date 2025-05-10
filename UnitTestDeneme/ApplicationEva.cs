using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTestDeneme.Models;

namespace UnitTestDeneme
{
    public class ApplicationEva
    {
        private const int minAge = 18;
        private const int YearofExperience = 11;
        public List<string> techList = new List<string> { "c", "c++", "java", "c#", "python", "unity" };
        public AppResult Evaluate(JobApp jobApp)
        {
            if (jobApp.personel.Age < minAge)
                return AppResult.AutoRejected;

            var sr = GetSimilarRate(jobApp.techstacklist);

            if (sr < 25)
                return AppResult.AutoRejected;

            if (sr > 70 && jobApp.YearsOfExperience > YearofExperience)
                return AppResult.AutoAccepted;


            return AppResult.AutoAccepted;


        }



        private int GetSimilarRate(List<string> techList)
        {
            var matchedCount =
                techList.Where(i => techList.Contains(i, StringComparer.OrdinalIgnoreCase)).Count();

            return (int)((double)matchedCount / techList.Count * 100); 
        }
    }
}

public enum AppResult
{
    AutoAccepted,
    TransferredHR,
    TransferredToLead,
    TransferredCTO,
    AutoRejected,
}
