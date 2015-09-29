using WordCount;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Test
{
    /// <summary>
    ///This is a test class for SentenceTest and is intended
    ///to contain all SentenceTest Unit Tests
    ///</summary>
    [TestClass()]
    public class SentenceTest
    {
        private string input_1;
        private List<structWords> lstWordCount_1;

        private string input_2;
        private List<structWords> lstWordCount_2;

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
        [TestInitialize()]
        public void MyTestInitialize()
        {
            input_1 = "This is a statement, and so is this.";
          
            lstWordCount_1 = new List<structWords>();
            lstWordCount_1.Add(new structWords() { word = "this", count = 2 });
            lstWordCount_1.Add(new structWords() { word = "is", count = 2 });
            lstWordCount_1.Add(new structWords() { word = "a", count = 1 });
            lstWordCount_1.Add(new structWords() { word = "statement", count = 1 });
            lstWordCount_1.Add(new structWords() { word = "and", count = 1 });
            lstWordCount_1.Add(new structWords() { word = "so", count = 1 });


            input_2 = "This is a statement, and so is this.";

            lstWordCount_2 = new List<structWords>();
            lstWordCount_2.Add(new structWords() { word = "this", count = 1 });
            lstWordCount_2.Add(new structWords() { word = "is", count = 1 });
            lstWordCount_2.Add(new structWords() { word = "a", count = 2 });
            lstWordCount_2.Add(new structWords() { word = "statement", count = 2 });
            lstWordCount_2.Add(new structWords() { word = "and", count = 2 });
            lstWordCount_2.Add(new structWords() { word = "so", count = 2 });
            lstWordCount_2.Add(new structWords() { word = "dummy", count = 0 });
        }
        //
        //Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        /// <summary>
        ///A test for CheckCount
        ///</summary>
        [TestMethod()]
        public void CheckCountTest()
        {
            string authorString = input_1; 
            List<structWords> expected = lstWordCount_1; 
            List<structWords> actual;
            actual = Sentence.CheckCount(authorString);
            Assert.AreEqual(expected.Count, actual.Count);
            foreach (var data in expected)
            {
                int tempCnt = 0;
                for (int i = 0; i < actual.Count; i++)
			    {
	                if(actual[i].word == data.word)
                    {
                        tempCnt = actual[i].count;
                        break;
                    }
			    }

                if (tempCnt > 0)
                    Assert.AreEqual(data.count, tempCnt);
            }
        }


        /// <summary>
        ///A test for CheckCount
        ///</summary>
        [TestMethod()]
        public void CheckCountTest_Failure()
        {
            string authorString = input_2; 
            List<structWords> expected = lstWordCount_2; 
            List<structWords> actual;
            actual = Sentence.CheckCount(authorString);
            Assert.AreNotEqual(expected.Count, actual.Count);
            foreach (var data in expected)
            {
                int tempCnt = 0;
                for (int i = 0; i < actual.Count; i++)
                {
                    if (actual[i].word == data.word)
                    {
                        tempCnt = actual[i].count;
                        break;
                    }
                }

                if (tempCnt > 0)
                    Assert.AreNotEqual(data.count, tempCnt);
            }
        }
    }
}
