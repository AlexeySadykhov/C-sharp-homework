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
print([random.randint(0, 100) for _ in range(int(input("Enter the size of array:")))])
