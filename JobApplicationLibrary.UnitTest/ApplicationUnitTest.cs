﻿using UnitTestDeneme;
using UnitTestDeneme.Models;
using NUnit.Framework;

namespace JobApplicationLibrary.UnitTest
{
    public class ApplicationUnitTest
    {
        

        

        [Test]
        public void FunctionUnderTest_ExpectedResult_UnderCondition()
        {
            // Arrange
            var evulator = new ApplicationEva();
            var app = new JobApp()
            {
                personel = new Personel()
                {
                    Age = 19
                },
                techstacklist = new System.Collections.Generic.List<string>() // Boş liste atandı

            };

            // Act

            var appresult = evulator.Evaluate(app);

            // Assert
            
            if (appresult == AppResult.AutoAccepted)
            {
                // Koşul sağlandı, test başarılı olarak işaretlenebilir
                Assert.Pass("Beklenen sonuç  elde edildi.");
            }
            else
            {
                // Koşul sağlanmadı, test başarısız olarak işaretlenmeli
                Assert.Fail($"{appresult} elde edildi.");
            }
        }

        //********


        [Test]
        public void FunctionUnderTest_ExpectedResult_AgeAndExperience()
        {
            // Arrange
            var evulator = new ApplicationEva();
            var app = new JobApp()
            {
                personel = new Personel()
                {
                    Age = 19
                },
                techstacklist = new System.Collections.Generic.List<string>()
                {
                        "c", "c++", "java", "c#", "python", "unity"
                },
                YearsOfExperience = 15
                 


            };


            // Act

            var appresult = evulator.Evaluate(app);

            // Assert

            if (appresult == AppResult.AutoAccepted)
            {
                // Koşul sağlandı, test başarılı olarak işaretlenebilir
                Assert.Pass("Beklenen sonuç  elde edildi.");
            }
            else
            {
                // Koşul sağlanmadı, test başarısız olarak işaretlenmeli
                Assert.Fail($"{appresult} elde edildi.");
            }
        }
    }
    
    
}
