import time


def naive_pgcd(first_number, second_number):
    pgcd = 1
    for digit in range(2, min(first_number, second_number) + 1):
        if first_number % digit == 0 and second_number % digit == 0:
            pgcd = max(pgcd, digit)
    return pgcd


# Constraint 1 <= a <= b <= 2.10^9
def fast_pgcd(first_number, second_number):
    if second_number == 0:
        return first_number
    else:
        return fast_pgcd(second_number, first_number % second_number)


if __name__ == '__main__':
    list_numbers = input("Give the 2 numbers: ").split(" ")
    start1 = time.time()
    print(naive_pgcd(int(list_numbers[0]), int(list_numbers[1])))
    end1 = time.time()
    print("Naive Time: ", end1 - start1)
    start2 = time.time()
    print(fast_pgcd(int(list_numbers[0]), int(list_numbers[1])))
    end2 = time.time()
    print("Fast time: ", end2 - start2)
    print("difference: ", (end2 - start2) - (end1 - start1))
