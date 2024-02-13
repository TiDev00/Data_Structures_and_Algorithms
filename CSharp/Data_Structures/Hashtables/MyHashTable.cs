namespace CSharp.Data_Structures.Hashtables;

class Bucket
{
    public List<object[]> Data;

    public Bucket()
    {
        this.Data = new List<object[]>();
    }
}
class MyHashTable
{
    int capacity;
    List<Bucket> buckets;

    public MyHashTable()
    {
        this.capacity = 11;
        this.buckets = new List<Bucket>(this.capacity);
        for (int i = 1; i <= this.capacity; i++)
        {
            this.buckets.Add(new Bucket());
        }
    }

    int HashFunction(object key)
    {
        return Math.Abs(key.GetHashCode()) % this.capacity;
    }

    public object Get(object key)
    {
        int hash = HashFunction(key);
        Bucket bucket = this.buckets[hash];
        foreach (Object[] tab in bucket.Data)
        {
            if (tab[0] == key)
            {
                return tab[1];
            }
        }
        return null;
    }

    public void Put(object key, object value)
    {
        int hash = HashFunction(key);
        Bucket bucket = this.buckets[hash];
        bool keyFound = false;
        foreach (Object[] tab in bucket.Data)
        {
            if (tab[0] == key)
            {
                tab[1] = value;
                keyFound = true;
                break;
            }
        }
        if (!keyFound)
        {
            bucket.Data.Add(new object[] { key, value });
        }
    }
    
    public void Del(object key)
    {
        int hash = HashFunction(key);
        Bucket bucket = this.buckets[hash];
        int index = -1;
        bool keyFound = false;
        for (int i = 0; i < bucket.Data.Count; i++)
        {
            if (bucket.Data[i][0] == key)
            {
                index = i;
                keyFound = true;
                break;
            }
        }
        if (keyFound)
        {
            bucket.Data.RemoveAt(index);
        }
        else
        {
            Console.WriteLine("Key not in dictionary");
        }
    }

    public void Display()
    {
        for (int i = 0; i < this.buckets.Count; i++)
        {
            Bucket bucket = this.buckets[i];
            Console.Write("Bucket " + i + ": ");
            if (bucket.Data.Count > 0)
            {
                foreach (var kv in bucket.Data)
                {
                    Console.Write($"[{kv[0]}, {kv[1]}], ");
                }
            }
            else
            {
                Console.Write("Empty");
            }
            Console.WriteLine();
        }
    }

    static void Main(string[] args)
    {
        MyHashTable hashTable = new MyHashTable();
        hashTable.Put("clé", 5);
        hashTable.Put(2, "date");
        hashTable.Put(4, 55);
        hashTable.Display();
        Console.WriteLine(hashTable.Get(2));
        hashTable.Del("clé");
        hashTable.Display();
    }
}