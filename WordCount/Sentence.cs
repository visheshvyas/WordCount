using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace WordCount
{
    //struct to hold the data for a word
    public struct structWords
    {
        public string word;
        public int count;
    }

    //sentence class 
    //this class will have all the methods to work on sentence
    public class Sentence
    {
        //characters that cannot be removed from a sentence to differentiate the word
        const string regExp= @"[^0-9a-zA-Z'\s]+";

        //assigning into list so that test can be done for individual words
        static List<structWords> lstData = new List<structWords>();
        /// <summary>
        /// 
        /// </summary>
        /// <param name="authorString"></param>
        /// <returns></returns>
        public static List<structWords> CheckCount(string authorString)
        {
            //replacing all the punctuation marks
            authorString = Regex.Replace(authorString, regExp, "");

            //splitting sentence into words 
            var arrWords = authorString.ToLower().Split(new char[] { ' ' });

            //grouping the words and getting the count
            var wordCnt = from col in arrWords
                          group col by col into g
                          select new structWords { word = g.Key, count = g.Count() };

            lstData.AddRange(wordCnt);
            
            return lstData;
        }
    }
}
