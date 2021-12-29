print("\t**********************************************")
print("\t\t\t\t***  SUM OF 2 DIGITS  ***")
print("\t**********************************************")

answer = (input("What are the 2 numbers: ").split(" "))
num_list = [int(number) for number in answer]
if len(num_list) < 2:
    print("You gave one number")
else:
    print("The sum of " + str(num_list[0]) + " and " + str(num_list[1]) + " is", num_list[0] + num_list[1])

