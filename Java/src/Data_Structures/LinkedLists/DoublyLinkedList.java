package Data_Structures.LinkedLists;

class DLLNode{
    Object value;
    DLLNode prev;
    DLLNode next;

    public DLLNode(Object value){
        this.value = value;
        this.prev = this.next = null;
    }
}
public class DoublyLinkedList {
    DLLNode head;
    DLLNode tail;
    int length;

    DoublyLinkedList(){
        this.head = this.tail = null;
        this.length = 0;
    }

    Object getFirst(){
        if(this.head == null){
            throw new UnsupportedOperationException("List is empty");
        }
        return this.head.value;
    }

    Object getLast(){
        if(this.head == null){
            throw new UnsupportedOperationException("List is empty");
        }
        return this.tail.value;
    }

    DLLNode traverse(int index){
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

    Object get(int index){
        if (this.head == null) {
            throw new UnsupportedOperationException("List is empty");
        }
        if (index < 0 || index >= this.length) {
            throw new IndexOutOfBoundsException("Index out of range");
        }
        DLLNode currentNode = traverse(index);
        return currentNode.value;
    }

    void append(Object value){
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

    void prepend(Object value){
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

    void insert(int index, Object value){
        if (this.head == null) {
            throw new UnsupportedOperationException("List is empty");
        }
        if (index < 0 || index > this.length) {
            throw new IndexOutOfBoundsException("Index out of range");
        }
        if(index == 0){
            prepend(value);
        }
        if(index == this.length) {
            append(value);
        }
        else {
            DLLNode newNode = new DLLNode(value);
            DLLNode previousNode = traverse(index - 1);
            DLLNode nextNode = previousNode.next;
            newNode.next = nextNode;
            newNode.prev = previousNode;
            previousNode.next = nextNode.prev = newNode;
            this.length++;
        }
    }

    void remove(int index){
        if (this.head == null) {
            throw new UnsupportedOperationException("List is empty");
        }
        if (index < 0 || index >= this.length) {
            throw new IndexOutOfBoundsException("Index out of range");
        }
        if(index == 0){
            this.head = this.head.next;
            this.head.prev = null;
            if(this.length == 1){
                this.tail = null;
            }
        }
        else{
            DLLNode previousNode = traverse(index - 1);
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

    void display() {
        DLLNode currentNode = this.head;
        while (currentNode != null) {
            System.out.print(currentNode.value + " <-> ");
            currentNode = currentNode.next;
        }
        System.out.print("null");
        System.out.println();
    }

    public static void main(String[] args) {
        DoublyLinkedList myDoublyList = new DoublyLinkedList();
        myDoublyList.display();
        myDoublyList.append(1);
        myDoublyList.append(9);
        myDoublyList.append(5);
        myDoublyList.prepend(4);
        myDoublyList.insert(1, 50);
        System.out.println(myDoublyList.get(2));
        myDoublyList.display();
        myDoublyList.remove(4);
        myDoublyList.display();
        System.out.println(myDoublyList.getFirst());
        System.out.println(myDoublyList.getLast());
    }
}
