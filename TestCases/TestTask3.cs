using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Tasks.SupportFiles;
using TestDotNetJRPL;

namespace TestCases
{
    [TestClass]
    public class TestTask3
    {
        [TestMethod]
        public void TestMethod1()
        {
            List<string> res = Task3.GetItemsOutOfStock();

            List<string> result = new List<string>();
            result.Add("Component 0");
            result.Add("Component 4");
            result.Add("Component 8");
            result.Add("Component 12");
            result.Add("Component 16");

            for(int i =0; i < 5; i++)
            {
                if(res[i] != result[i])
                {
                    Assert.Fail();
                }
            }

        }


        [TestMethod]
        public void TestMethod2()
        {
            int res = Task3.GetStockSum();
            if(res != 82500)
            {
                 Assert.Fail();
            }
        }

        [TestMethod]
        public void TestMethod3()
        {


            var list = new List<MaterialEntry>();
            list.Add(new MaterialEntry()
            {
                ComponetId = 3,
                Quantity = 2
            }
            );

            list.Add(new MaterialEntry()
            {
                ComponetId = 4,
                Quantity = 3
            }
           );

            bool res = Task3.IsPossibleManufacturer(200, list.ToArray());
            if (res != false)
            {
                Assert.Fail();
            }
        }


        [TestMethod]
        public void TestMethod4()
        {


            var list = new List<MaterialEntry>();
            list.Add(new MaterialEntry()
            {
                ComponetId = 3,
                Quantity = 2
            }
            );

            list.Add(new MaterialEntry()
            {
                ComponetId = 2,
                Quantity = 3
            }
           );

            bool res = Task3.IsPossibleManufacturer(200, list.ToArray());
            if (res != true)
            {
                Assert.Fail();
            }
        }



    }
}
