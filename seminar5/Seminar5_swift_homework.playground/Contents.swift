// Task 1
func randomIntegers(min: Int, max: Int, size: Int = 8) -> [Int] {
    var array: [Int] = []
    for _ in 1...size {
        array.append(Int.random(in: min..<max))
    }
    return array
}

func evenCount(nums: [Int]) -> Int {
    var cnt = 0;
    for num in nums {
        if num % 2 == 0 {
            cnt += 1
        }
    }
    return cnt
}

let array = randomIntegers(min: 100, max: 999)
print("Task 1")
print(array)
print(evenCount(nums: array))

// Task 2
func oddIndexSum(nums: [Int]) -> Int {
    var sm = 0
    for i in stride(from: 1, to: nums.count, by: 2) {
        sm += nums[i]
    }
    return sm
}

let arr = randomIntegers(min: -50, max: 50, size: 5)
print("Task 2")
print(arr)
print(oddIndexSum(nums: arr))

// Task 3
func randomDoubles(min: Double, max: Double, size: Int = 5) -> [Double] {
    var array: [Double] = []
    for _ in 1...size {
        array.append(Double.random(in: min..<max))
    }
    return array
}

func minMaxDiff(array: [Double]) -> Double {
    var minVal = array[0]
    var maxVal = array[0]
    for item in array {
        if item < minVal {
            minVal = item
        }
        if item > maxVal {
            maxVal = item
        }
    }
    return maxVal - minVal
}

let numbers = randomDoubles(min: -10, max: 10)
print("Task 3")
print(numbers)
print(minMaxDiff(array: numbers))
