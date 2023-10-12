"""
Naive algorithm to calculate the fibonacci of a given number.
Don't work with a large number and takes a huge amount of time.
"""


def naive_fib(number):
    if number <= 1:
        return number
    else:
        return naive_fib(number - 1) + naive_fib(number - 2)


"""
Fastest version to calculate the fibonacci of a given number.
Work with large numbers. Return the list of calculated fibonnaci.
Use list[-1] to return the last f(n) calculated
"""


def fast_fib(number):
    if number <= 1:
        return number
    else:
        fib_list = [0, 1]
        for _ in range(number - 1):
            fib_list.append(fib_list[-2] + fib_list[-1])
        return fib_list[-1]


# Returns the last digit of the last f(n)


def last_digit_of_fib(number):
    if number <= 1:
        return number
    else:
        fib_list = [0, 1]
        for _ in range(number - 1):
            fibo_number = (fib_list[-2] + fib_list[-1])
            fib_list.append(fibo_number)
        return fib_list[-1] % 10


# Returns the last digit of the sum of f(n)

def last_digit_of_sum_of_fib(number):
    if number <= 1:
        return number
    else:
        fib_list = [0, 1]
        fib_sum = 0
        for digit in range(number - 1):
            fib_list.append(fib_list[-2] + fib_list[-1])
            fib_sum += number
        return fib_sum % 10


# Find the last digit of a partial sum of Fibonacci numbers

# Returns the last digit of the sum of square f(n)

def last_digit_of_sum_of_square_fib(number):
    fib_list = fast_fib(number)
    fib_square = [x ** 2 for x in fib_list]
    return sum(fib_square) % 10


if __name__ == '__main__':
    print(last_digit_of_fib(331))
