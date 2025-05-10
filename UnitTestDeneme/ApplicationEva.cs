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
        public AppResult Evaluate(JobApp jobApp)
        {
            if (jobApp.personel.Age < minAge)
                return AppResult.AutoRejected;

            return AppResult.AutoAccepted;
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
