// Task 1
func positiveCount(array: [Int]) -> Int {
    var cnt = 0
    for num in array {
        if num > 0 {
            cnt += 1
        }
    }
    return cnt
}

print("Task 1\nEnter numbers splitting values by space:")
let nums = readLine()!.split(separator: " ").map { Int($0)! }
print(positiveCount(array: nums))

// Task 2
func findIntersection(k1: Double, b1: Double, k2: Double, b2: Double) -> (Double, Double) {
    let x = ((b1 - b2) / (k1 - k2) * (-1))
    let y = k2 * x + b2
    return (x, y)
}

print("Task 2\nEnter (k1, b1, k2, b2) splitting values by space:")
let params = readLine()!.split(separator: " ").map { Double($0)! }
print(findIntersection(k1: params[0], b1: params[1], k2: params[2], b2: params[3]))
