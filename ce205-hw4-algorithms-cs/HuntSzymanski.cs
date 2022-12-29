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
    public static class HuntSzymanski
    {
        /**
        * @name Search 
        * @param [in] text [\b string]
        * @param [in] keyword [\b string]
        * @retval [\b int]
        * This function helps us to find the string text we entered when we search for it in our application.
        * It is the search function.
        **/
        public static int Search(string text, string keyword)
        {
            // Calculate the hash of the keyword
            long keywordHash = CalculateHash(keyword);

            // Check the hashes of the substrings of the text
            for (int i = 0; i < text.Length - keyword.Length + 1; i++)
            {
                // Calculate the hash of the current substring
                long textHash = CalculateHash(text.Substring(i, keyword.Length));

                // Check if the hash of the current substring matches the hash of the keyword
                if (keywordHash == textHash)
                {
                    // Check if the current substring is equal to the keyword
                    bool isMatch = true;
                    for (int j = 0; j < keyword.Length; j++)
                    {
                        if (text[i + j] != keyword[j])
                        {
                            isMatch = false;
                            break;
                        }
                    }

                    // Return the index if the current substring is equal to the keyword
                    if (isMatch)
                    {
                        return i;
                    }
                }
            }

            // Return -1 if the keyword was not found
            return -1;
        }

        /**
        * @name CalculateHash 
        * @param [in] s [\b string]
        * @retval [\b long]
        * A hash function is an algorithm or subroutine that maps variable-length datasets to fixed-length datasets.
        **/
        public static long CalculateHash(string s)
        {
            // Use the Horner's method to calculate the hash of the string
            long hash = 0;
            for (int i = 0; i < s.Length; i++)
            {
                hash = (hash * 31 + s[i]) % int.MaxValue;
            }
            return hash;
        }
    }
}
