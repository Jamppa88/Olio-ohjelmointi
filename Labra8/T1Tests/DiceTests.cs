using Microsoft.VisualStudio.TestTools.UnitTesting;
using JAMK.IT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMK.IT.Tests
{
    [TestClass()]
    public class DiceTests
    {
        [TestMethod()]
        public void ThrowTest()
        {
            Dice dice = new Dice();
            List<int> results = new List<int>();
            for (int i = 0; i < 1000; i++)
            {
                results.Add(dice.Throw());
            }
            foreach (var item in results)
            {
                if (item > 6 || item < 1)
                    Assert.Fail();
            }
            Assert.IsTrue(true);
        }
    }
}