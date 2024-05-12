namespace Tasks.Daily.May2024;

public static class Miser
{
    //public static double MincostToHireWorkers(int[] quality, int[] wage, int k)
    //{
    //    int n = quality.Length;
    //    var totalCost = double.MaxValue;
    //    var sortedRatio = SortRatio(CalculateWageToQualityRatio(quality, wage));

    //    var highestQualityWorkers = new PriorityQueue<int, int>(Comparer<int>.Create((x, y) => y - x));
    //    int currentTotalQuality = 0;

    //    for (int i = 0; i < sortedRatio.Count; i++)
    //    {
    //        var current = sortedRatio[i];
    //        highestQualityWorkers.Enqueue(current.Item2, current.Item2);
    //        currentTotalQuality += current.Item2;

    //        if (highestQualityWorkers.Count() > k)
    //        {
    //            highestQualityWorkers.Sort();
    //            highestQualityWorkers.Remove(current.Item2);
    //            currentTotalQuality -= highestQualityWorkers.Last();
    //        }

    //        if (highestQualityWorkers.Count() == k)
    //        {
    //            totalCost = Math.Min(totalCost, currentTotalQuality * sortedRatio[i].Item1);
    //        } 
    //    }

    //    return totalCost;
    //}

    //public static List<(double, int)> CalculateWageToQualityRatio(int[] quality, int[] wage)
    //{
    //    List<(double, int)> ratio = new();
    //    for (int i = 0; i < quality.Length; i++)
    //    {
    //        ratio.Add(((double)wage[i] / quality[i], quality[i]));
    //    }

    //    return ratio;
    //}

    //public static List<(double, int)> SortRatio(List<(double, int)> ratio) =>
    //    ratio.OrderByDescending(x => x.Item1).ToList();

    public static double MincostToHireWorkers(int[] quality, int[] wage, int k)
    {
        var n = quality.Length;
        var q1 = new PriorityQueue<(int, int), double>();

        for (int i = 0; i < n; i++)
        {
            q1.Enqueue((quality[i], wage[i]), (1.0 * wage[i]) / quality[i]);
        }

        var result = double.MaxValue;
        var sum = 0.0;
        var q2 = new PriorityQueue<double, double>();

        while (q1.Count > 0)
        {
            var (ql, wg) = q1.Dequeue();
            var r = wg / (1.0 * ql);

            sum += ql;

            q2.Enqueue(-ql, -ql);

            if (q2.Count > k)
            {
                sum += q2.Dequeue();
            }

            if (q2.Count == k)
            {
                result = Math.Min(result, sum * r);
            }
        }

        return result;
    }
}
