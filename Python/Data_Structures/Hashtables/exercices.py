def first_recurring_character(tab: list) -> int:
    my_map = {}
    for index, value in enumerate(tab):
        if value in my_map.keys():
            return value
        my_map[value] = index
    return -1


if __name__ == '__main__':
    print(first_recurring_character([1, 2, 3]))
