def digits_sum(a, b):
    return a + b


if __name__ == '__main__':
    answer = (input("Give 2 numbers: ").split(" "))
    print(digits_sum(int(answer[0]), int(answer[1])))
