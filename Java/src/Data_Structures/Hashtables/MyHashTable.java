package Data_Structures.Hashtables;

import java.util.ArrayList;
import java.util.Arrays;

class Bucket {
    ArrayList<Object[]> data;

    Bucket() {
        this.data = new ArrayList<>();
    }
}

class MyHashTable {
    int capacity;
    ArrayList<Bucket> buckets;

    public MyHashTable() {
        this.capacity = 11;
        this.buckets = new ArrayList<>(this.capacity);
        for (int i = 1; i <= this.capacity; i++) {
            this.buckets.add(new Bucket());
        }
    }

    int hashFunction(Object key) {
        return Math.abs(key.hashCode()) % this.capacity;
    }

    Object get(Object key) {
        int hash = hashFunction(key);
        Bucket bucket = this.buckets.get(hash);
        for (Object[] tab : bucket.data) {
            if (tab[0] == key) {
                return tab[1];
            }
        }
        return null;
    }

    void put(Object key, Object value) {
        int hash = hashFunction(key);
        Bucket bucket = this.buckets.get(hash);
        boolean keyfound = false;
        for (Object[] tab : bucket.data) {
            if (tab[0] == key) {
                tab[1] = value;
                keyfound = true;
                break;
            }
        }
        if (!keyfound) {
            bucket.data.add(new Object[]{key, value});
        }
    }

    void del(Object key) {
        int hash = hashFunction(key);
        Bucket bucket = this.buckets.get(hash);
        int index = -1;
        boolean keyfound = false;
        for (int i = 0; i < bucket.data.size(); i++) {
            if (bucket.data.get(i)[0] == key) {
                index = i;
                keyfound = true;
                break;
            }
        }
        if (keyfound) {
            bucket.data.remove(index);
        } else {
            System.out.println("Key not in dictionary");
        }
    }

    void display() {
        for (int i = 0; i < this.buckets.size(); i++) {
            Bucket bucket = this.buckets.get(i);
            System.out.print("Bucket " + i + ": ");
            if (!bucket.data.isEmpty()) {
                for (Object[] kv : bucket.data) {
                    System.out.print(Arrays.toString(kv) + ", ");
                }
            } else {
                System.out.print("Empty");
            }
            System.out.println();
        }
    }

    public static void main(String[] args) {
        MyHashTable hashTable = new MyHashTable();
        hashTable.put("clé", 5);
        hashTable.put(2, "date");
        hashTable.put(4, 55);
        hashTable.display();
        System.out.println(hashTable.get(2));
        ;
        hashTable.del("clé");
        hashTable.display();
    }
}
