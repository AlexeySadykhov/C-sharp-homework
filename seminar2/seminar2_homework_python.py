## Tasks 1-2

def find_digit(n, d):
    n = abs(n)
    remain = []
    while n > 0:
        remain.append(n % 10)
        n //= 10
    if len(remain) < d:
        return -1
    else:
        return remain[-d]


number = int(input("Tasks 1-2.\nEnter the number:"))
digit = int(input("Enter the digit you want to find:"))
result = find_digit(number, digit)
if result < 0:
    print(f"Number has no {digit} digit.")
else:
    print(result)

## Task 3

def is_weekday(n):
    if 6 <= n <= 7:
        return True
    else:
        return False


day_num = int(input("Task 3.\nEnter the number of the day:"))
if day_num < 1 or day_num > 7:
    print(f"There is no {day_num} day in the week.")
else:
    print(is_weekday(day_num))
