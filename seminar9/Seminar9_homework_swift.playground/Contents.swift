// Task 64
var array: [Int] = []

func reversedRange(n: Int) {
    if n >= 1 {
        array.append(n)
        reversedRange(n: n - 1)
    }
}

reversedRange(n: 8)
print("Task 64.\n\(array)")

// Task 66
var sm = 0

func sumOfRange(m: Int, n: Int) {
    if n >= m {
        sm += n
        sumOfRange(m: m, n: n - 1)
    }
}

sumOfRange(m: 1, n: 15)
print("Task 66.\n\(sm)")

// Task 68
func ackermann(n: Int, m: Int) -> Int {
    if n == 0 {
        return m + 1
    }
    if m == 0 {
        return ackermann(n: n - 1, m: 1)
    }
    return ackermann(n: n - 1, m: ackermann(n: n, m: m - 1))
}

print("Task 68.\n\(ackermann(n: 3, m: 2))")

// Pascal triangle
func pascalTriangle(n: Int) -> String {
    var result: [String] = []
    for i in 0...n - 1{
        var x = 1
        for _ in 0...n - i - 1 {
            result.append("   ")
        }
        for j in 0...i {
            result.append("   \(x)  ")
            x = x * (i - j) / (j + 1)
        }
        result.append("\n")
    }
    return result.joined()
}

print("Pascal triangle:\n\(pascalTriangle(n: 10))")
