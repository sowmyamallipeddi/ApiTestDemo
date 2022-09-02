using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using RestSharpDemo;

namespace UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var api = new Demo();
            var response = api.GetUsers();
            Assert.AreEqual(2,response.page);
            

        }
    }
}
