using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestDeneme.Models
{
    public class JobApp
    {
        public Personel personel { get; set; }
        public int YearsOfExperience { get; set; }

        public List<string> techstacklist { get; set; }


    }
}
