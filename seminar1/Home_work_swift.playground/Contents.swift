// task 1
func compareTwoNums(x: Int, y: Int) -> Int {
    if x > y {
        return x
    }
    else {
        return y
    }
}
print("Task 1\nmax = \(compareTwoNums(x: 5, y: 9))")

// task 2
func compareThreeNums(x: Int, y: Int, z: Int) -> Int {
    let array: [Int] = [x, y, z]
    var maxEl = x
    for item in array {
        if item > maxEl {
            maxEl = item
        }
    }
    return maxEl
}
print("Task 2\nmax = \(compareThreeNums(x: -1, y: 20, z: -3))")

// task 3
func isEven(x: Int) -> Bool {
    if x % 2 == 0 {
        return true
    }
    else {
        return false
    }
}
let num = -7
print("Task 3\nIs \(num) even number? \(isEven(x: num))")

// task 4
func evenRange(x: Int) -> [Int] {
    var arr: [Int] = []
    if x <= 1 {
        print("Number must be higher than 1.")
    }
    else {
        for i in 1...x {
            if i % 2 == 0 {
                arr.append(i)
            }
        }
    }
    return arr
}
print("Task 4")
print(evenRange(x: 8))
