/**
 * @file ProblemTwo.cs
 * @author Amir khaksar (ah_khaksar@yahoo.com)
 * @brief count letters
 * @version 0.1.0
 * @date 2022-08-01
 * @id 2code2
 * @Compailer dot net
 * @copyright Copyright (c) 2022
 *
 */

using System;
using System.Text.RegularExpressions;
namespace Problem_B
{
    class Program
    {

        static void Main(string[] args)
        {
            // Get input
            string alphabets = Console.ReadLine();
            // Create pattern for RegularExpressions 
            // This pattern shows alphabets char
            string pattern = @"[^\w]+";
            // Call RegularExpressions class
            Regex rgx = new Regex(pattern, RegexOptions.IgnoreCase);
            // Replace pattern with null string 
            string myMatch = rgx.Replace(alphabets, "");
            string resultString = string.Empty;
            //This for loop can find duplicated char in string and remove it
            for (int i = 0; i < myMatch.Length; i++)
            {
                if (!resultString.Contains(myMatch[i]))
                {
                    resultString += myMatch[i];
                }
            }
            Console.WriteLine(resultString.Length);
        }
    }
}