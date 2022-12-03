import sys

## tasks 1-2


def find_max(lst):
    max_el = lst[0]
    for item in lst:
        if item > max_el:
            max_el = item
    return max_el


numbers = list(map(int, input("Task 1\nEnter numbers splitting values by space:").split()))
print(f"max = {find_max(numbers)}")

## task 3


def is_even(n):
    if n % 2 == 0:
        return True
    else:
        return False


num = int(input("Task 2\nEnter the number:"))
print("Task 2\nIs number %d even? %s" % (num, is_even(num)))

## task 4


def even_range(x):
    if x <= 1:
        print("Error. Number must be higher than 1.")
        sys.exit(1)
    else:
        return [i for i in range(1, x + 1) if i % 2 == 0]


numb = int(input("Task 3\nEnter the number:"))
print(" ".join(str(x) for x in even_range(numb)))
