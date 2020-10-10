using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestDotNetJRPL;

namespace TestCases
{
    [TestClass]
    public class TestTask1
    {
        [TestMethod]
        public void TestMethod1()
        {
            bool res = Task1.CheckString("ABC20190020");
            if(res != true)
            {
                Assert.Fail();
            }
        }


        [TestMethod]
        public void TestMethod2()
        {
            bool res = Task1.CheckString("BDC20350001");
            if (res != true)
            {
                Assert.Fail();
            }
        }

        [TestMethod]
        public void TestMethod3()
        {
            bool res = Task1.CheckString("BBB19990200");
            if (res != true)
            {
                Assert.Fail();
            }
        }


        [TestMethod]
        public void TestMethod4()
        {
            bool res = Task1.CheckString("BBB199902001");
            if (res != false)
            {
                Assert.Fail();
            }
        }


        [TestMethod]
        public void TestMethod5()
        {
            bool res = Task1.CheckString("ZBB19990200");
            if (res != false)
            {
                Assert.Fail();
            }
        }


        [TestMethod]
        public void TestMethod6()
        {
            bool res = Task1.CheckString("ABB20370200");
            if (res != false)
            {
                Assert.Fail();
            }
        }



    }
}
