namespace CSharp.Data_Structures.LinkedLists;


class DLLNode{
    public Object value;
    public DLLNode? prev;
    public DLLNode? next;

    public DLLNode(Object value){
        this.value = value;
        this.prev = this.next = null;
    }
}

public class DoublyLinkedList
{
    DLLNode head;
    DLLNode tail;
    int length;

    DoublyLinkedList()
    {
        this.head = this.tail = null;
        this.length = 0;
    }

    Object GetFirst()
    {
        if (this.head == null)
        {
            throw new InvalidOperationException();
        }

        return this.head.value;
    }

    Object GetLast()
    {
        if (this.head == null)
        {
            throw new InvalidOperationException();
        }

        return this.tail.value;
    }

    DLLNode Traverse(int index)
    {
        DLLNode currentNode;
        int position;
        if(this.length - index < index){
            currentNode = this.tail;
            position = this.length - 1;
            while(position != index){
                currentNode = currentNode.prev;
                position--;
            }
        }
        else {
            currentNode = this.head;
            position = 0;
            while (position != index) {
                currentNode = currentNode.next;
                position++;
            }
        }
        return currentNode;
    }
    
    Object Get(int index)
    {
        if (this.head == null) {
            throw new InvalidOperationException("List is empty");
        }
        if (index < 0 || index >= this.length) {
            throw new IndexOutOfRangeException("Index out of range");
        }
        DLLNode currentNode = Traverse(index);
        return currentNode.value;
    }
    
    void Append(Object value){
        DLLNode newNode = new DLLNode(value);
        if(this.head == null){
            this.head = this.tail = newNode;
        }
        else{
            DLLNode lastNode = this.tail;
            lastNode.next = newNode;
            newNode.prev = lastNode;
            this.tail = newNode;
        }
        this.length++;
    }
    
    void Prepend(Object value){
        DLLNode newNode = new DLLNode(value);
        if(this.head == null){
            this.head = this.tail = newNode;
        }
        else{
            DLLNode firstNode = this.head;
            firstNode.prev = newNode;
            newNode.next = firstNode;
            this.head = newNode;
        }
        this.length++;
    }
    
    void Insert(int index, Object value){
        if (this.head == null) {
            throw new InvalidOperationException("List is empty");
        }
        if (index < 0 || index > this.length) {
            throw new IndexOutOfRangeException("Index out of range");
        }
        if(index == 0){
            Prepend(value);
        }
        if(index == this.length) {
            Append(value);
        }
        else{
            DLLNode newNode = new DLLNode(value);
            DLLNode previousNode = Traverse(index - 1);
            DLLNode nextNode = previousNode.next;
            newNode.next = nextNode;
            newNode.prev = previousNode;
            previousNode.next = nextNode.prev = newNode;
            this.length++;
        }
    }
    
    void Remove(int index){
        if (this.head == null) {
            throw new InvalidOperationException("List is empty");
        }
        if (index < 0 || index >= this.length) {
            throw new IndexOutOfRangeException("Index out of range");
        }
        if(index == 0){
            this.head = this.head.next;
            this.head.prev = null;
            if(this.length == 1){
                this.tail = null;
            }
        }
        else{
            DLLNode previousNode = Traverse(index - 1);
            DLLNode currentNode = previousNode.next;
            DLLNode nextNode = currentNode.next;
            previousNode.next = nextNode;
            if (nextNode != null){
                nextNode.prev = previousNode;
            }
            else{
                this.tail = previousNode;
            }
        }
        this.length--;
    }
    
    void Display(){
        DLLNode currentNode = this.head!;
        while(currentNode != null){
            Console.Write(currentNode.value + " <-> ");
            currentNode = currentNode.next;
        }
        Console.Write("null");
        Console.WriteLine();
    }
    
    public static void Main(String[] args) {
        DoublyLinkedList myDoublyList = new DoublyLinkedList();
        myDoublyList.Display();
        myDoublyList.Append(1);
        myDoublyList.Append(9);
        myDoublyList.Append(5);
        myDoublyList.Prepend(4);
        myDoublyList.Insert(1, 50);
        Console.WriteLine(myDoublyList.Get(2));
        myDoublyList.Display();
        myDoublyList.Remove(4);
        myDoublyList.Display();
        Console.WriteLine(myDoublyList.GetFirst());
        Console.WriteLine(myDoublyList.GetLast());
    }
}