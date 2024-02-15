class SLLNode:
    def __init__(self, value):
        self.value = value
        self.next = None


class SinglyLinkedList:
    def __init__(self):
        self.head = self.tail = None
        self.length = 0

    def get_first(self):
        if not self.head:
            raise Exception("List is empty")
        return self.head.value

    def get_last(self):
        if not self.head:
            raise Exception("List is empty")
        return self.tail.value

    def traverse(self, index):
        position = 0
        current_node = self.head
        while position != index:
            current_node = current_node.next
            position += 1
        return current_node

    def get(self, index):
        if index < 0 or index >= self.length:
            raise IndexError("Index out of range")
        current_node = self.traverse(index)
        return current_node.value

    def append(self, value):
        new_node = SLLNode(value)
        if not self.head:
            self.head = self.tail = new_node
        else:
            last_node = self.tail
            last_node.next = new_node
            self.tail = new_node
        self.length += 1

    def prepend(self, value):
        new_node = SLLNode(value)
        if not self.head:
            self.head = self.tail = new_node
        else:
            first_node = self.head
            new_node.next = first_node
            self.head = new_node
        self.length += 1

    def insert(self, index, value):
        if index < 0 or index > self.length or self.head is None:
            raise IndexError("Index is our of range")
        if index == 0:
            self.prepend(value)
            return
        if index == self.length:
            self.append(value)
            return
        new_node = SLLNode(value)
        previous_node = self.traverse(index - 1)
        new_node.next = previous_node.next
        previous_node.next = new_node
        self.length += 1

    def remove(self, index):
        if index < 0 or index >= self.length:
            raise IndexError("Index is out of range")
        if self.head is None:
            raise Exception("List is empty")
        if index == 0:
            self.head = self.head.next
            if self.length == 1:
                self.tail = None
        else:
            previous_node = self.traverse(index - 1)
            current_node = previous_node.next
            previous_node.next = current_node.next
            if index == self.length - 1:
                self.tail = previous_node
        self.length -= 1

    def display(self):
        current_node = self.head
        output = ''
        while current_node is not None:
            output += f'{current_node.value} -> '
            current_node = current_node.next
        output += 'null'
        print(output)


if __name__ == '__main__':
    mySinglyList = SinglyLinkedList()
    mySinglyList.display()
    mySinglyList.append(2)
    mySinglyList.append(10)
    mySinglyList.append(7)
    mySinglyList.prepend(8)
    mySinglyList.insert(2, 45)
    mySinglyList.display()
    mySinglyList.remove(4)
    mySinglyList.display()
    print(mySinglyList.get_first())
    print(mySinglyList.get_last())
