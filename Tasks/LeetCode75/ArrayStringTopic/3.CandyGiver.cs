namespace Tasks.LeetCode75.ArrayStringTopic;

public class CandyGiver
{
    public IList<bool> KidsWithCandies1(int[] candies, int extraCandies)
    {
        List<bool> maxCandiesList = new();
        for (int i = 0; i < candies.Length; i++)
        {
            int currentWithExtra = candies[i] + extraCandies;
            maxCandiesList.Add(IsMaxCandies(candies, currentWithExtra));
        }

        return maxCandiesList;
    }

    public bool IsMaxCandies(int[] candies, int currentWithExtra)
    {
        for (int j = 0; j < candies.Length; j++)
        {
            if (candies[j] > currentWithExtra) return false;
        }

        return true;
    }

    public IList<bool> KidsWithCandies2(int[] candies, int extraCandies)
    {
        int maxCandies = candies.Max();

        List<bool> maxCandiesList = new();
        for (int i = 0; i < candies.Length; i++)
        {
            maxCandiesList.Add(candies[i] + extraCandies >= maxCandies);
        }

        return maxCandiesList;
    }

}