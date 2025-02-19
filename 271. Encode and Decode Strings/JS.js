class Solution {
    /**
     * @param {string[]} strs
     * @returns {string}
     */
    encode(strs) {
        let encoded = "";

        for(const s of strs){
            const len = s.length;
            encoded += len + "%" + s;
        }
        return encoded;
    }

    /**
     * @param {string} str
     * @returns {string[]}
     */
    decode(str) {
        const decoded = [];
        //4%good3%yes
        let i = 0;
        while (i < str.length){
            let j = i+1;
            // find out delimited '%'
            while (str[j] !== '%') j++;
            
            const len = parseInt(str.substring(i,j));

            const word = str.substring(j+1, j + 1 + len);            

            decoded.push(word);        

            i = j + len + 1;
        }
        return decoded;
    }
}
