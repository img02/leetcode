
private int CountFlips(string s)
    { 
        var ones_count = 0;
        var min_flips = 0;

        foreach (var c in s)
        {
			/* //bad for readability, but 2 lines xd
            if (c == '1') ones_count++;
            else  min_flips = Math.Min(++min_flips, ones_count);  
			*/
			
			if (c == '1') {
                ones_count++;
                continue;
            }

			min_flips++;
			
            if (ones_count < min_flips) 
            {
            min_flips = ones_count;
            }            
        }
        return min_flips;
    }