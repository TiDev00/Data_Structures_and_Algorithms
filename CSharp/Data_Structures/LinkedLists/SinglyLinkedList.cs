namespace CSharp.Data_Structures.LinkedLists;

class SLLNode{
    public Object value;
    public SLLNode? next;

    public SLLNode(Object value){
        this.value = value;
        this.next = null;
    }
}

public class SinglyLinkedList
{
    SLLNode? head;
    SLLNode? tail;
    int length;
    
    SinglyLinkedList(){
        this.head = this.tail = null;
        this.length = 0;
    }

    Object GetFirst(){
        if (this.head == null)
        {
            throw new InvalidOperationException("List is empty.");
        }
        return this.head.value;
    }

    Object GetLast(){
        if (this.tail == null)
        {
            throw new InvalidOperationException("List is empty.");
        }
        return this.tail.value;
    }
    
    SLLNode Traverse(int index){
        int position = 0;
        SLLNode currentNode = this.head!;
        while(position != index){
            currentNode = currentNode.next!;
            position++;
        }
        return currentNode;
    }
    
    Object Get(int index) {
        if (index < 0 || index >= this.length)
        {
            throw new IndexOutOfRangeException("Index out of range");
        }
        SLLNode currentNode = Traverse(index);
        return currentNode.value;
    }

    void Append(Object value){
        SLLNode newNode = new SLLNode(value);
        if(this.head == null){
            this.head = this.tail = newNode;
        }
        else{
            this.tail!.next = newNode;
            this.tail = newNode;
        }
        this.length++;
    }

    void Prepend(Object value){
        SLLNode newNode = new SLLNode(value);
        if(this.head == null){
            this.head = this.tail = newNode;
        }
        else{
            newNode.next = this.head;
            this.head = newNode;
        }
        this.length++;
    }

    void Insert(int index, Object value){
        if (index < 0 || index > this.length){
            throw new IndexOutOfRangeException("Index out of Bounds");
        }
        if(this.head == null){
            throw new InvalidOperationException("List is empty");
        }
        if(index == 0){
            this.Prepend(value);
        }
        if(index == this.length){
            this.Append(value);
        }
        else
        {
            SLLNode newNode = new SLLNode(value);
            SLLNode previousNode = Traverse(index - 1);
            newNode.next = previousNode.next;
            previousNode.next = newNode;
            this.length++;
        }
    }

    void Remove(int index) {
        if (index < 0 || index >= this.length) {
            throw new IndexOutOfRangeException("Index out of bounds");
        }
        if (this.head == null) {
            throw new InvalidOperationException("List is empty");
        }
        if (index == 0) {
            this.head = this.head.next;
            if (this.length == 1) {
                this.tail = null;
            }
        } 
        else {
            SLLNode previousNode = Traverse(index - 1);
            SLLNode currentNode = previousNode.next;
            previousNode.next = currentNode.next;
            if (index == this.length - 1) {
                this.tail = previousNode;
            }
        }
        this.length--;
    }


    void Display(){
        SLLNode currentNode = this.head!;
        while(currentNode != null){
            Console.Write(currentNode.value + " -> ");
            currentNode = currentNode.next;
        }
        Console.Write("null");
        Console.WriteLine();
    }

    public static void main(String[] args) {
        SinglyLinkedList mySinglyList = new SinglyLinkedList();
        mySinglyList.Append(2);
        mySinglyList.Append(10);
        mySinglyList.Append(7);
        mySinglyList.Prepend(8);
        mySinglyList.Insert(2, 45);
        Console.WriteLine(mySinglyList.Get(2));
        mySinglyList.Display();
        mySinglyList.Remove(4);
        mySinglyList.Display();
        Console.WriteLine(mySinglyList.GetFirst());
        Console.WriteLine(mySinglyList.GetLast());
    }
}