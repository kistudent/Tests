using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    [TestClass]
    public class IsPowerOf2Testing
    {
        TestMethods myTestMethods = new TestMethods();
                  

        [TestMethod]
        //Ensure a simple correct power of 2 is correctly identified
        public void Success_Test()
        {
            //Arrange
            int x = 4;

            //Act
            bool isPowerOf2 = myTestMethods.IsPowerOf2(x);

            //Assert
            Console.WriteLine("Input: {0}. Output: {1}.", x, isPowerOf2);
            Assert.IsTrue(isPowerOf2);
        }

        [TestMethod]
        //Ensure a negative exponent (2^-1 = 0.5) is identified for a correct floating point power of 2
        public void Success_Minus_Test()
        {
            //Arrange
            double x = 0.5;

            //Act
            bool isPowerOf2 = myTestMethods.IsPowerOf2(x);

            //Assert
            Console.WriteLine("Input: {0}. Output: {1}.", x, isPowerOf2);
            Assert.IsTrue(isPowerOf2);
        }

        [TestMethod]
        //Ensure a floating point which isn't a power of 2 fails
        public void Fail_Minus_Test()
        {
            //Arrange
            double x = 0.7;

            //Act
            bool isPowerOf2 = myTestMethods.IsPowerOf2(x);

            //Assert
            Console.WriteLine("Input: {0}. Output: {1}.", x, isPowerOf2);
            Assert.IsFalse(isPowerOf2);
        }

        [TestMethod]
        //Ensure a simple incorrect power of 2 fails
        public void Fail_Test()
        {
            //Arrange
            int x = 3;

            //Act
            bool isPowerOf2 = myTestMethods.IsPowerOf2(x);

            //Assert
            Console.WriteLine("Input: {0}. Output: {1}.", x, isPowerOf2);
            Assert.IsFalse(isPowerOf2);
        }

        [TestMethod]
        //Ensure 0 fails
        public void Fail0_Test()
        {
            //Arrange
            int x = 0;

            //Act
            bool isPowerOf2 = myTestMethods.IsPowerOf2(x);

            //Assert
            Console.WriteLine("Input: {0}. Output: {1}.", x, isPowerOf2);
            Assert.IsFalse(isPowerOf2);
        }

        [TestMethod]
        //Demonstrate 10 success cases
        public void Demonstrate_Success_Trys()
        {
            for (int i = 0, x = 1; i < 10; i++, x <<= 1)
            {
                bool isPowerOf2 = myTestMethods.IsPowerOf2(x);
                Console.WriteLine("Input: {0}. Output: {1}.", x, isPowerOf2);
            }
        }

        [TestMethod]
        //Demonstrate 10 fail cases
        public void Demonstrate_Fail_Trys()
        {
            for (int i = 0, x = 3; i < 10; i++, x <<= 1)
            {
                bool isPowerOf2 = myTestMethods.IsPowerOf2(x);
                Console.WriteLine("Input: {0}. Output: {1}.", x, isPowerOf2);
            }
        }
    }
}
