import random
from functools import reduce


def rand_nums(mn, mx, mode, size = 8):
    array = []
    if mode == "int":
        array = [random.randint(mn, mx) for _ in range(size)]
    if mode == "float":
        array = [random.uniform(mn, mx) for _ in range(size)]
    return array
    

## Task 1


def even_nums_cnt(arr):
    cnt = 0
    for item in arr:
        if item % 2 == 0:
            cnt += 1
    return cnt


numbers = rand_nums(mn=100, mx=999, mode="int")
print("Task 1\n", numbers)
print(even_nums_cnt(numbers))
## Альтернативное решение:
print(len([x for x in numbers if x % 2 == 0]))
## Или даже так:
print(len(list(filter(lambda x: x % 2 == 0, numbers))))

## Task 2
nums = rand_nums(mn=-50, mx=50, mode="int")
print("Task 2\n", nums)
print(reduce(lambda a, x: a + x, [nums[i] for i in range(1, len(nums), 2)]))

## Task 3


def find_min_max_diff(array):
    mn = array[0]
    mx = array[0]
    for item in array:
        if item < mn:
            mn = item
        if item > mx:
            mx = item
    return mx - mn


arr = rand_nums(mn=-10, mx=10, mode="float")
print("Task 3\n", arr)
print(find_min_max_diff(arr))
