namespace CSharp.Data_Structures.Arrays;

public class MyArray
{
    private int capacity;
    private int length;
    private object[] data;
    

    public MyArray()
    {
        capacity = 1;
        length = 0;
        data = new object[capacity];
    }
    
    // Display elements of the object
    public static void Display(MyArray tab)
    {
        Console.WriteLine("array content : ");
        foreach (object elt in tab.data)
        {
            Console.WriteLine(elt);
        }
    }
    
    // Return length of the array
    public int GetLength()
    {
        return this.length;
    }
    
    // Return element at specified index
    public Object GetValue(int index)
    {
        if (index >= 0 && index < this.length)
        {
            return this.data[index];
        }
        throw new IndexOutOfRangeException("Index out of range");
    }
    
    // Add element at the end of the array
    public void Push(object value)
    {
        if (this.capacity == this.length)
        {
            this.capacity *= 2;
            object[] temp = new object[this.length];
            Array.Copy(this.data, temp, this.length);
            this.data = new object[this.capacity];
            Array.Copy(temp, this.data, this.length);
        }
        this.data[this.length] = value;
        this.length++; 
    }
    
    // Remove and return last element of the array
    public object Pop()
    {
        if (this.length > 0)
        {
            object item = this.data[this.length - 1];
            this.data[this.length - 1] = null;
            this.length--;
            return item;
        }

        throw new Exception("Array is empty");
    }
    
    // Shift index of object to left
    public void Shift(object[] objectDict, int size, int number)
    {
        for (int i = number; i < size - 1; i++) {
            objectDict[i] = objectDict[i + 1];
        }
    }
    
    // Delete element at specified index
    public void Delete(int index)
    {
        if (index >= 0 && index < this.length)
        {
            Shift(this.data, this.length, index);
            this.data[this.length - 1] = null;
            length--;
        }
        else
        {
            throw new IndexOutOfRangeException("Index out of range");
        }
    }
    
    void Main(string[] args)
    {
        MyArray arr = new MyArray();
        arr.Push(45);
        arr.Push(10);
        arr.Push(50);
        arr.Push(100);
        arr.Push(27);
        Console.WriteLine("size of array: " + arr.GetLength());
        Console.WriteLine("get elt at 1: " + arr.GetValue(2));
        Display(arr);
        Console.WriteLine("removed last elt (27) and returned it: " + arr.Pop());
        Display(arr);
        arr.Delete(1);
        Display(arr);
    }
}