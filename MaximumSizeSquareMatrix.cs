using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace PracticeProject
{
    class MaximumSizeSquareMatrix
    {
        public static void printMaxSubSquare(char[][] m)
        {
            int rowCount = m.GetLength(0);
            int colCount = 5;
            char[][] s = new char[rowCount][];
            for (int i = 0; i < rowCount; i++)
            {
                s[i][0] = m[i][0];
            }

            for (int i = 0; i < colCount; i++)
            {
                s[0][i] = m[0][i];
            }

            for (int i = 1; i < rowCount; i++)
            {
                for (int j = 1; j < colCount; j++)
                {
                    if (m[i][j] == 1)
                    {
                        s[i][j] =Convert.ToChar(Min(Convert.ToInt32(s[i][j - 1]), Convert.ToInt32(s[i - 1][j]), Convert.ToInt32(s[i - 1][j - 1])) + 1);
                    }
                    if (m[i][j] == 0)
                        s[i][j] = m[i][j];

                }

            }
            //print the changes Array.
            //for (int i = 0; i < rowCount; i++)
            //{
            //    for (int j = 0; j < colCount; j++)
            //    {
            //        Console.Write(s[i, j] + " ");
            //    }
            //    Console.WriteLine();
            //}
            /* Find the maximum entry, and indexes of  maximum entry in S[,] */
            int max = s[0][0];
            int max_i = 0;
            int max_j = 0;
            for (int i = 0; i < rowCount; i++)
            {
                for (int j = 0; j < colCount; j++)
                {
                    if (max < s[i][j])
                    {
                        max = s[i][j];
                        max_i = i;
                        max_j = j;
                    }
                }

            }
            for (int i = max_i; i > max_i - max; i--)
            {
                for (int j = max_j; j > max_j - max; j--)
                {
                    Console.Write(m[i][j] + " ");
                }
                Console.WriteLine();
            }
            //  return 1;
        }

        public static void printMaxSubSquare(int[,] m)
        {
            int rowCount = m.GetLength(0);
            int colCount = m.GetLength(1);
            int[,] s = new int[rowCount, colCount];
            for (int i = 0; i < rowCount; i++)
            {
                s[i, 0] = m[i, 0];
            }

            for (int i = 0; i < colCount; i++)
            {
                s[0, i] = m[0, i];
            }

            for (int i = 1; i < rowCount; i++)
            {
                for (int j = 1; j < colCount; j++)
                {
                    if(m[i,j]== 1)
                    {
                        s[i, j] = Min(s[i, j-1],s[i-1, j],s[i-1, j - 1])+1;
                    }
                    if (m[i, j] == 0)
                        s[i, j] = m[i, j];                 
                    
                }

            }
            //print the changes Array.
            //for (int i = 0; i < rowCount; i++)
            //{
            //    for (int j = 0; j < colCount; j++)
            //    {
            //        Console.Write(s[i, j] + " ");
            //    }
            //    Console.WriteLine();
            //}
            /* Find the maximum entry, and indexes of  maximum entry in S[,] */
            int max = s[0, 0];
            int max_i = 0;
            int max_j = 0;
            for (int i = 0; i < rowCount; i++)
            {
                for (int j = 0; j < colCount; j++)
                {
                    if (max < s[i, j])
                    {
                        max = s[i, j];
                        max_i = i;
                        max_j = j;
                    }
                }

            }
            for (int i = max_i; i > max_i - max; i--)
            {
                for (int j = max_j; j > max_j - max; j--)
                {
                    Console.Write(m[i, j] + " ");
                }
                Console.WriteLine();
            }
            //  return 1;
        }

        private static int Min(int v1, int v2, int v3)
        {
            return Math.Min(Math.Min(v1, v2), v3);          
        }
    }
}
