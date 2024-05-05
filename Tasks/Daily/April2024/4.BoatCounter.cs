namespace Tasks.Daily.April2024;

public class BoatCounter
{
    public static int NumRescueBoats1(int[] people, int limit) // Wrong version
    {
        var boats = new List<int>();

        for (int i = 0; i < people.Length; i++)
        {
            var boatForPerson = boats.FirstOrDefault(x => x + people[i] <= limit);

            if (boatForPerson == 0)
            {
                boats.Add(people[i]);
            }
            else
            {
                boats[boats.IndexOf(boatForPerson)] += people[i];
            }

        }

        return boats.Count;
    }

    public static int NumRescueBoats2(int[] people, int limit) // Wrong version
    {
        Array.Sort(people);

        int boats = 0;
        int left = 0, right = people.Length - 1;
        
        while (left <= right)
        {
            if (people[left] + people[right] <= limit)
            {
                left++;
            }

            right--;
            boats++;
        }

        return boats;
    }
}
