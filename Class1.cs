using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Runtime.InteropServices.ComTypes;
using System.Text;

namespace PracticeProject
{
    public class Solution1
    {
        public static int MinPathSum(int[][] grid)
        {
            if (grid.Length == 0)
            {
                return 0;
            }
            int n = grid.Length;
           
            int c = grid[0].Length;
            int[][] dp=new int[n][];
            for (int i = 0; i < grid[0].Length; i++)
            {
                dp[i] = new int[grid[0].Length];
            }
           
             for (int i=0;i<grid.Length;i++)
                {
                 for (int j=0;j<grid[0].Length;j++)
                    {
               
                     dp[i][j] +=grid[i][j];
            
                        if(i >0 && j >0)
                        {
                            dp[i][j] += Math.Min(grid[i - 1][j], grid[i][j - 1]);                    
                        }
                        if(i >0)
                        {
                            dp[i][j] +=grid[i - 1][j];
                        }
                        if(j > 0)
                        {
                            dp[i][j] += grid[i][j - 1];
                        }
                  }
               }
       
        return dp[grid.Length - 1][grid[0].Length - 1];
        }
    }
}
        
    

