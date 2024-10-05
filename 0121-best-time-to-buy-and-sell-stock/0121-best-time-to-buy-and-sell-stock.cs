public class Solution {
    public int MaxProfit(int[] prices) {
        int min_price=int.MaxValue;
        int max_profit=0;

        foreach(var price in prices){
            min_price=Math.Min(price,min_price);
            int profit=price-min_price;
            max_profit=Math.Max(profit,max_profit);
        }
        return max_profit;

    }
}