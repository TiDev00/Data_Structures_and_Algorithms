from PGCD import fast_pgcd

"""
Using GCD to calculate LCM
Constraint 1 <= a <= b <= 2.10^9
"""


def lcm(first_number, second_number):
    return (first_number * second_number)//(fast_pgcd(first_number, second_number))


if __name__ == '__main__':
    first_number, second_number = map(int, input().split(" "))
    print(lcm(first_number, second_number))
