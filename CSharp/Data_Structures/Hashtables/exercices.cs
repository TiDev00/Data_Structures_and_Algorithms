namespace CSharp.Data_Structures.Hashtables;

public class exercices
{
    static int FirstRecurringCharacter(int[] tab)
    {
        Dictionary<int, int> myMap = new Dictionary<int, int>();
        int index = 0;
        foreach (int val in tab)
        {
            if (myMap.ContainsKey(val))
            {
                return val;
            }
            myMap.Add(val, index);
        }

        return -1;
    }
    
    

    public static void main()
    {
        Console.WriteLine(FirstRecurringCharacter(new[]{1,2,3,2}));
    }
}