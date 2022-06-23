import time


def max_product(elements):
    max_nb1 = max(elements)
    max_nb2 = 0
    for element in elements:
        if max_nb1 > element > max_nb2:
            max_nb2 = element
    return max_nb1 * max_nb2


if __name__ == '__main__':
    input_n = int(input())
    enter = (input().split(" "))
    num_list = [int(number) for number in enter]
    print(max_product(num_list))

