using LifeInsuranceApp.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace LifeInsurance.Tests
{
    [TestClass]
    public class UnitTest
    {
        private UserController _controller = new UserController();
        [TestMethod]
        public void OccupationRating_Test1()
        {
            //Arrange

            string name = "Farmer";
            string expectedResult = "HeavyManual";
            //Action
            var actualresult = _controller.OccupationRating(name);

            //Assert
            Assert.AreEqual(actualresult, expectedResult);
        }

        [TestMethod]
        public void OccupationRating_Test2()
        {
            //Arrange

            string name = "Cleaner";
            string expectedResult = "LightManual";
            //Action
            var actualresult = _controller.OccupationRating(name);

            //Assert
            Assert.AreEqual(actualresult, expectedResult);
        }
        [TestMethod]
        public void OccupationRating_Test3()
        {
            //Arrange

            string name = "Author";
            string expectedResult = "WhiteCollar";
            //Action
            var actualresult = _controller.OccupationRating(name);

            //Assert
            Assert.AreEqual(actualresult, expectedResult);
        }
        [TestMethod]
        public void OccupationRating_Test4()
        {
            //Arrange

            string name = "Doctor";
            string expectedResult = "Professional";
            //Action
            var actualresult = _controller.OccupationRating(name);

            //Assert
            Assert.AreEqual(actualresult, expectedResult);
        }
        [TestMethod]
        public void RatingFactor_Test1()
        {
            //Arrange

            string rating = "WhiteCollar";
            decimal expectedResult = Convert.ToDecimal(1.25);
            //Action
            decimal actualresult = Convert.ToDecimal(_controller.RatingFactor(rating));

            //Assert
            Assert.AreEqual(actualresult, expectedResult);
        }
        [TestMethod]
        public void RatingFactor_Test2()
        {
            //Arrange

            string rating = "Professional";
            decimal expectedResult = Convert.ToDecimal(1.0);
            //Action
            decimal actualresult = Convert.ToDecimal(_controller.RatingFactor(rating));

            //Assert
            Assert.AreEqual(actualresult, expectedResult);
        }
        [TestMethod]
        public void RatingFactor_Test3()
        {
            //Arrange

            string rating = "LightManual";
            decimal expectedResult = Convert.ToDecimal(1.50);
            //Action
            decimal actualresult = Convert.ToDecimal(_controller.RatingFactor(rating));

            //Assert
            Assert.AreEqual(actualresult, expectedResult);
        }
        [TestMethod]
        public void RatingFactor_Test4()
        {
            //Arrange

            string rating = "HeavyManual";
            decimal expectedResult = Convert.ToDecimal(1.75);
            //Action
            decimal actualresult = Convert.ToDecimal(_controller.RatingFactor(rating));

            //Assert
            Assert.AreEqual(actualresult, expectedResult);
        }
        [TestMethod]
        public void CalculatePremium_Test()
        {
            //Arrange

            int age = 20;
            int death_premium = 100;
            decimal rating = Convert.ToDecimal(1.75);

            decimal amt_cal = Convert.ToDecimal(42.00);

            string expectedResult = "Total Premium = $" + amt_cal.ToString("0.00");
            //Action
            string actualamt = _controller.CalculatePremium(age, death_premium, rating);

            string actualresult = actualamt;

            //Assert
            Assert.AreEqual(actualresult, expectedResult);
        }
    }
}
