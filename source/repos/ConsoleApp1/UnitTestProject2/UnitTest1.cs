using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApp1;

namespace UnitTestProject2
{
    [TestClass]
    public class UnitTest1
    {
        //case multiple of 3
        [TestMethod]
        public void TestMethod1()
        {
            fizzBuzz fb = new fizzBuzz();
            int num1 = 3;
            string expectedText = "Fizz";
            
            string actual = fb.TextReturn(num1);
            Assert.AreEqual(expectedText, actual);
        }

        // case multiple of 5
        [TestMethod]
        public void TestMethod2()
        {
            fizzBuzz fb = new fizzBuzz();
            int num1 = 5;
            string expectedText = "Buzz";

            string actual = fb.TextReturn(num1);
            Assert.AreEqual(expectedText, actual);
        }

        //case multiple of both 3 and 5
        [TestMethod]
        public void TestMethod3()
        {
            fizzBuzz fb = new fizzBuzz();
            int num1 = 15;
            string expectedText = "fizzBuzz";

            string actual = fb.TextReturn(num1);
            Assert.AreEqual(expectedText, actual);
        }

        //case not a multiple
        [TestMethod]
        public void TestMethod4()
        {
            fizzBuzz fb = new fizzBuzz();
            int num1 = 16;
            string expectedText = "";

            string actual = fb.TextReturn(num1);
            Assert.AreEqual(expectedText, actual);
        }

        // special case 0
        [TestMethod]
        public void TestMethod5()
        {
            fizzBuzz fb = new fizzBuzz();
            int num1 = 0;
            string expectedText = "";

            string actual = fb.TextReturn(num1);
            Assert.AreEqual(expectedText, actual);
        }
    }
}
