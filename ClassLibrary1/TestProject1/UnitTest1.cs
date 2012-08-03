using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WillPower.Math.Demo;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            try
            {
                FizzBuzz fb = new FizzBuzz();
                fb.Dividends.Add(3, "Fizz");
                fb.Dividends.Add(5, "Buzz");
                string s = fb.GetOutput(1, 100);
                if (string.IsNullOrEmpty(s)) throw new ApplicationException();
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }

        }
    }
}
