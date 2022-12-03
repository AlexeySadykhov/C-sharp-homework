// Tasks 1 and 2
func findDigit(n: inout Int, d: Int) -> Int {
    if n < 0 {
        n = n * (-1)
    }
    var remain: [Int] = []
    while n > 0 {
        remain.append(n % 10)
        n /= 10
    }
    if remain.count < d {
        return -1
    }
    else {
        return remain[remain.count - d]
    }
}
var number = -1342
print(findDigit(n: &number, d: 2))

// Task 3
func isWeekday(n: Int) -> Bool {
    if n == 6 || n == 7 {
        return true
    }
    else {
        return false
    }
}
let dayNum = 7
if dayNum < 1 || dayNum > 7 {
    print("There is no \(dayNum) day in the week.")
}
else {
    print(isWeekday(n: dayNum))
}
