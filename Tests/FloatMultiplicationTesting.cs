using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    [TestClass]
    public class FloatMultiplicationTesting
    {
        TestMethods myTestMethods = new TestMethods();

        [TestMethod]
        // Ensure correct parameters succeed.
        public void InRange_Success_Test()
        {
            //Arrange
            double a = 1500.0F;
            double b = 1500.0F;

            //Act
            string result = myTestMethods.MultiplyLimited(a, b);

            //Assert
            Console.WriteLine("Inputs: {0}, {1}. Output: {2}. Passed {3}", a, b, result, (a * b).ToString() == result);
            Assert.AreEqual((a * b).ToString(), result);
        }

        [TestMethod]
        //Ensure the correct number of decimal place are returned in the result.
        public void DecimalPlaces_Success_Test()
        {
            //Arrange
            int expectedPlaces = 5;
            int actualPlaces;
            double a = 1500.33333333333;
            double b = 1500.33333333333;

            //Act
            string result = myTestMethods.MultiplyLimited(a, b);

            actualPlaces = int.Parse(result.Split('.')[1]).ToString().Length;

            //Assert
            Console.WriteLine("Inputs: {0}, {1}. Output: {2}. Passed {3}", a, b, result, expectedPlaces == actualPlaces);
            Assert.AreEqual(expectedPlaces, actualPlaces);
        }

        [TestMethod]
        // Ensure incorrect parameters cause a failure.
        public void Overbounds_Fail_Test()
        {
            //Arrange
            double a = 6700.1F;
            double b = 6700.0F;

            //Act
            try
            {
                string result = myTestMethods.MultiplyLimited(a, b);

                Assert.IsTrue(false);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex);
                //Assert
                Console.WriteLine("Inputs: {0}, {1}. Output: {2}. Passed {3}", a, b, null, true);
                Assert.IsTrue(true);
            }
        }

       


    }
}
