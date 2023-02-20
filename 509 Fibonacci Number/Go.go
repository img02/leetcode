func fib(n int) int {
    //return recursive(n)
    return memoization(n)
    //return forLoop(n);
}

func forLoop(n int) int {
    if (n == 0) {
        return 0
    }
    if (n == 1 || n == 2) {
        return 1;
    }

    first, second := 1, 1;

    for i := 3; i < n; i++ {
        first, second = second, first+second;
    }

    return first+second;
}

func recursive(n int) int {
    if n == 0 {
        return 0
    }
    if n <= 2 {
        return 1
    }    
    return recursive(n-1) + recursive(n-2)
}

var fibMap = make(map[int]int)

func memoization(n int) int {
    if n == 0 {
        return 0
    }

    if n <= 2 {
        return 1
    }

    if v, ok := fibMap[n]; ok {
        return v;
    }

    fibMap[n] = memoization(n-1) + memoization(n-2)
    return fibMap[n]
}
