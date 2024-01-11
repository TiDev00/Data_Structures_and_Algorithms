class MyArray:
    def __init__(self):
        self.length = 0
        self.data = {}

    # __dundr__ to print the data instead of the object when using built-in print method
    def __str__(self):
        return str(self.data)

    # Return length of the array
    def get_length(self):
        return self.length

    # Return element at specified index
    def get_value(self, index):
        if index >= 0 or index < self.length:
            return self.data[index]
        else:
            raise IndexError("Index out of range")

    # Add element at the end of the array
    def push(self, value):
        self.data[self.length] = value
        self.length += 1

    # Remove and return last element of the array
    def pop(self):
        if self.data:
            item = self.data[self.length-1]
            del self.data[self.length-1]
            self.length -= 1
            return item
        else:
            raise IndexError("Array is empty")

    # Shift index of object to left
    @staticmethod
    def shifting(object_dict, size, number):
        for i in range(number, size-1):
            object_dict[i] = object_dict[i+1]

    # Delete element at specified index
    def delete(self, index):
        if index >= 0 or index < self.length:
            self.shifting(self.data, self.length, index)
            del self.data[self.length - 1]
            self.length -= 1
        else:
            raise IndexError("Index out of range")


arr = MyArray()
arr.push(45)
arr.push(10)
arr.push(50)
arr.push(100)
arr.push(27)
print("size of array: ", arr.get_length())
print("get elt at 1: ", arr.get_value(1))
print("print array: ", arr)
print("removed last elt (27) and returned it: ", arr.pop())
print("print array: ", arr)
arr.delete(2)
print("final array: ", arr)
