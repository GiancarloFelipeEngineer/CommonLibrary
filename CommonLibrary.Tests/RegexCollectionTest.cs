using CommonLibrary;

namespace CommonLibrary.Tests
{
    [TestClass]
    public class RegexCollectionTest
    {
        [TestMethod]
        public void TEST1_IsCrulyBracketsLikeOpenClose_ReturnedTrue_TestMethod()
        {
            /*  TEST STRING - EXPECTED RESULT
                {} - True
            */
            // ARRANGE...
            string testValue = "{}";
            bool result = false;

            // ACT...
            using (IRegexCollection regexCollection = new RegexCollection())
            {
                result = regexCollection.HasValidCrulyBrackets(testValue);
            }

            // ASSERT...
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void TEST2_IsCrulyBracketsLikeCloseOpen_ReturnedFalse_TestMethod()
        {
            /*  TEST STRING - EXPECTED RESULT
                }{ - False (Closed bracket can't proceed all open brackets)
            */
            // ARRANGE...
            string testValue = "}{";
            bool result = false;

            // ACT...
            using (IRegexCollection regexCollection = new RegexCollection())
            {
                result = regexCollection.HasValidCrulyBrackets(testValue);
            }

            // ASSERT...
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void TEST3_IsCrulyBracketsLikeOpenOpenClose_ReturnedFalse_TestMethod()
        {
            /*  TEST STRING - EXPECTED RESULT
                {{} - False (One bracket pair was not closed)
            */
            // ARRANGE...
            string testValue = "{{}";
            bool result = false;

            // ACT...
            using (IRegexCollection regexCollection = new RegexCollection())
            {
                result = regexCollection.HasValidCrulyBrackets(testValue);
            }

            // ASSERT...
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void TEST4_IsDoesNotContainCrulyBrackets_ReturnedTrue_TestMethod()
        {
            /*  TEST STRING - EXPECTED RESULT
                "" - True (No brackets in the string will return true)
            */
            // ARRANGE...
            string testValue = "";
            bool result = false;

            // ACT...
            using (IRegexCollection regexCollection = new RegexCollection())
            {
                result = regexCollection.HasValidCrulyBrackets(testValue);
            }

            // ASSERT...
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void TEST5_IsCrulyBracketsLikeOpenTextClose_ReturnedTrue_TestMethod()
        {
            /*  TEST STRING - EXPECTED RESULT
                {abc...xyz} - True (Non-bracket characters are ignored appropriately)
            */
            // ARRANGE...
            string testValue = "{abc...xyz}";
            bool result = false;

            // ACT...
            using (IRegexCollection regexCollection = new RegexCollection())
            {
                result = regexCollection.HasValidCrulyBrackets(testValue);
            }

            // ASSERT...
            Assert.IsTrue(result);
        }
        #region Other Test Method
        //[TestMethod]
        //public void P001_IsValidCrulyBrackets_ReturnTrue_TestMethod()
        //{
        //    // ARRANGE...
        //    string testValue = "{Giancarlo}{S.}{Felipe}";
        //    bool result = false;

        //    // ACT...
        //    using (RegexCollection regexCollection = new RegexCollection())
        //    {
        //        result = regexCollection.IsValidCrulyBrackets(testValue);
        //    }

        //    // ASSERT...
        //    Assert.IsTrue(result);
        //}

        //[TestMethod]
        //public void P002_IsValidCrulyBrackets_ReturnFalse_TestMethod()
        //{
        //    // ARRANGE...
        //    string testValue = "}{Giancarlo}{S.}{Felipe}";
        //    bool result = false;

        //    // ACT...
        //    using (RegexCollection regexCollection = new RegexCollection())
        //    {
        //        result = regexCollection.IsValidCrulyBrackets(testValue);
        //    }

        //    // ASSERT...
        //    Assert.IsFalse(result);
        //}

        //[TestMethod]
        //public void P003_IsInValidCrulyBrackets_ReturnTrue_TestMethod()
        //{
        //    // ARRANGE...
        //    string testValue = "}{Giancarlo}{S.}{Felipe}";
        //    bool result = false;

        //    // ACT...
        //    using (RegexCollection regexCollection = new RegexCollection())
        //    {
        //        result = regexCollection.IsInValidCrulyBrackets(testValue);
        //    }

        //    // ASSERT...
        //    Assert.IsTrue(result);
        //}

        //[TestMethod]
        //public void P004_IsInValidCrulyBrackets_ReturnFalse_TestMethod()
        //{
        //    // ARRANGE...
        //    string testValue = "{Giancarlo}{S.}{Felipe}";
        //    bool result = false;

        //    // ACT...
        //    using (RegexCollection regexCollection = new RegexCollection())
        //    {
        //        result = regexCollection.IsInValidCrulyBrackets(testValue);
        //    }

        //    // ASSERT...
        //    Assert.IsFalse(result);
        //}

        //[TestMethod]
        //public void T001_IsCrulyBracketsLikeOpenClose_ReturnTrue_TestMethod()
        //{
        //    // ARRANGE...
        //    string testValue = "{Giancarlo}{S.}{Felipe}";
        //    bool result = false;

        //    // ACT...
        //    using (RegexCollection regexCollection = new RegexCollection())
        //    {
        //        result = regexCollection.IsValidCrulyBrackets(testValue);
        //    }

        //    // ASSERT...
        //    Assert.IsTrue(result);
        //}

        //[TestMethod]
        //public void T002_IsCrulyBracketsLikeCloseOpen_ReturnFalse_TestMethod()
        //{
        //    // ARRANGE...
        //    string testValue = "}Giancarlo{}S.{}Felipe{";
        //    bool result = false;

        //    // ACT...
        //    using (RegexCollection regexCollection = new RegexCollection())
        //    {
        //        result = regexCollection.IsValidCrulyBrackets(testValue);
        //    }

        //    // ASSERT...
        //    Assert.IsFalse(result);
        //}

        //[TestMethod]
        //public void T003_IsCrulyBracketsLikeOpenOpenClose_ReturnFalse_TestMethod()
        //{
        //    // ARRANGE...
        //    string testValue = "{{Giancarlo}{S.}{Felipe}";
        //    bool result = false;

        //    // ACT...
        //    using (RegexCollection regexCollection = new RegexCollection())
        //    {
        //        result = regexCollection.IsOneCrulyBracketsPairNotClosed(testValue);
        //    }

        //    // ASSERT...
        //    Assert.IsFalse(!result);
        //}

        //[TestMethod]
        //public void T004_IsDoesNotContainCrulyBrackets_ReturnTrue_TestMethod()
        //{
        //    // ARRANGE...
        //    string testValue = "Giancarlo S.Felipe";
        //    bool result = false;

        //    // ACT...
        //    using (RegexCollection regexCollection = new RegexCollection())
        //    {
        //        result = regexCollection.IsDoesNotContainCrulyBrackets(testValue);
        //    }

        //    // ASSERT...
        //    Assert.IsTrue(result);
        //}
        #endregion
    }
}