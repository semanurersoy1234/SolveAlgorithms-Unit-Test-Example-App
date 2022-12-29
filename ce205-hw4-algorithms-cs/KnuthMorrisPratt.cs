/**
* @file ce205-hw4-algorithms-cs
* @author Sema Nur Ersoy
* @author Rumeysa Er
* @date 30 Dec 2022
*
* @brief <b> HW-4 Functions </b>
*
* HW-4 Sample Lib Functions
*
* @see http://bilgisayar.mmf.erdogan.edu.tr/en/
*
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ce205_hw4_algorithms_cs
{
    public static class KnuthMorrisPratt
    {
        /**
        * @name Search 
        * @param [in] pattern [\b string]
        * @param [in] text [\b string]
        * @retval [\b int]
        * This function helps us to find the string text we entered when we search for it in our application.
        * It is the search function.
        **/
        public static int Search(string pattern, string text)
        {
            int m = pattern.Length;
            int n = text.Length;

            // Preprocess the pattern to build the failure table
            int[] failure = new int[m];
            failure[0] = -1;
            for (int t = 1; t < m; t++)
            {
                int s = failure[t - 1];
                while (s >= 0 && pattern[s + 1] != pattern[t])
                {
                    s = failure[s];
                }
                if (pattern[s + 1] == pattern[t])
                {
                    s++;
                }
                failure[t] = s;
            }

            // Search for the pattern in the text
            int i = 0;
            int j = -1;
            while (i < n)
            {
                while (j >= 0 && text[i] != pattern[j + 1])
                {
                    j = failure[j];
                }
                if (text[i] == pattern[j + 1])
                {
                    j++;
                }
                if (j == m - 1)
                {
                    // The pattern was found at index i - m + 1
                    return i - m + 1;
                }
                i++;
            }

            // The pattern was not found in the text
            return -1;
        }
    }
}