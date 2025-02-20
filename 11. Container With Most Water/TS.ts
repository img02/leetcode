function maxArea(height: number[]): number {
    let maxWater = 0;
    let left = 0;
    let right = height.length-1;

    while(left < right){
        const lowestHeight = Math.min(height[left], height[right]);
        const water = (right-left) * lowestHeight;
        maxWater = Math.max(water, maxWater);

        if (height[left] > height[right]) right--;
        else left++;
    }

    return maxWater;    
};