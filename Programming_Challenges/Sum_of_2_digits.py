def digits_sum(a, b):
    return a + b


if __name__ == '__main__':
    answer = (input().split(" "))
    num_list = [int(number) for number in answer]
    print(digits_sum(num_list[0], num_list[1]))