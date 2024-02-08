namespace CSharp.Data_Structures;

public class basics
{
    void Main(string[] args)
    {
        char carac = 'a';
        bool test = true;
        string chaine = "12345";
        string chaine2 = "test mot2";
        int numb = 1;
        long conv2 = long.Parse(chaine);
        float numb3 = (float)numb;
        long grand = 5;
        string numb1 = "1";
        double conv = double.Parse(numb1);
        float virgule = 1.0f;
        double virgule_big = 244.5;

        Console.WriteLine(char.ToLower('A')); // Converts 'A' to lowercase and prints 'a'
        Console.WriteLine(char.ToUpper('x')); // Converts 'x' to uppercase and prints 'X'
        Console.WriteLine(char.IsDigit('w')); // Checks if 'w' is a digit (prints 'false')
        Console.WriteLine(char.IsLetter('2')); // Checks if '2' is a letter (prints 'false')
        Console.WriteLine(char.IsUpper('q')); // Checks if 'q' is uppercase (prints 'false')
        Console.WriteLine(char.IsLower('W')); // Checks if 'W' is lowercase (prints 'false')

        Console.WriteLine(chaine2[3]); // Retrieves the character at index 3 in 'chaine2'
        Console.WriteLine(chaine2.Length); // Prints the length of the string 'chaine2'
        Console.WriteLine(chaine2.ToUpper()); // Converts 'chaine2' to uppercase
        Console.WriteLine(chaine2.ToLower()); // Converts 'chaine2' to lowercase

        string[] mots = chaine2.Split(' '); // Splits 'chaine2' into an array of strings using space as the delimiter
        char[] mot = chaine2.ToCharArray(); // Converts 'chaine2' to a character array
        string[] letters = chaine2.Split("");

        // LINEAR DATA STRUCTURES

        int[] nbTab = new int[6];
        int j = 0;
        for (int i = 15; i <= 20; i++)
        {
            nbTab[j] = i;
            j++;
        }
        int[] tab3 = nbTab.Take(2).ToArray();

        List<int> arrlist0 = new List<int> { 1, 2, 3 };
        List<int> arrlist = new List<int>(nbTab);
        arrlist.Add(1);
        int t0 = arrlist.Count;
        arrlist.RemoveAt(0);
        bool c0 = arrlist.Contains(2);
        int r0 = arrlist[2];
        arrlist[0] = 10;
        Console.WriteLine(arrlist.Count == 0);
        Console.WriteLine(string.Join(", ", arrlist));

        LinkedList<int> ll = new LinkedList<int>(nbTab);
        ll.AddLast(45);
        int t1 = arrlist.Count;
        arrlist.RemoveAt(0);
        bool c1 = arrlist.Contains(2);
        int r1 = arrlist[2];
        arrlist[0] = 10;
        Console.WriteLine(ll.First.Value);
        Console.WriteLine(ll.Last.Value);
        Console.WriteLine(ll.Count == 0);
        Console.WriteLine(string.Join(", ", ll));

        HashSet<int> s = new HashSet<int>(ll);
        ll.AddLast(4);
        int t2 = arrlist.Count;
        arrlist.RemoveAt(0);
        bool c2 = arrlist.Contains(2);
        int r2 = arrlist[2];
        arrlist[0] = 10;
        Console.WriteLine(s.Count == 0);
        Console.WriteLine(string.Join(", ", s));

        Stack<char> st = new Stack<char>();
        st.Push('a');
        st.Push('b');
        st.Push('c');
        Console.WriteLine(st.Peek());
        Console.WriteLine(st.Contains('a'));
        Console.WriteLine(st.Pop());
        Console.WriteLine(st.Count == 0);
        Console.WriteLine(string.Join(", ", st));
        st.Clear();

        Queue<int> q = new Queue<int>();
        q.Enqueue(1);
        q.Enqueue(2);
        q.Enqueue(3);
        Console.WriteLine(q.Peek());
        Console.WriteLine(q.Dequeue());
        Console.WriteLine(q.Contains(1));
        Console.WriteLine(q.Count == 0);
        Console.WriteLine(string.Join(", ", q));

        // NON LINEAR DATA STRUCTURES

        // Dictionary
        Dictionary<int, string> m0 = new Dictionary<int, string> { { 1, "v1" }, { 2, "v2" }, { 3, "v3" } };
        Dictionary<int, string> m = new Dictionary<int, string>(m0);
        m[50] = "v50";
        m[75] = "Nothing";
        int t3 = m.Count;
        m.Remove(3);
        bool ck = m.ContainsKey(2);
        bool cv = m.ContainsValue("George");
        string val = m[50];
        Console.WriteLine(string.Join(", ", m.Select(kv => kv.Key + "=" + kv.Value)));

        foreach (int key in m.Keys)
        {
            int k = key;
        }

        foreach (string value in m.Values)
        {
            string v = value;
        }

        foreach (KeyValuePair<int, string> entry in m)
        {
            int keys = entry.Key;
            string values = entry.Value;
        }
        m.Clear();
    }
}