from collections import *
from array import *
from queue import *

entier = 1
reel = 1.0
chaine = "1"
chaine2 = "test mot2"
nombre = int(chaine)
vrai = True

# char and String methods
print(str.lower('A'))  # Convert 'A' to lowercase
print(str.upper('x'))  # Convert 'x' to uppercase
print(str.isdigit('w'))  # Check if 'w' is a digit
print(str.isalpha('2'))  # Check if '2' is a letter
print('q'.isupper())  # Check if 'q' is uppercase
print('W'.islower())  # Check if 'W' is lowercase

print(len(chaine2))  # Get the length of the string
print('u' in chaine2)  # Check if 'chaine2' contains "u"
print(chaine2.endswith("a"))  # Check if 'chaine2' ends with "a"
print(chaine2.startswith("b"))  # Check if 'chaine2' starts with "b"
print(chaine2[1:3])  # Get substring from index 1 to 2 (exclusive)
print(chaine2.upper())  # Convert 'chaine2' to uppercase
print(chaine2.lower())  # Convert 'chaine2' to lowercase
print(chaine2[3])  # Get character at index 3
print(chaine2.find('s'))  # Get index of 's' in 'chaine2'
print(chaine2.rfind('t'))  # Get last index of 't' in 'chaine2'
print(chaine2.replace('t', 'A'))  # Replace 't' with 'A' in 'chaine2'

mots = chaine2.split(" ")  # Split 'chaine2' by space into a list of strings
print(chaine2 == "")  # Check if 'chaine2' is empty
print(chaine2.isspace())  # Check if 'chaine2' contains only whitespace

mot = list(chaine2)  # Convert 'chaine2' to a list of characters

# LIST ou Array

maliste = [4, 1, 3, 6, 10, 9]

# methode speciales

print(len(maliste))  # Prints the length of the list

maliste.sort()  # Sorts the list in ascending order
print(maliste)

maliste.sort(reverse=True)  # Sorts the list in descending order
print(maliste)

maliste.append('lettre')  # Adds 'lettre' to the end of the list
print(maliste)

liste2 = maliste.copy()  # Creates a copy of maliste and assigns it to liste2
print(liste2)

liste2.remove(10)  # Removes the first occurrence of the value 10 from liste2
print(liste2)

print(liste2.pop())  # Removes and returns the last element from liste2
print(liste2)

liste2.pop(3)  # Removes the element at index 3 from liste2
print(liste2)

liste2.insert(0, 'orange')  # Inserts 'orange' at index 0 in liste2
print(liste2)

print(liste2.count('orange'))  # Counts the occurrences of 'orange' in liste2

print(liste2.index('orange'))  # Returns the index of the first occurrence of 'orange' in liste2

print("orange" in liste2)  # Checks if 'orange' is in liste2

# SET

monset = {1, "deux", False}

print(len(monset))  # Prints the length of the set `monset`

monset.add("chiffre")  # Adds the element "chiffre" to the set `monset`
print(monset)  # Prints the contents of the modified set `monset`

monset2 = monset.copy()  # Creates a copy of the set `monset` named `monset2`

print(monset.union({1, 5, 6}))  # Prints the union of `monset` and the set {1, 5, 6}
print(monset.intersection({1, 5, 6}))  # Prints the intersection of `monset` and the set {1, 5, 6}
print(monset.difference({1, 5, 6}))  # Prints the difference between `monset` and the set {1, 5, 6}

print(monset.issubset({1, 5, 6}))  # Checks if `monset` is a subset of the set {1, 5, 6} and prints True or False
print(monset.issuperset({1, 5, 6}))  # Checks if `monset` is a superset of the set {1, 5, 6} and prints True or False

monset.remove(1)  # Removes the element 1 from the set `monset`
print(monset.pop())  # Removes and returns an arbitrary element from `monset`, then prints it

print('orange' in monset)  # Checks if 'orange' is present in the set `monset` and prints True or False

# TUPLE

tuple1 = ('orange', True)
print(tuple1)
print(tuple1.count('orange'))
print(tuple1.index('orange'))

# DICTIONNARY

myDict = {'key1': 'value1', 'key2': 'value2', 'key3': 'value3'}

print(myDict)  # Prints the dictionary myDict: {'key1': 'value1', 'key2': 'value2', 'key3': 'value3'}

myDict['append1'] = 'value1'  # Adds a new key 'append1' with value 'value1' to myDict

print(myDict.keys())  # Prints the keys of myDict: dict_keys(['key1', 'key2', 'key3', 'append1'])

print(myDict.values())  # Prints the values of myDict: dict_values(['value1', 'value2', 'value3', 'value1'])

print(myDict.items())  # Prints the key-value pairs of myDict: dict_items([('key1', 'value1'), ('key2', 'value2')...])

print(myDict['key1'])  # Prints the value associated with 'key1': 'value1'

myDict.pop('key2')  # Removes the key 'key2' and its associated value from myDict

del myDict['key3']  # Deletes the key 'key3' and its associated value from myDict

myDict1 = myDict.copy()  # Creates a copy of myDict named myDict1

del myDict  # Deletes the entire dictionary myDict from memory

myDict1.popitem()  # From python 3.7 Removes and returns the last inserted key-value pair else select an arbitrary pair

myDict1.clear()  # Clear all data in dictionary


