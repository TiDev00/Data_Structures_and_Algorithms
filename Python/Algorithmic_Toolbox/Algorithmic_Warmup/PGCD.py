"""
Naive algorithm to calculate greatest common divisor of 2 given numbers.
Don't work with a large number and takes a huge amount of time.
Constraint 1 <= a <= b <= 2.10^9
"""


def naive_pgcd(first_number, second_number):
    pgcd = 1
    for digit in range(2, min(first_number, second_number) + 1):
        if first_number % digit == 0 and second_number % digit == 0:
            pgcd = max(pgcd, digit)
    return pgcd


# Fastest algorithm
def fast_pgcd(first_number, second_number):
    if second_number == 0:
        return first_number
    else:
        return fast_pgcd(second_number, first_number % second_number)


if __name__ == '__main__':
    first_number, second_number = map(int, input().split(" "))
    print(fast_pgcd(first_number, second_number))
