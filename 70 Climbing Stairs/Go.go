func climbStairs(n int) int {
    //return recursive(n);
    return dp(n);
}


// a map of the possible combos to reach 0 from point m
// where n > m > 0
// with steps of -1 or -2
var combos = make(map[int]int)

func recursive(n int) int {
    // if n is negative, invalid combo
    if (n < 0) {
        return 0
    }
    // if n is 0 a valid step for complete combo
    if (n == 0) {
        return 1
    }
    // if the number of possible combos is already recorded
    // return that value
    if v, ok := combos[n]; ok {
        return v
    }
    // otherwise evaluate the possible combinations
    // and add it to the map
    combos[n] = recursive(n-1) + recursive(n-2)
    return combos[n]
}

func dp (n int) int {
  // one and two are the combo counts for the 2 previous steps
  // climbing from 0 to n
  // it takes 0 steps to get to step 0
  // it takes 1 step to get to step 1 - from 0        

  // it takes (combos to step 0)+2 to get to step 2
  // it takes (combos to step 1)+1 to get to step 2

  // basically, the combination count for each step is made of of
  // the count for the prior step + (taking 1 step)
  // and the count for the prior-prior step + (taking 2 steps)       
        
  //starting at step 0 and 1

  one, two := 0, 1;

  for i := 0; i < n; i++ {
      temp := two
      two = one + two
      one = temp
  }
  return two
}