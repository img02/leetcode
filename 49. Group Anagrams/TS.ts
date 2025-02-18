function groupAnagrams(strs: string[]): string[][] {
    const anagrams = new Map<string, string[]>();

    for(let s of strs){
        const hash = new Array<number>(26).fill(0);
        
        for(let c of s){
            hash[c.charCodeAt(0) - 'a'.charCodeAt(0)]++;
        }
        const key = hash.join(',');
        
        if (!anagrams.has(key)){
            anagrams.set(key,[]);            
        }
        anagrams.get(key).push(s);
    }

    return Array.from(anagrams.values());
};