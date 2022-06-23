def max_product(elements):
    first_max = max(elements)
    elements.remove(first_max)
    second_max = max(elements)
    return first_max * second_max


if __name__ == '__main__':
    input_n = int(input())
    enter = (input().split(" "))
    num_list = [int(number) for number in enter]
    print(max_product(num_list))

