## Task 1
## Либо такой однострочник:
print(len(list(filter(lambda x: x > 0, map(int, input("Enter numbers splitting values by space:").split())))))
## Либо такой:
print(len([x for x in map(int, input("Enter numbers splitting values by space:").split()) if x > 0]))

## Task 2


def find_intersection(k1, b1, k2, b2):
    x = ((b1 - b2) / (k1 - k2) * (-1))
    y = k2 * x + b2
    return x, y


k1, b1, k2, b2 = map(float, input("Enter (k1, b1, k2, b2) splitting values by space:").split())
print(f"The point of intersection is {find_intersection(k1, b1, k2, b2)}")
