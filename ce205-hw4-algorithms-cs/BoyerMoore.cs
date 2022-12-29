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
    public static class BoyerMoore
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
            // Return -1 if the keyword is empty
            if (keyword.Length == 0)
            {
                return -1;
            }

            // Calculate the bad character shift table
            int[] badCharShift = CalculateBadCharShift(keyword);

            // Calculate the good suffix shift table
            int[] goodSuffixShift = CalculateGoodSuffixShift(keyword);

            // Search for the keyword in the text
            int i = 0;
            while (i <= text.Length - keyword.Length)
            {
                int j;
                for (j = keyword.Length - 1; j >= 0 && keyword[j] == text[i + j]; j--)
                {
                }

                if (j < 0)
                {
                    return i;
                }

                i += Math.Max(goodSuffixShift[j], badCharShift[text[i + j]] - keyword.Length + 1 + j);
            }

            return -1;
        }

        /**
        * @name CalculateBadCharShift 
        * @param [in] keyword [\b string]
        * @retval [\b int[]]
        * Here we consider two cases, and we call the character of the text which is not matching with the pattern character a bad character.
        * Case 1: The mismatched character of text T is present in pattern P.
        * In this case, we will shift the pattern P until it gets aligned to the mismatched character of T.
        **/
        private static int[] CalculateBadCharShift(string keyword)
        {
            int[] shift = new int[char.MaxValue + 1];

            for (int i = 0; i < shift.Length; i++)
            {
                shift[i] = keyword.Length;
            }

            for (int i = 0; i < keyword.Length - 1; i++)
            {
                shift[keyword[i]] = keyword.Length - 1 - i;
            }

            return shift;
        }

        /**
        * @name CalculateGoodSuffixShift 
        * @param [in] keyword [\b string]
        * @retval [\b int[]]
        * Let t be substring of text T which is matched with substring of pattern P. Now we shift pattern until :
        * 1- Another occurrence of t in P matched with t in T.
        * 2- A prefix of P, which matches with suffix of t
        * 3- P moves past t
        **/
        private static int[] CalculateGoodSuffixShift(string keyword)
        {
            int[] shift = new int[keyword.Length];
            int lastPrefixIndex = keyword.Length - 1;

            for (int i = keyword.Length - 1; i >= 0; i--)
            {
                if (IsPrefix(keyword, i + 1))
                {
                    lastPrefixIndex = i + 1;
                }
                shift[i] = lastPrefixIndex + keyword.Length - 1 - i;
            }

            for (int i = 0; i < keyword.Length - 1; i++)
            {
                int slen = SuffixLength(keyword, i);
                if (keyword[i - slen] != keyword[keyword.Length - 1 - slen])
                {
                    shift[keyword.Length - 1 - slen] = keyword.Length - 1 - i + slen;
                }
            }

            return shift;
        }

        /**
        * @name IsPrefix 
        * @param [in] keyword [\b string]
        * @param [in] p [\b int]
        * @retval [\b bool]
        * This function checks if the code is a prefix expression.
        **/
        private static bool IsPrefix(string keyword, int p)
        {
            for (int i = p, j = 0; i < keyword.Length; i++, j++)
            {
                if (keyword[i] != keyword[j])
                {
                    return false;
                }
            }

            return true;
        }

        /**
        * @name SuffixLength 
        * @param [in] keyword [\b string]
        * @param [in] p [\b int]
        * @retval [\b int]
        * This is the function that returns the length of the suffix.
        **/
        private static int SuffixLength(string keyword, int p)
        {
            int len = 0;
            for (int i = p, j = keyword.Length - 1; i >= 0 && keyword[i] == keyword[j]; i--, j--)
            {
                len++;
            }

            return len;
        }
    }
}
