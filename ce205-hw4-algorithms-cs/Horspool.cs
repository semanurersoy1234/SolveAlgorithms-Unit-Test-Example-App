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
    public static class Horspool
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
            // Check for empty input
            if (string.IsNullOrEmpty(text) || string.IsNullOrEmpty(keyword))
            {
                return -1;
            }

            // Create the shift table
            int[] shiftTable = CreateShiftTable(keyword);

            // Search for the keyword
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
                i += shiftTable[text[i + keyword.Length - 1]];
            }

            // Keyword not found
            return -1;
        }

        /**
        * @name CreateShiftTable 
        * @param [in] keyword [\b string]
        * @retval [\b int[]]
        * This function create the shift table.
        **/
        private static int[] CreateShiftTable(string keyword)
        {
            // Create the shift table
            int[] shiftTable = new int[char.MaxValue];
            for (int i = 0; i < shiftTable.Length; i++)
            {
                shiftTable[i] = keyword.Length;
            }
            for (int i = 0; i < keyword.Length - 1; i++)
            {
                shiftTable[keyword[i]] = keyword.Length - 1 - i;
            }

            // Return the shift table
            return shiftTable;
        }
    }
}
