namespace CSharp.Data_Structures.Arrays;

public class MyArray
{
    int capacity;
    int length;
    object[] data;

    public MyArray()
    {
        capacity = 1;
        length = 0;
        data = new object[capacity];
    }

    // Display elements of the object
    void Display()
    {
        Console.WriteLine("Array content:");
        for (int i = 0; i < length; i++)
        {
            Console.WriteLine(data[i]);
        }
    }

    // Return length of the array
    int GetLength()
    {
        return length;
    }

    // Return element at specified index
    object GetValue(int index)
    {
        if (index >= 0 && index < length)
        {
            return data[index];
        }
        throw new IndexOutOfRangeException("Index out of range");
    }

    // Add element at the end of the array
    void Push(object value)
    {
        if (capacity == length)
        {
            capacity *= 2;
            object[] newData = new object[capacity];
            Array.Copy(data, newData, length);
            data = newData;
        }
        data[length] = value;
        length++;
    }

    // Remove and return last element of the array
    object Pop()
    {
        if (length > 0)
        {
            object item = data[length - 1];
            object[] newData = new object[--length];
            Array.Copy(data, newData, length);
            data = newData;
            return item;
        }

        throw new InvalidOperationException("Array is empty");
    }

    // Shift index of object to the left
    void Shift(int index)
    {
        for (int i = index; i < length - 1; i++)
        {
            data[i] = data[i + 1];
        }
    }

    // Delete element at specified index
    void Delete(int index)
    {
        if (index >= 0 && index < length)
        {
            Shift(index);
            object[] newData = new object[--length];
            Array.Copy(data, newData, length);
            data = newData;
        }
        else
        {
            throw new IndexOutOfRangeException("Index out of range");
        }
    }

    public static void main(string[] args)
    {
        MyArray arr = new MyArray();
        arr.Push(45);
        arr.Push(10);
        arr.Push(50);
        arr.Push(100);
        arr.Push(27);
        Console.WriteLine("Size of array: " + arr.GetLength());
        Console.WriteLine("Get element at index 2: " + arr.GetValue(2));
        arr.Display();
        Console.WriteLine("Removed last element (27) and returned it: " + arr.Pop());
        arr.Display();
        arr.Delete(1); // Deletes the element at index 1
        arr.Display();
    }
}