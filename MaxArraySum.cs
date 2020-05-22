using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeProject
{
    public class MaxArraySum
    {
        public static int SubarraySum(int[] nums, int k)
        {
            int n = nums.Length;
            int sum = k;
            Dictionary<int, int> prevSum = new Dictionary<int, int>();

            int res = 0;

            // Sum of elements so far 
            int currsum = 0;

            for (int i = 0; i < n; i++)
            {

                // Add current element to sum so far. 
                currsum += nums[i];

                // If currsum is equal to desired sum,  
                // then a new subarray is found. So  
                // increase count of subarrays. 
                if (currsum == sum)
                    res++;

                // currsum exceeds given sum by currsum  
                // - sum. Find number of subarrays having  
                // this sum and exclude those subarrays  
                // from currsum by increasing count by  
                // same amount. 
                if (prevSum.ContainsKey(currsum - sum))
                    res += prevSum[currsum - sum];

                // Add currsum value to count of  
                // different values of sum. 
                if (!prevSum.ContainsKey(currsum))
                    prevSum.Add(currsum, 1);
                else
                {
                    int count = prevSum[currsum];
                    prevSum[currsum] = count + 1;
                }
            }
            return res;
        }
    }
}
