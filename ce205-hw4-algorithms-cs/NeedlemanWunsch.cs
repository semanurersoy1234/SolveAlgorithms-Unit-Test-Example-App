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
using System.IO;

namespace ce205_hw4_algorithms_cs
{
    public static class NeedlemanWunsch
    {
        // Scoring matrix for DNA sequences
        private static int[,] NUCLEOTIDE_ID = { { 10, -1, -3, -4 },
                                                { -1,  7, -5, -3 },
                                                { -3, -5,  9,  0 },
                                                { -4, -3,  0,  8 } };

        // Enum for the four possible nucleotides
        private enum Nucleotide
        {
            A, C, G, T
        }

        /**
        * @name NucleotideToIndex 
        * @param [in] nucleotide [\b char]
        * @retval [\b int]
        * Returns the index of the given nucleotide in the NUCLEOTIDE_ID matrix
        **/
        private static int NucleotideToIndex(char nucleotide)
        {
            switch (nucleotide)
            {
                case 'A':
                    return (int)Nucleotide.A;
                case 'C':
                    return (int)Nucleotide.C;
                case 'G':
                    return (int)Nucleotide.G;
                case 'T':
                    return (int)Nucleotide.T;
                default:
                    throw new ArgumentException("Invalid nucleotide: " + nucleotide);
            }
        }

        /**
        * @name Align 
        * @param [in] sequence1 [\b string]
        * @param [in] sequence2 [\b string]
        * @retval [\b string]
        * Aligns the given DNA sequences using the Needleman-Wunsch algorithm
        **/
        public static (string, string) Align(string sequence1, string sequence2)
        {
            // Initialize the scoring matrix
            int m = sequence1.Length;
            int n = sequence2.Length;
            int[,] score = new int[m + 1, n + 1];
            for (int h = 0; h <= m; h++)
            {
                score[h, 0] = -h;
            }
            for (int k = 0; k <= n; k++)
            {
                score[0, k] = -k;
            }

            // Fill the scoring matrix
            for (int h = 1; h <= m; h++)
            {
                for (int k = 1; k <= n; k++)
                {
                    int s = NUCLEOTIDE_ID[NucleotideToIndex(sequence1[h - 1]), NucleotideToIndex(sequence2[k - 1])];
                    score[h, k] = Math.Max(Math.Max(score[h - 1, k] - 1, score[h, k - 1] - 1), score[h - 1, k - 1] + s);
                }
            }

            // Traceback to find the optimal alignment
            string aligned1 = "";
            string aligned2 = "";
            int i = m;
            int j = n;
            while (i > 0 || j > 0)
            {
                if (i > 0 && j > 0 && score[i, j] == score[i - 1, j - 1] + NUCLEOTIDE_ID[NucleotideToIndex(sequence1[i - 1]), NucleotideToIndex(sequence2[j - 1])])
                {
                    aligned1 = sequence1[i - 1] + aligned1;
                    aligned2 = sequence2[j - 1] + aligned2;
                    i--;
                    j--;
                }
                else if (i > 0 && score[i, j] == score[i - 1, j] - 1)
                {
                    aligned1 = sequence1[i - 1] + aligned1;
                    aligned2 = "-" + aligned2;
                    i--;
                }
                else
                {
                    aligned1 = "-" + aligned1;
                    aligned2 = sequence2[j - 1] + aligned2;
                    j--;
                }
            }

            return (aligned1, aligned2);
        }
    }
}
