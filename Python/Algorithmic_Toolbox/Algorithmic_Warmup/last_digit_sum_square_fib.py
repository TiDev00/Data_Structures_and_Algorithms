from fibo import fast_fib


# Returns the last digit of the sum of square f(n)
def last_digit_of_sum_of_square_fib(number):
    fib_list = fast_fib(number)
    fib_square = [x ** 2 for x in fib_list]
    return sum(fib_square) % 10
