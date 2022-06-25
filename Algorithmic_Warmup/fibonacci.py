import time


def naive_fibonacci(number):
    if number <= 1:
        return number
    else:
        return naive_fibonacci(number - 1) + naive_fibonacci(number - 2)


def fast_fibonacci(number):
    if number <= 1:
        return number
    else:
        fibonacci_list = [0, 1]
        for digit in range(number-1):
            fibonacci_list.append(fibonacci_list[-2] + fibonacci_list[-1])
        return fibonacci_list[-1]


if __name__ == '__main__':
    searched_fib = int(input("Give the number: "))
    start1 = time.time()
    print(naive_fibonacci(searched_fib))
    end1 = time.time()
    print("Naive Time: ", end1-start1)
    start2 = time.time()
    print(fast_fibonacci(searched_fib))
    end2 = time.time()
    print("Fast time: ", end2-start2)
    print("difference: ", (end1-start1)-(end2-start2))
