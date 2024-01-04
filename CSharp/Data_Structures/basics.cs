namespace CSharp.Data_Structures;

public class basics
{
    public static void Main()
    {
        // Characters, String, int, float, double
        char carac = 'a';
        String chaine2 = "test mot2";
        int numb = 1;
        long grand = numb;
        bool test = false;
        String numb1 = "1";
        // Utlisation de la conversion explicite si conversion entre type numeric et parsing pour les string
        double conv = double.Parse(numb1);
        double conversion1 = Convert.ToDouble(numb1);
        float virgule = 1.0f;
        double virgule_big = 244.5;

        // char and String methods
        Console.WriteLine(char.ToLower('A')); // Converts 'A' to lowercase: 'a'
        Console.WriteLine(char.ToUpper('x')); // Converts 'x' to uppercase: 'X'
        Console.WriteLine(char.IsDigit('w')); // Checks if 'w' is a digit (false)
        Console.WriteLine(char.IsLetter('2')); // Checks if '2' is a letter (false)
        Console.WriteLine(char.IsUpper('q')); // Checks if 'q' is uppercase (false)
        Console.WriteLine(char.IsLower('W')); // Checks if 'W' is lowercase (false)

        Console.WriteLine(chaine2.Length); // Prints the length of the string
        Console.WriteLine(chaine2.Contains('a')); // Checks if 'chaine2' contains 'a'
        Console.WriteLine(chaine2.EndsWith('a')); // Checks if 'chaine2' ends with 'a'
        Console.WriteLine(chaine2.StartsWith('b')); // Checks if 'chaine2' starts with 'b'
        Console.WriteLine(chaine2.Substring(1, 3)); // Retrieves substring starting from index 1 with length 3
        Console.WriteLine(chaine2.ToUpper()); // Converts 'chaine2' to uppercase
        Console.WriteLine(chaine2.ToLower()); // Converts 'chaine2' to lowercase
        Console.WriteLine(chaine2[3]); // Retrieves character at index 3 in 'chaine2'
        Console.WriteLine(chaine2.IndexOf('t')); // Gets the first index of 't' in 'chaine2'
        Console.WriteLine(chaine2.LastIndexOf('t')); // Gets the last index of 't' in 'chaine2'
        Console.WriteLine(chaine2.Replace('t', 'A')); // Replaces all occurrences of 't' with 'A' in 'chaine2'

        String[] mots = chaine2.Split(' '); // Splits 'chaine2' into an array of strings based on spaces
        Console.WriteLine(String.IsNullOrEmpty(chaine2)); // Checks if 'chaine2' is null or empty (not null or empty -> false)
        Console.WriteLine(String.IsNullOrWhiteSpace(chaine2)); // Checks if 'chaine2' is null, empty, or whitespace (not whitespace -> false)

        char[] mot = chaine2.ToCharArray(); // Converts 'chaine2' into an array of characters


        // ARRAY

        int[] tab = new int[3]; 
        char[] tab2 = {'1', '3', '2'};

        Console.WriteLine();

        for(int index = 0; index < tab2.Length; index++)
        {
            Console.WriteLine(tab2[index]);
        }

        Console.WriteLine();

        // Methodes speciales array 

        Array.Sort(tab2);
        Console.WriteLine(tab2);

        Array.Reverse(tab2);
        Console.WriteLine(tab2);

        Console.WriteLine(Array.IndexOf(tab2, '1'));
        Console.WriteLine();

        char[] tab3 = new char[2];
        Array.Copy(tab2, tab3, 2);

        // LIST

        List<char> maliste = new List<char>();
        List<int> ml = new List<int> {4,1,2,5};
        foreach (int entier in ml)
        {
            Console.WriteLine(entier);
        }

        // Methodes speciales list

        ml.Sort();
        foreach (int var in ml)
        {
            Console.WriteLine(var);
        }

        ml.Reverse();
        foreach (int var in ml)
        {
            Console.WriteLine(var);
        }

        ml.Add(7);
        foreach (int var in ml)
        {
            Console.WriteLine(var);
        }

        Console.WriteLine(ml.Contains(3));

        Console.WriteLine(ml.Count);

        Console.WriteLine(ml.IndexOf(2));

        ml.Insert(0, 9);

        ml.Remove(7);

        ml.RemoveAt(1);
        Console.WriteLine();

        foreach (int var in ml)
        {
            Console.WriteLine(var);
        }

        ml.Clear();

    }
}