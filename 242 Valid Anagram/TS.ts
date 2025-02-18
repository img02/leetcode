function isAnagram(s: string, t: string): boolean {
    if (s.length !== t.length) return false;

    const alphabet: number[] = new Array(26).fill(0);

    for ( const c of s){
        alphabet[c.charCodeAt(0) - 'a'.charCodeAt(0)]++;
    }
    for ( const c of t){
        alphabet[c.charCodeAt(0) - 'a'.charCodeAt(0)]--;
    }
    for (const n of alphabet){
        if (n !== 0) return false;
    }

    return true;
};