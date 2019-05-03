using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace testWC
{
    [TestClass]
    public class WatchTest
    {
        private Match match;
        private bool result;

        public WatchTest()
        {
            match = new Match();
            result = false;
        }
        [TestMethod]
        public void TestNameOfWatch()
        {

            //match.Name1 = "VietNam";
            //match.Name2 = "3 Tau";
            //Result = Match.CheckNameOfWatch(match);
            //Assert.AreEqual(true, Result);
        }

    }
}
