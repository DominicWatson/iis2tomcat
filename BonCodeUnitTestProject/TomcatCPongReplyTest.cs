﻿using BonCodeAJP13.TomcatPackets;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace BonCodeUnitTestProject
{
    
    
    /// <summary>
    ///This is a test class for TomcatCPongReplyTest and is intended
    ///to contain all TomcatCPongReplyTest Unit Tests
    ///</summary>
    [TestClass()]
    public class TomcatCPongReplyTest
    {


        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        // 
        //You can use the following additional attributes as you write your tests:
        //
        //Use ClassInitialize to run code before running the first test in the class
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Use ClassCleanup to run code after all tests in a class have run
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Use TestInitialize to run code before running each test
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        /// <summary>
        ///A test for TomcatCPongReply Constructor
        ///</summary>
        [TestMethod()]
        public void TomcatCPongReplyConstructorTest()
        {
            byte[] content = null; // TODO: Initialize to an appropriate value
            TomcatCPongReply target = new TomcatCPongReply(content);
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for TomcatCPongReply Constructor
        ///</summary>
        [TestMethod()]
        public void TomcatCPongReplyConstructorTest1()
        {
            TomcatCPongReply target = new TomcatCPongReply();
            Assert.Inconclusive("TODO: Implement code to verify target");
        }
    }
}
