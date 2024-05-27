public int NumRescueBoats(int[] people, int limit)
{
    Array.Sort(people);

    int turn = 0;
    int pointer1 = 0;
    int pointer2 = people.Length - 1;

    while (pointer1 <= pointer2)
    {
        if (people[pointer1] + people[pointer2] <= limit) 
        {
            pointer1++;
            pointer2--;
            turn++;
        }
        else
        {
            pointer2--;
            turn++;
        }
    }
    return turn;
}