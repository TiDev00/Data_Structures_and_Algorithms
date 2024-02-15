package Data_Structures.LinkedLists;

class SLLNode {
    Object value;
    SLLNode next;

    SLLNode(Object value) {
        this.value = value;
        this.next = null;
    }
}

class SinglyLinkedList {
    SLLNode head;
    SLLNode tail;
    int length;

    SinglyLinkedList() {
        this.head = this.tail = null;
        this.length = 0;
    }

    Object getFirst() {
        if (this.head == null) {
            throw new UnsupportedOperationException("List is empty");
        }
        return this.head.value;
    }

    Object getLast() {
        if (this.head == null) {
            throw new UnsupportedOperationException("List is empty");
        }
        return this.tail.value;
    }

    SLLNode traverse(int index) {
        int position = 0;
        SLLNode currentNode = this.head;
        while (position != index) {
            currentNode = currentNode.next;
            position++;
        }
        return currentNode;
    }

    Object get(int index) {
        if (index < 0 || index >= this.length) {
            throw new IndexOutOfBoundsException("Index out of range");
        }
        SLLNode currentNode = traverse(index);
        return currentNode.value;
    }

    void append(Object value) {
        SLLNode newNode = new SLLNode(value);
        if (this.head == null) {
            this.head = this.tail = newNode;
        }
        else {
            this.tail.next = newNode;
            this.tail = newNode;
        }
        this.length++;
    }

    void prepend(Object value) {
        SLLNode newNode = new SLLNode(value);
        if (this.head == null) {
            this.head = this.tail = newNode;
        }
        else {
            newNode.next = this.head;
            this.head = newNode;
        }
        this.length++;
    }

    void insert(int index, Object value) {
        if (index < 0 || index > this.length) {
            throw new IndexOutOfBoundsException("Index out of Bounds");
        }
        if (index == 0) {
            this.prepend(value);
        }
        if (index == this.length) {
            this.append(value);
        }
        else {
            SLLNode newNode = new SLLNode(value);
            SLLNode previousNode = traverse(index - 1);
            newNode.next = previousNode.next;
            previousNode.next = newNode;
            this.length++;
        }
    }

    void remove(int index) {
        if (index < 0 || index >= this.length) {
            throw new IndexOutOfBoundsException("Index out of bounds");
        }
        if (this.head == null) {
            throw new UnsupportedOperationException("List is empty");
        }
        if (index == 0) {
            this.head = this.head.next;
            if (this.length == 1) {
                this.tail = null;
            }
        }
        else {
            SLLNode previousNode = traverse(index - 1);
            SLLNode currentNode = previousNode.next;
            previousNode.next = currentNode.next;
            if (index == this.length - 1) {
                this.tail = previousNode;
            }
        }
        this.length--;
    }


    void display() {
        SLLNode currentNode = this.head;
        while (currentNode != null) {
            System.out.print(currentNode.value + " -> ");
            currentNode = currentNode.next;
        }
        System.out.print("null");
        System.out.println();
    }

    public static void main(String[] args) {
        SinglyLinkedList mySinglyList = new SinglyLinkedList();
        mySinglyList.append(2);
        mySinglyList.append(10);
        mySinglyList.append(7);
        mySinglyList.prepend(8);
        mySinglyList.insert(2, 45);
        System.out.println(mySinglyList.get(2));
        mySinglyList.display();
        mySinglyList.remove(4);
        mySinglyList.display();
        System.out.println(mySinglyList.getFirst());
        System.out.println(mySinglyList.getLast());
    }
}
