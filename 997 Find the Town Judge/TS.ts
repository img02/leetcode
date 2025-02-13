function findJudge(n: number, trust: number[][]): number {
    if (n == 1) return 1;
    
    const trustCount = new Array(n).fill(0);

    for (const [truster, trusted] of trust){
        trustCount[truster-1]--;
        trustCount[trusted-1]++;
    }

    for (let i = 0; i < n; i++){
        if (trustCount[i] === n-1) return i+1;
    }

    return -1;    
};


function findJudgeWithMapAndSet(n: number, trust: number[][]): number {

    if (n == 1) return 1;
    
    const map = new Map();
    const people = new Set();

    for(const [truster, trusted] of trust){
        let vote = 1;
        people.add(truster);
        if (map.has(trusted)) vote += map.get(trusted);
        map.set(trusted, vote);
    }    

    for(const [k,v] of map.entries()){    
        if (v === n-1 && !people.has(k)) return k;
    }

    return -1;    
};