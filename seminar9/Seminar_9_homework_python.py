# Task 64
array = []


def reversed_range(n):
    if n >= 1:
        array.append(n)
        reversed_range(n - 1)


reversed_range(8)
print(f"Task 64.\n{array}")

# Task 66
sm = 0


def sum_of_range(m, n):
    global sm
    if n >= m:
        sm += n
        sum_of_range(m, n - 1)


sum_of_range(1, 15)
print("Task 66.\n%d" % sm)

# Task 68


def ackermann(n, m):
    if n == 0:
        return m + 1
    if m == 0:
        return ackermann(n - 1, 1)
    return ackermann(n - 1, ackermann(n, m - 1))


print("Task 68.\n{}".format(ackermann(3, 2)))


def pascal_triangle(n):
    result = []
    for i in range(n):
        x = 1
        for _ in range(n - i):
            result.append("   ")
        for j in range(i + 1):
            result.append(f"   {x}  ")
            x = x * (i - j) // (j + 1)
        result.append("\n")
    return "".join(result)


print("Pascal triangle:\n%s" % pascal_triangle(10))
