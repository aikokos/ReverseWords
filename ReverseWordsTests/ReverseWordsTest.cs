// <copyright file="ReverseWordsTest.cs" company="LearningCompany">
// Copyright (c) Company. All rights reserved.
// </copyright>
namespace ReverseWordsTests
{
    using NUnit.Framework;
    using ReverseWordsApp;

    /// <summary>
    /// Class contains tests for ReverseWords class.
    /// </summary>
    public class ReverseWordsTest
    {
        /// <summary>
        /// Method for testing Revert method of ReverseWords class.
        /// </summary>
        /// <param name="str">string, which we want to revert</param>
        /// <returns>Returns the reverted string</returns>
        [Test]
        [TestCase("The greatest victory is that which requires no battle", 
            ExpectedResult = "battle no requires which that is victory greatest The")]
        [TestCase("The apple is on the tree",
            ExpectedResult = "tree the on is apple The")]
        [TestCase("I like to move it, move it",
            ExpectedResult = "it move it, move to like I")]
        public string ReverseTest(string str)
        {
            ReverseWords rw = new ReverseWords();
             return rw.Reverse(str);
        }
    }
}