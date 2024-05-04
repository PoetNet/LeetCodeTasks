namespace Tasks.Daily.April2024;

public class BoatCounter
{
    public static int NumRescueBoats(int[] people, int limit)
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
}
