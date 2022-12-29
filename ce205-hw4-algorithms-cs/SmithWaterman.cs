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
    public class SmithWaterman
    {
        private readonly string sequence1;
        private readonly string sequence2;
        private readonly int[,] scoreMatrix;
        private readonly int gapPenalty;

        public SmithWaterman(string sequence1, string sequence2, int gapPenalty)
        {
            this.sequence1 = sequence1;
            this.sequence2 = sequence2;
            this.gapPenalty = gapPenalty;

            int m = sequence1.Length;
            int n = sequence2.Length;
            scoreMatrix = new int[m + 1, n + 1];
        }

        /**
        * @name Compute 
        * @retval [\b int]
        * Find the maximum score in the score matrix.
        **/
        public int Compute()
        {
            // Fill the score matrix.
            for (int i = 1; i <= sequence1.Length; i++)
            {
                for (int j = 1; j <= sequence2.Length; j++)
                {
                    int scoreDiag = scoreMatrix[i - 1, j - 1] + Score(i, j);
                    int scoreUp = scoreMatrix[i, j - 1] + gapPenalty;
                    int scoreLeft = scoreMatrix[i - 1, j] + gapPenalty;

                    scoreMatrix[i, j] = Math.Max(Math.Max(scoreDiag, scoreUp), scoreLeft);
                }
            }

            int maxScore = 0;
            for (int i = 1; i <= sequence1.Length; i++)
            {
                for (int j = 1; j <= sequence2.Length; j++)
                {
                    if (scoreMatrix[i, j] > maxScore)
                    {
                        maxScore = scoreMatrix[i, j];
                    }
                }
            }

            return maxScore;
        }

        /**
        * @name Score 
        * @param [in] i [\b int]
        * @param [in] j [\b int]
        * @retval [\b int]
        **/
        private int Score(int i, int j)
        {
            if (sequence1[i - 1] == sequence2[j - 1])
            {
                return 2;
            }
            else
            {
                return -1;
            }
        }
    }
}