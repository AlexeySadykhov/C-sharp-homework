from functools import reduce
import random

## Task 1

def number_to_pow(x, n):
    result = 1
    for i in range(n):
        result = result * x
    return result


## Вообще на питоне очень удобно вот так делается: x ** n
num = int(input("Task 1.\nEnter the number:"))
pw = int(input("Enter the pow:"))
print(number_to_pow(num, pw))

## Task 2
print(reduce(lambda a, x: a + x, map(int, input("Enter the number:"))))
## Ну вместо reduce можно конечно-же просто sum использовать. Это так, для красоты.

## Task 3

def create_array(size = 8, nums = ""):
    if not nums:
        return [random.randint(0, 100) for _ in range(size)]
    else:
        return list(map(int, nums.split()))


arr_size = input("Task 3.\nEnter the size of array or keep this field empty:")
numbers = input("If you already have numbers you want to convert, enter them or keep this field empty:")
if not arr_size:
    print(create_array(nums=numbers))
else:
    print(create_array(size=int(arr_size), nums=numbers))
