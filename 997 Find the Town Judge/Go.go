func findJudge(n int, trust [][]int) int {
  
  // 1 <= n <= 1000 ; 1-indexed
  var count = [1001]int{}
  
  // for the person trusting, decrease count
  // for the person trusted, increase count
  for _, v := range trust {
      count[v[0]]--
      count[v[1]]++
  }
  
  // from 1st person to nth person
  // if they trust count is n-1
  // they are the judge (trusted by everyone except self)
  for i := 1; i <= n; i++ {
      if (count[i] == n-1){
          return i
      }
  }
  return -1
}


func using2dSlice(n int, trust [][]int) int {
     trustCount := make([][]int, n)
   for i := range trustCount{
       trustCount[i] = make([]int, 1)
   }

   for _, trust := range trust{
       // -1 because n is 1-indexed
       truster := trust[0]-1
       trusted := trust[1]-1

       // increase trusted persons count
       trustCount[trusted][0]++
       // the judge trusts no one, so set truster count to -1
       trustCount[truster][0] = -1;
   }

   for i, v := range trustCount{       
       // +1 because n is 1-indexed
       if v[0] == n-1{ // if any person has trust count (n-people minus themselves)
           return i+1
       }
   }
   return -1
}