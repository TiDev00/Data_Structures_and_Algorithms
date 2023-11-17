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


if __name__ == '__main__':
    print(last_digit_of_sum_of_fib(331))
