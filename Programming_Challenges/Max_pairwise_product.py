def max_product(nb_element, elements):
    product = 0
    for first_index in range(nb_element):
        for second_index in range(first_index + 1, nb_element):
            product = max(product, elements[first_index] * elements[second_index])
    return product


if __name__ == '__main__':
    input_n = int(input())
    enter = (input().split(" "))
    num_list = [int(number) for number in enter]
    print(max_product(input_n, num_list))

