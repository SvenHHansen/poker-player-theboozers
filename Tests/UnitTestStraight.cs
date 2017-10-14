using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Nancy.Simple
{
    /// <summary>
    /// Summary description for UnitTestStraight
    /// </summary>
    [TestClass]
    public class UnitTestStraight
    {
        public UnitTestStraight()
        {
            //
            // TODO: Add constructor logic here
            //
        }

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
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Use TestInitialize to run code before running each test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        //[TestMethod]
        //public void TestValidStraigths()
        //{
        //    var vaildStraights = new List<List<Card>>()
        //    {
        //        new List<Card> { new Card() { rank = "2" }, new Card() { rank = "3" }, new Card() { rank = "4" }, new Card() { rank = "5" }, new Card() { rank = "6" }},
        //        new List<Card> { new Card() { rank = "3" }, new Card() { rank = "4" }, new Card() { rank = "5" }, new Card() { rank = "6" }, new Card() { rank = "7" }},
        //        new List<Card> { new Card() { rank = "4" }, new Card() { rank = "5" }, new Card() { rank = "6" }, new Card() { rank = "7" }, new Card() { rank = "8" }},
        //        new List<Card> { new Card() { rank = "5" }, new Card() { rank = "6" }, new Card() { rank = "7" }, new Card() { rank = "8" }, new Card() { rank = "9" }},
        //        new List<Card> { new Card() { rank = "6" }, new Card() { rank = "7" }, new Card() { rank = "8" }, new Card() { rank = "9" }, new Card() { rank = "10" }},
        //        new List<Card> { new Card() { rank = "7" }, new Card() { rank = "8" }, new Card() { rank = "9" }, new Card() { rank = "10" }, new Card() { rank = "J" }, },
        //        new List<Card> { new Card() { rank = "8" }, new Card() { rank = "9" }, new Card() { rank = "10" }, new Card() { rank = "J" }, new Card() { rank = "Q" }, },
        //        new List<Card> { new Card() { rank = "9" }, new Card() { rank = "10" }, new Card() { rank = "J" }, new Card() { rank = "Q" }, new Card() { rank = "K" }, },
        //        new List<Card> { new Card() { rank = "10" }, new Card() { rank = "J" }, new Card() { rank = "Q" }, new Card() { rank = "K" }, new Card() { rank = "A" }},
        //    };
            
        //    foreach (var validStraigt in vaildStraights)
        //    {
        //        Assert.IsTrue(DeckClassification.IsStraight(validStraigt));
        //    }
        //}

        //[TestMethod]
        //public void TestFalseStraigths()
        //{
        //    var invaildStraights = new List<List<Card>>()
        //    {
        //        new List<Card> { new Card() { rank = "2" }, new Card() { rank = "A" }, new Card() { rank = "4" }, new Card() { rank = "5" }, new Card() { rank = "6" }},
        //        new List<Card> { new Card() { rank = "3" }, new Card() { rank = "4" }, new Card() { rank = "A" }, new Card() { rank = "6" }, new Card() { rank = "7" }},
        //        new List<Card> { new Card() { rank = "2" }, new Card() { rank = "2" }, new Card() { rank = "2" }, new Card() { rank = "2" }, new Card() { rank = "8" }},
        //        new List<Card> { new Card() { rank = "A" }, new Card() { rank = "A" }, new Card() { rank = "A" }, new Card() { rank = "A" }, new Card() { rank = "9" }},
        //        new List<Card> { new Card() { rank = "7" }, new Card() { rank = "7" }, new Card() { rank = "8" }, new Card() { rank = "9" }, new Card() { rank = "10" }},
        //        new List<Card> { new Card() { rank = "8" }, new Card() { rank = "8" }, new Card() { rank = "9" }, new Card() { rank = "10" }, new Card() { rank = "J" }},
        //        new List<Card> { new Card() { rank = "9" }, new Card() { rank = "9" }, new Card() { rank = "10" }, new Card() { rank = "J" }, new Card() { rank = "Q" }},
        //        new List<Card> { new Card() { rank = "9" }, new Card() { rank = "10" }, new Card() { rank = "J" }, new Card() { rank = "Q" }, new Card() { rank = "K" }},
        //        new List<Card> { new Card() { rank = "J" }, new Card() { rank = "J" }, new Card() { rank = "Q" }, new Card() { rank = "K" }, new Card() { rank = "A" }},
        //    };
            
        //    foreach (var invalidStraigt in invaildStraights)
        //    {
        //        Assert.IsFalse(DeckClassification.IsStraight(invalidStraigt));
        //    }
        //}
    }
}
