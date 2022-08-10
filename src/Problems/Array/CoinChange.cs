namespace Problems.Array;

/// <summary>
/// You are given an integer array coins representing coins of different denominations 
/// and an integer amount representing a total amount of money.
/// Return the fewest number of coins that you need to make up that amount.
/// If that amount of money cannot be made up by any combination of the coins, return -1.
/// You may assume that you have an infinite number of each kind of coin.
/// </summary>

/// <example>
/// Input: coins = [1,2,5], amount = 11
/// Output: 3
/// Explanation: 11 = 5 + 5 + 1
/// </example>
public class CoinChange
{
    public int Solution(int[] coins, int amount)
    {
        System.Array.Sort(coins);
        var dp = new int[amount + 1];
        System.Array.Fill(dp, int.MaxValue);
        dp[0] = 0;
        for (var i = 0; i < dp.Length; i++)
        {
            for (var j = 0; j < coins.Length; j++)
            {
                var coinTest = coins[j];
                if (coinTest <= i)
                    dp[i] = System.Math.Min(dp[i], 1 + dp[i - coinTest]);
                else
                    break;
            }
        }
        return dp[amount] > amount ? -1 : dp[amount];
    }
}
