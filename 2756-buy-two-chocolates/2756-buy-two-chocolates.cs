public class Solution {
    public int BuyChoco(int[] prices, int money) {
        Array.Sort(prices);
        int cost=prices[0]+prices[1];
        if(cost<=money){
            return money-cost;
        }
        return money;
    }
}