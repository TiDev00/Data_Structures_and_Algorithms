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


if __name__ == '__main__':
    print(last_digit_of_fib(331))
