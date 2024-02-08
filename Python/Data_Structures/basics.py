# Character and String Operations
carac = 'a'
test = True
chaine = "12345"
chaine2 = "test mot2"
numb = 1
conv2 = int(chaine)
numb3 = float(numb)
grand = 5
numb1 = "1"
conv = float(numb1)
virgule = 1.0
virgule_big = 244.5

# Character methods in Python
print('A'.lower())  # Converts 'A' to lowercase and prints 'a'
print('x'.upper())  # Converts 'x' to uppercase and prints 'X'
print('w'.isdigit())  # Checks if 'w' is a digit (prints False)
print('2'.isalpha())  # Checks if '2' is a letter (prints False)
print('q'.isupper())  # Checks if 'q' is uppercase (prints False)
print('W'.islower())  # Checks if 'W' is lowercase (prints False)

# String operations
print(chaine2[3])  # Retrieves the character at index 3 in 'chaine2'
print(len(chaine2))  # Prints the length of the string 'chaine2'
print(chaine2.upper())  # Converts 'chaine2' to uppercase
print(chaine2.lower())  # Converts 'chaine2' to lowercase

# Splitting strings
mots = chaine2.split()  # Splits 'chaine2' into a list of strings using space as the delimiter
mot = list(chaine2)  # Converts 'chaine2' to a list of characters

# LINEAR DATA STRUCTURES
nbTab = list(range(15, 21))
tab3 = nbTab[:2]

arrlist0 = [1, 2, 3]
arrlist = nbTab.copy()
arrlist.append(1)
arrlist.append(5)
t0 = len(arrlist)
arrlist.remove(5)   # remove first occurence of value 5
arrlist.pop()   # remove elt at index (last index default)
arrlist.pop(0)  # remove first elt
c0 = 2 in arrlist
r0 = arrlist[2]
arrlist[0] = 10
print(len(arrlist) == 0)
print(arrlist)

# Using lists as stacks and queues
st = []
st.append('a')
st.append('b')
st.append('c')
print(st[-1])
print('a' in st)
print(st.pop())
print(len(st) == 0)
print(st)
st.clear()

q = []
q.append(1)
q.append(2)
q.append(3)
print(q[0])
print(q.pop(0))
print(1 in q)
print(len(q) == 0)
print(q)

# NON LINEAR DATA STRUCTURES

# Dictionaries in Python
m0 = {1: "v1", 2: "v2", 3: "v3"}
m = m0.copy()
m[50] = "v50"
m[75] = "Nothing"
t3 = len(m)
del m[3]
ck = 2 in m
cv = "George" in m.values()
val = m.get(50)
print(m)

for key in m:
    k = key

for value in m.values():
    v = value

for key, value in m.items():
    keys = key
    values = value
m.clear()
