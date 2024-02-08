def reversing(word: str) -> str:
    reversed_word = ""
    ptr = len(word) - 1
    while ptr >= 0:
        reversed_word += word[ptr]
        ptr -= 1
    return reversed_word


def merging(tab1: list, tab2: list) -> list:
    if len(tab1) == 0:
        return tab2

    if len(tab2) == 0:
        return tab1

    merged_tab = []

    while len(tab1) != 0 and len(tab2) != 0:
        if tab1[0] < tab2[0]:
            merged_tab.append(tab1.pop(0))
        else:
            merged_tab.append(tab2.pop(0))

    while len(tab1) != 0:
        merged_tab.append(tab1.pop(0))

    while len(tab2) != 0:
        merged_tab.append(tab2.pop(0))

    return merged_tab


if __name__ == "__main__":
    print(reversing("1234"))
    print(merging([1, 2, 3], [2, 4, 4, 15, 17]))
