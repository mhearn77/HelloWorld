using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HelloWorldLibrary;

namespace UnitTestProject1
{
    [TestClass]
    public class HelloWorldTest
    {
        [TestMethod]
        public void TestConsole()
        {
            AppInstance ai = new AppInstance();
            ai.SetApiType(new HelloWorldConsole("Hello world"));
            Assert.AreEqual("Hello world", ai.GetMessage());
        }

        [TestMethod]
        public void TestDatabase()
        {
            AppInstance ai = new AppInstance();
            ai.SetApiType(new HelloWorldDatabase("Hello world", "connection string data"));
            Assert.AreEqual("Hello world", ai.GetMessage());
        }
    }
}
