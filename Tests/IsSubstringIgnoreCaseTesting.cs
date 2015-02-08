using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    [TestClass]
    public class IsSubstringIgnoreCaseTesting
    {
        protected TestMethods myTestMethods = new TestMethods();
        protected Func<string, string, bool> substringMethod;

        [TestInitialize]
        public void Init()
        {
            substringMethod = myTestMethods.IsSubstringIgnoreCase;
        }

        [TestMethod]
        //Ensure valid substring is correctly found
        public void FindInTarget_Success_Test()
        {
            //Arrange
            string find = "steven";
            string target = "stevenbrown";

            //Act
            bool isSubstring = substringMethod(find, target);

            //Assert
            Console.WriteLine("Inputs: {0}, {1}. Output: {2}", find, target, isSubstring);
            Assert.IsTrue(isSubstring);
        }

        [TestMethod]
        //Ensure case mismatch substring is found
        public void FindInTarget_SuccessCase_Test()
        {
            //Arrange
            string find = "Steven";
            string target = "stevenbrown";

            //Act
            bool isSubstring = substringMethod(find, target);

            //Assert
            Console.WriteLine("Inputs: {0}, {1}. Output: {2}", find, target, isSubstring);
            Assert.IsTrue(isSubstring);
        }

        [TestMethod]
        //Ensure invalid substring is not found
        public void FindInTarget_Fail_Test()
        {
            //Arrange
            string find = "steven";
            string target = "st3v3nbrown";

            //Act
            bool isSubstring = substringMethod(find, target);

            //Assert
            Console.WriteLine("Inputs: {0}, {1}. Output: {2}", find, target, isSubstring);
            Assert.IsFalse(isSubstring);
        }

        [TestMethod]
        //Ensure valid substring is correctly found at end of string
        public void FindInTarget_Success2_Test()
        {
            //Arrange
            string find = "steven";
            string target = "brownsteven";

            //Act
            bool isSubstring = substringMethod(find, target);

            //Assert
            Console.WriteLine("Inputs: {0}, {1}. Output: {2}", find, target, isSubstring);
            Assert.IsTrue(isSubstring);
        }

        [TestMethod]
        //Ensure fail when target is shorter than search string
        public void FindInTarget_FailTargetLength_Test()
        {
            //Arrange
            string find = "steven";
            string target = "st3v3";

            //Act
            bool isSubstring = substringMethod(find, target);

            //Assert
            Console.WriteLine("Inputs: {0}, {1}. Output: {2}", find, target, isSubstring);
            Assert.IsFalse(isSubstring);
        }

        [TestMethod]
        //Ensure fail when argumet is null
        public void FindInTarget_FailNullArg_Test()
        {
            //Arrange
            string find = "st3v3";
            string target = null;

            //Act
            bool isSubstring = substringMethod(find, target);

            //Assert
            Console.WriteLine("Inputs: {0}, {1}. Output: {2}", find, target, isSubstring);
            Assert.IsFalse(isSubstring);
        }

    }
}
