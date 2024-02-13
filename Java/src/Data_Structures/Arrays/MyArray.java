package Data_Structures.Arrays;

import java.util.*;

public class MyArray {
    int capacity;
    int length;
    Object[] data;


    public MyArray() {
        capacity = 1;
        length = 0;
        data = new Object[capacity];
    }

    // Display elements of the object
    void display()
    {
        System.out.println(Arrays.toString(this.data));
    }

    // Return length of the array
    int getLength()
    {
        return this.length;
    }

    // Return element at specified index
    Object getValue(int index) {
        if (index >= 0 && index < this.length)
        {
            return this.data[index];
        }
        throw new IndexOutOfBoundsException("Index out of range");
    }

    // Add element at the end of the array
    void push(Object value) {
        if (this.capacity == this.length)
        {
            this.capacity *= 2;
            this.data = Arrays.copyOf(this.data, capacity);
        }
        this.data[this.length] = value;
        this.length++;
    }

    // Remove and return last element of the array
    Object pop() {
        if (this.length > 0)
        {
            Object item = this.data[this.length - 1];
            this.data = Arrays.copyOf(this.data, this.length - 1);
            this.length--;
            this.capacity = this.length;
            return item;
        }

        throw new UnsupportedOperationException("Array is empty");
    }

    // Shift index of object to left
    void shift(Object[] objectDict, int size, int number) {
        for (int i = number; i < size - 1; i++) {
            objectDict[i] = objectDict[i + 1];
        }
    }

    // Delete element at specified index
    void delete(int index) {
        if (index >= 0 && index < this.length) {
            shift(this.data, this.length, index);
            this.data = Arrays.copyOf(this.data, this.length - 1);
            this.length--;
            this.capacity = this.length;
        } else {
            throw new IndexOutOfBoundsException("Index out of range");
        }
    }

    public static void main(String[] args) {
        MyArray arr = new MyArray();
        arr.push(45);
        arr.push(10);
        arr.push(50);
        arr.push(100);
        arr.push(27);
        System.out.println("size of array: " + arr.getLength());
        System.out.println("get elt at 1: " + arr.getValue(1));
        arr.display();
        System.out.println("removed last elt (27) and returned it: " + arr.pop());
        arr.display();
        arr.delete(2);
        arr.display();
    }
}
