func minFlipsMonoIncr(s string) int {
	ones_count, min_flips := 0, 0

	for _, v := range s {
		if v == '1' {
			ones_count++
			continue
		}
		//else char is '0'

		//potential flip count increases
		min_flips++

		//compare new potential flip count with
		//total 1s that would need to be flipped
		//to become monotone increasing
		if ones_count < min_flips {
			min_flips = ones_count
		}
	}
	return min_flips
}