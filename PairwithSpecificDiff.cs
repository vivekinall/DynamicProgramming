using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace PracticeProject
{
    public class PairwithSpecificDiff
    {
        /// <summary>
        /// input:  arr = [1,5,11,7], k = 4
        /// output: [[1, 0], [0, -1], [-1, -2], [2, 1]]
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        public static int[,] FindPairsWithGivenDifference(int[] arr, int k)
        {
            Dictionary<int, int> test = new Dictionary<int, int>();
            List<Pair> res = new System.Collections.Generic.List<Pair>();
            for (int i = 0; i < arr.Length; i++)
            {
                test.Add(arr[i]- k, arr[i]);
            }
            for (int i = 0; i < arr.Length; i++)
            {
               if(test.ContainsKey(arr[i]))
                {
                    Pair p = new Pair();
                    p.key = test[arr[i]];
                    p.value = arr[i];
                    res.Add(p);
                }
            }
            int[,] final = new int[res.Count,2];
            for (int i = 0; i < res.Count; i++)
            {           

                    final[i, 0] = res[i].key;
                    final[i, 1] = res[i].value;
                
            }


            return final;
        }

        class Pair
        {
           public int key;
           public int value;
        }
        
    }
}
