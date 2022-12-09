// Task 1
func numberToPow(x: Int, n: Int) -> Int {
    var result = 1
    for _ in 1...n {
        result = result * x
    }
    return result
}
print(numberToPow(x: 3, n: 5))

// Task 2
func sumOfDigits(x: inout Int) -> Int {
    var sm = 0
    while x > 0 {
        sm += x % 10
        x /= 10
    }
    return sm
}
var number = 452
print(sumOfDigits(x: &number))

// Task 3
func createArray(size: Int) -> [Int] {
    var array: [Int] = []
    for _ in 1...size {
        array.append(Int.random(in: 0..<100))
    }
    return array
}
print(createArray(size: 8))
