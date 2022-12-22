import random
from functools import reduce

# Task 54


def print_matrix(mtrx):
    for item in mtrx:
        print(item)
    print()


def generate_random_matrix(m, n, mn, mx):
    return [[random.randint(mn, mx) for _ in range(n)] for _ in range(m)]


def bubble_sort(array, reverse=False):
    for i in range(len(array) - 1):
        for j in range(len(array) - i - 1):
            if not reverse:
                if array[j] > array[j + 1]:
                    array[j], array[j + 1] = array[j + 1], array[j]
            else:
                if array[j] < array[j + 1]:
                    array[j], array[j + 1] = array[j + 1], array[j]
    return array


rand_mtrx = generate_random_matrix(mn=0, mx=9, m=6, n=6)
print("Task 54.\nRandom matrix:")
print_matrix(rand_mtrx)
print("Sorted rows:")
print_matrix(list(map(lambda item: bubble_sort(array=item, reverse=True), rand_mtrx)))

# Task 56


def find_min(array):
    min_val_index = 0
    for i in range(len(array)):
        if array[i] < array[min_val_index]:
            min_val_index = i
    return min_val_index


rectangular_matrix = generate_random_matrix(m=6, n=4, mn=1, mx=9)
print("Task 56.\nMatrix:")
print_matrix(rectangular_matrix)
min_sum = find_min(list(map(lambda row: reduce(lambda a, x: a + x, row), rectangular_matrix)))
print("Min sum of elements is in row %d. Sum is:" % (min_sum + 1))
# Если надо найти саму сумму, а не индекс, можно вот так сделать одной строчкой:
print(reduce(lambda a, x: a if a < x else x, map(lambda row: reduce(lambda a, x: a + x, row), rectangular_matrix)))

# Task 58


def multiply_matrices(mtrx_a, mtrx_b):
    m = len(mtrx_a)
    n = len(mtrx_b[0])
    result = [[0 for _ in range(m)] for _ in range(m)]
    if m != n:
        print("It is impossible to multiply these matrices.")
        return result
    for i in range(m):
        for j in range(m):
            for l in range(m):
                result[i][j] = mtrx_a[i][l] * mtrx_b[l][j]
    return result


matrix_A = generate_random_matrix(m=4, n=4, mn=0, mx=9)
matrix_B = generate_random_matrix(m=4, n=4, mn=1, mx=9)
print("\nTask 58.\nMatrix A:")
print_matrix(matrix_A)
print("Matrix B:")
print_matrix(matrix_B)
print("Product:")
print_matrix(multiply_matrices(matrix_A, matrix_B))

# Task 60


def generate_3d_array(m, n, k):
    nums = random.sample([i for i in range(10, 99)], m * n * k)
    array = [[[0 for _ in range(k)] for _ in range(n)] for _ in range(m)]
    c = 0
    for i in range(m):
        for j in range(n):
            for l in range(k):
                array[i][j][l] = nums[c]
                c += 1
    return array


def print_3d_array(array):
    for i in range(len(array)):
        for j in range(len(array[0])):
            for l in range(len(array[0][0])):
                print(f"{array[i][j][l]}({i},{j},{l})")
    print()


print("Task 60.")
print_3d_array(generate_3d_array(2, 2, 2))

# Task 62


def spiral_matrix(m, n):
    mtrx = [[0] * n for _ in range(m)]
    top = left = 0
    bottom = m - 1
    right = n - 1
    c = 1
    while c <= m * n:
        for i in range(left, right + 1):
            mtrx[top][i] = c
            c += 1
        top += 1
        for i in range(top, bottom + 1):
            mtrx[i][right] = c
            c += 1
        right -= 1
        for i in range(right, left - 1, -1):
            mtrx[bottom][i] = c
            c += 1
        bottom -= 1
        for i in range(bottom, top - 1, -1):
            mtrx[i][left] = c
            c += 1
        left += 1
    return mtrx


print("Task 62.")
print_matrix(spiral_matrix(4, 4))
