# String to Integer (atoi)
## Medium
### https://leetcode.com/problems/string-to-integer-atoi/description/

Ascii table: https://www.rapidtables.com/code/text/ascii-table.html

Number 0 begins at 48.

So read each number char into a  (byte array in go) or (just char in c#) and subtract 45, 

> Go - create int from value - int(byte val)

> C# - Int32.TryParse(val, out num)


45 is the ascii minus sign value.



Bunch of checks for edge cases and stuff.

Idk, my answer works but took me ages and got really messy from edge cases.

Ideally would / need to refactor.

Annoying question. Too many unneccessary edge cases, felt more like a weird puzzle than algorithm / logic question.

My Go solution - somehow 0ms beats 100%? My code is so bad.