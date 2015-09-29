using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace WordCount
{
    class Program
    {
        static void Main(string[] args)
        {
            //this is the default string
            string _authorString = "This is a statement, and so is this.";

            while (!string.IsNullOrEmpty(_authorString))
            {
                foreach (var data in Sentence.CheckCount(_authorString))
                {
                    //showing the o/p in console
                    Console.WriteLine(data.word + "-->" + data.count);  
                }
                
                Console.WriteLine("Press enter to quit... OR provide sentence as an input...");

                //user input will be set as a next string
                //as long as user has provided sentence, loop will continue
                //and show the output
                _authorString = Console.ReadLine();
            }
        }
    }
}
