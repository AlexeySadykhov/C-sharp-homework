import random
from functools import reduce

# Task 1


def generate_random_matrix(mn, mx, m, n, mode = 'int'):
    mtrx = []
    if mode == 'int':
        mtrx = [[random.randint(mn, mx) for _ in range(n)] for _ in range(m)]
    if mode == 'float':
        mtrx = [[random.uniform(mn, mx) for _ in range(n)] for _ in range(m)]
    return mtrx


def print_matrix(mtrx):
    for item in mtrx:
        print(item)


print("Task 1.")
rand_matr = generate_random_matrix(mn=1, mx=9, m=5, n=4, mode='float')
print_matrix(rand_matr)

# Task 2


def coords_value(mtrx, i, j):
    if i >= len(mtrx) or j >= len(mtrx[0]) or i < 0 or j < 0:
        print("No such element in array.")
    else:
        print(mtrx[i][j])


print("Task 2.")
coords = list(map(int, input("Enter coordinates of the matrix (i, j) splitting values by space:").split()))
coords_value(rand_matr, coords[0], coords[1])

# Task 3


def find_avg_of_column(mtrx):
    # Чисто по-приколу))
    return list(map(lambda item: reduce(lambda a, x: a + x, item) / len(item), [[mtrx[i][j] for i in range(len(mtrx[0]))] for j in range(len(mtrx))]))


print("Task 3.")
rand_int_matr = generate_random_matrix(mn=1, mx=20, m=4, n=4)
print_matrix(rand_int_matr)
print(f"Avg's of each column are:\n{find_avg_of_column(rand_int_matr)}")
