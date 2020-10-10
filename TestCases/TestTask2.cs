using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestDotNetJRPL;

namespace TestCases
{
    [TestClass]
    public class TestTask2
    {
        [TestMethod]
        public void TestMethod1()
        {
            string res = Task2.GetDueDate("20/10/2020",2);
            if(res != "22/10/2020")
            {
                Assert.Fail();
            }
        }


        [TestMethod]
        public void TestMethod2()
        {
            string res = Task2.GetDueDate("15/08/2020", 10);
            if (res != "25/08/2020")
            {
                Assert.Fail();
            }
        }


        [TestMethod]
        public void TestMethod3()
        {
            string res = Task2.GetDueDate("03/04/2020", 5);
            if (res != "08/04/2020")
            {
                Assert.Fail();
            }
        }

        [TestMethod]
        public void TestMethod4()
        {
            string res = Task2.GetDueDate("04/10/2020", 10);
            if (res != "14/10/2020")
            {
                Assert.Fail();
            }
        }

        [TestMethod]
        public void TestMethod5()
        {
            string res = Task2.GetDueDate("25/09/2020", 15);
            if (res != "10/10/2020")
            {
                Assert.Fail();
            }
        }

    }
}
