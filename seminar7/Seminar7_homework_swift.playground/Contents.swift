// Task 1
func randomDoubleMatrix(m: Int, n: Int) -> [[Double]] {
    var mtrx = Array(repeating: Array(repeating: 0.0, count: n), count: m)
    for i in 0...m - 1 {
        for j in 0...n - 1 {
            mtrx[i][j] = Double.random(in: 0...10)
        }
    }
    return mtrx
}

let randMatr = randomDoubleMatrix(m: 4, n: 6)
print("Task 1.\n", randMatr)

// Task 2
func coordsValue(mtrx: [[Double]], i: Int, j: Int) {
    if i >= mtrx.count || j >= mtrx[0].count || i < 0 || j < 0 {
        print("No such element in array.")
    }
    else {
        print(mtrx[i][j])
    }
}

print("Task 2.")
coordsValue(mtrx: randMatr, i: 3, j: 5)

// Task 3
func printIntMatrix(mtrx: [[Int]]) {
    for item in mtrx {
        print(item)
    }
}

func randomIntMatrix(m: Int, n: Int) -> [[Int]] {
    var mtrx = Array(repeating: Array(repeating: 0, count: n), count: m)
    for i in 0...m - 1 {
        for j in 0...n - 1 {
            mtrx[i][j] = Int.random(in: 0...10)
        }
    }
    return mtrx
}

func findAvgOfColumn(mtrx: [[Int]]) -> [Double] {
    let rowSize = mtrx[0].count
    let columnSize = mtrx.count
    var avg: [Double] = []
    for j in 0...rowSize - 1 {
        var sm = 0
        for i in 0...columnSize - 1 {
            sm += mtrx[i][j]
        }
        avg.append(Double(sm) / Double(columnSize))
    }
    return avg
}

let randIntMatr = randomIntMatrix(m: 4, n: 4)
print("Task 3.")
printIntMatrix(mtrx: randIntMatr)
print("Avg's of each column are:\n\(findAvgOfColumn(mtrx: randIntMatr))")
