class Bucket:
    def __init__(self):
        self.data = []


class MyHashTable:
    def __init__(self):
        self.capacity = 11
        self.buckets = [Bucket() for _ in range(self.capacity)]

    def hash_function(self, key):
        return abs(hash(key)) % self.capacity

    def get(self, key):
        hash_value = self.hash_function(key)
        bucket = self.buckets[hash_value]
        for tuple_pair in bucket.data:
            if tuple_pair[0] == key:
                return tuple_pair[1]
        return None

    def put(self, key, value):
        hash_value = self.hash_function(key)
        bucket = self.buckets[hash_value]
        key_found = False
        for tuple_pair in bucket.data:
            if tuple_pair[0] == key:
                tuple_pair[0] = value
                key_found = True
                break
        if not key_found:
            bucket.data.append((key, value))

    def deleting(self, key):
        hash_value = self.hash_function(key)
        bucket = self.buckets[hash_value]
        index = -1
        key_found = False
        for i, tuple_pair in enumerate(bucket.data):
            if tuple_pair[0] == key:
                index = i
                key_found = True
                break
        if key_found:
            del bucket.data[index]
        else:
            raise IndexError("Key not in dictionary")

    def __str__(self):
        output = []
        for i, bucket in enumerate(self.buckets):
            bucket_str = f"Bucket {i}: "
            if bucket.data:
                bucket_str += ", ".join(str(pair) for pair in bucket.data)
            else:
                bucket_str += "Empty"
            output.append(bucket_str)
        return "\n".join(output)


if __name__ == "__main__":
    hash_table = MyHashTable()
    hash_table.put("clé", 5)
    hash_table.put(2, "date")
    hash_table.put(4, 55)
    print(hash_table)
    print(hash_table.get(2))
    hash_table.deleting("clé")
    print(hash_table)
