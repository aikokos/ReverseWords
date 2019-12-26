// <copyright file="ReverseWords.cs" company="LearningCompany">
// Copyright (c) Company. All rights reserved.
// </copyright>
namespace ReverseWordsApp
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The ReverseWords class, which makes words in back order.
    /// </summary>
    public class ReverseWords
    {
        /// <summary>
        /// Just main method for Console App, without it project will not compile.
        /// </summary>
        /// <param name="args">arguments for potential console application</param>
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello");
        }

        /// <summary>
        /// Method for reverting words in string.
        /// </summary>
        /// <param name="str">string, which we want to revert</param>
        /// <returns>Returns the reverted string</returns>
        public string Reverse(string str)
        {
            // get words from string
            // we assume, that there is ' ' between words
            string[] words = str.Split(' ');

            List<string> wordsList = new List<string>(words);

            // just remove unneeded empty strings, if we have some
            foreach (string word in wordsList)
            {
                if (wordsList.Equals(string.Empty))
                {
                    wordsList.Remove(word);
                }
            }

            // use ready reverse method
            string[] words1 = wordsList.ToArray();
            Array.Reverse(words1);
            string reversed = string.Join(" ", words1);
            return reversed;
        }
    }
}
