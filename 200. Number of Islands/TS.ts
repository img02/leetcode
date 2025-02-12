function numIslands(grid: string[][]): number {
    let islands: number = 0;

    for(let r = 0; r < grid.length; r++){
        for(let c = 0; c < grid[0].length; c++){

            if (grid[r][c] === '1'){

                //bfs(r,c);
                //dfs_iterative(r,c);
                dfs_recursive(r,c, grid);

                //mark as visited by changing to 0
                grid[r][c] = '0';
                islands++;
            }
        }
    }

    function bfs(row: number, col: number): void{
        const queue: number[][] = [[row,col]];        

        while (queue.length > 0){
            const [r,c] = queue.shift();
            const directions = [[1,0],[-1,0],[0,-1],[0,1]];

            for (const [rowMove, colMove] of directions){
                //check left / right
                if (0 <= r+rowMove && r+rowMove < grid.length){
                    if (grid[r+rowMove][c] === '1'){
                        queue.push([r+rowMove,c]);
                        grid[r+rowMove][c] = '0';
                    }
                }
                //check above / below
                if (0 <= c+colMove && c+colMove < grid[0].length){
                    if (grid[r][c+colMove] === '1'){
                        queue.push([r,c+colMove]);
                        grid[r][c+colMove] = '0';
                    }
                }
            }
        }
    }

    function dfs_iterative(row: number, col: number): void{
        const stack: number[][] = [[row,col]];        

        while (stack.length > 0){
            const [r,c] = stack.pop();
            const directions = [[1,0],[-1,0],[0,-1],[0,1]];

            for (const [rowMove, colMove] of directions){
                //check left / right
                if (0 <= r+rowMove && r+rowMove < grid.length){
                    if (grid[r+rowMove][c] === '1'){
                        stack.push([r+rowMove,c]);
                        grid[r+rowMove][c] = '0';
                    }
                }
                //check above / below
                if (0 <= c+colMove && c+colMove < grid[0].length){
                    if (grid[r][c+colMove] === '1'){
                        stack.push([r,c+colMove]);
                        grid[r][c+colMove] = '0';
                    }
                }
            }
        }

    }

    return islands;
};

function dfs_recursive(row: number, col: number, grid: string[][]): void {
    if (row < 0 || row >= grid.length) return;
    if (col < 0 || col >= grid[0].length) return;
    if (grid[row][col] === '0') return;

    grid[row][col] = '0';

    dfs_recursive(row+1, col, grid);
    dfs_recursive(row-1, col, grid);
    dfs_recursive(row, col+1, grid);
    dfs_recursive(row, col-1, grid);
}