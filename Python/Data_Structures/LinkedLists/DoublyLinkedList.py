class DLLNode:
    def __init__(self, value):
        self.value = value
        self.prev = self.next = None


class MyDoublyLinkedList:
    def __init__(self):
        self.head = self.tail = None
        self.length = 0

    def get_first(self):
        if self.head is None:
            raise Exception("List is empty")
        return self.head.value

    def get_last(self):
        if self.head is None:
            raise Exception("List is empty")
        return self.tail.value

    def traverse(self, index):
        if self.length - index < index:
            current_node = self.tail
            position = self.length - 1
            while position != index:
                current_node = current_node.prev
                position -= 1
        else:
            current_node = self.head
            position = 0
            while position != index:
                current_node = current_node.next
                position += 1
        return current_node

    def get(self, index):
        if index < 0 or index >= self.length:
            raise IndexError("Index out of range")
        if self.head is None:
            raise Exception("List is empty")
        return self.traverse(index).value

    def append(self, value):
        new_node = DLLNode(value)
        if self.head is None:
            self.head = self.tail = new_node
        else:
            self.tail.next = new_node
            new_node.prev = self.tail
            self.tail = new_node
        self.length += 1

    def prepend(self, value):
        new_node = DLLNode(value)
        if self.head is None:
            self.head = self.tail = new_node
        else:
            self.head.prev = new_node
            new_node.next = self.head
            self.head = new_node
        self.length += 1

    def insert(self, index, value):
        if self.head is None:
            raise Exception("List is empty")
        if index < 0 or index > self.length:
            raise IndexError("Index out of range")
        if index == 0:
            self.prepend(value)
        if index == self.length:
            self.append(value)
        else:
            new_node = DLLNode(value)
            previous_node = self.traverse(index - 1)
            next_node = previous_node.next
            new_node.next = next_node
            new_node.prev = previous_node
            previous_node.next = next_node.prev = new_node
            self.length += 1

    def remove(self, index):
        if self.head is None:
            raise Exception("List is empty")
        if index < 0 or index >= self.length:
            raise IndexError("Index out of range")
        if index == 0:
            self.head = self.head.next
            if self.head is not None:
                self.head.prev = None
            if self.length == 1:
                self.tail = None
        else:
            previous_node = self.traverse(index - 1)
            current_node = previous_node.next
            next_node = current_node.next
            previous_node.next = next_node
            if next_node is not None:
                next_node.prev = previous_node
            else:
                self.tail = previous_node
        self.length -= 1

    def display(self):
        current_node = self.head
        output = ''
        while current_node is not None:
            output += f'{current_node.value} <-> '
            current_node = current_node.next
        output += 'null'
        print(output)


if __name__ == '__main__':
    myDoublyList = MyDoublyLinkedList()
    myDoublyList.display()
    myDoublyList.append(3)
    myDoublyList.append(7)
    myDoublyList.append(4)
    myDoublyList.prepend(5)
    myDoublyList.insert(1, 45)
    myDoublyList.display()
    myDoublyList.remove(4)
    myDoublyList.display()
    print(myDoublyList.get_first())
    print(myDoublyList.get_last())

