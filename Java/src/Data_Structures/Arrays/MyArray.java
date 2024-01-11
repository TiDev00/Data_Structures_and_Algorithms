package Data_Structures.Arrays;

import java.util.*;

public class MyArray {
    private int capacity;
    private int length;
    private Object[] data;


    public MyArray()
    {
        capacity = 1;
        length = 0;
        data = new Object[capacity];
    }

    // Display elements of the object
    public static void Display(MyArray tab)
    {
        System.out.println("array content : ");
        for(Object elt : tab.data)
        {
            System.out.println(elt);
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
        throw new IndexOutOfBoundsException("Index out of range");
    }

    // Add element at the end of the array
    public void Push(Object value)
    {
        if (this.capacity == this.length)
        {
            this.capacity += 1;
            this.data = Arrays.copyOf(this.data, capacity);
        }
        this.data[this.length] = value;
        this.length++;
    }

    // Remove and return last element of the array
    public Object Pop() throws Exception {
        if (this.length > 0)
        {
            Object item = this.data[this.length - 1];
            this.data[this.length - 1] = null;
            this.length--;
            return item;
        }

        throw new Exception("Array is empty");
    }

    // Shift index of object to left
    public void Shift(Object[] objectDict, int size, int number)
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
            throw new IndexOutOfBoundsException("Index out of range");
        }
    }

    public static void main(String[] args) throws Exception {
        MyArray arr = new MyArray();
        arr.Push(45);
        arr.Push(10);
        arr.Push(50);
        arr.Push(100);
        arr.Push(27);
        System.out.println("size of array: " + arr.GetLength());
        System.out.println("get elt at 1: " + arr.GetValue(1));
        Display(arr);
        System.out.println("removed last elt (27) and returned it: " + arr.Pop());
        Display(arr);
        arr.Delete(2);
        Display(arr);
    }
}
