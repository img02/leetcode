func minFlipsMonoIncr(s string) int {
	ones_count, flip_count := 0, 0

	for _, v := range s {
		if v == '1' {
			ones_count++
			continue
		}
		//else char is '0'

		//potential flip count increases
		flip_count++

		//compare new potential flip count with
		//total 1s that would need to be flipped
		//to become monotone increasing
		if ones_count < flip_count {
			flip_count = ones_count
		}
	}
	return flip_count
}