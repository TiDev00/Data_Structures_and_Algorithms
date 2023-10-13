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


if __name__ == '__main__':
    print(fast_fib(331))
