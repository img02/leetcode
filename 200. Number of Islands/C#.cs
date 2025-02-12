public class Solution {
    public int NumIslands(char[][] grid) {
        var islands = 0;

        for (var r = 0; r < grid.Length; r++){

            for (var c = 0; c < grid[0].Length; c++){

                if (grid[r][c] == '1') {
                    islands++;
                    //BFS(r,c);
                    //DFS_Iterative(r,c);
                    DFS_Recursive(r,c);
                }
                //mark as visited
                grid[r][c] = '0';
            }
        }

         void BFS(int row, int col){
            var q = new Queue<(int,int)>();
            q.Enqueue((row,col));

            while (q.Count > 0){
                var (r,c) = q.Dequeue();

                var directions = new (int,int)[] {(1,0),(-1,0),(0,1),(0,-1)};
                
                foreach (var (dr,dc) in directions){
                    // check row
                    if ((r+dr) >= 0 && (r+dr) < grid.Length && 
                    grid[r+dr][c] == '1'){
                            q.Enqueue((r+dr, c));
                            grid[r+dr][c] = '0';
                    }
                    //check column
                    if ((c+dc) >= 0 && (c+dc) < grid[0].Length && 
                    grid[r][c+dc] == '1'){
                            q.Enqueue((r,c+dc));
                            grid[r][c+dc] = '0';
                    }
                }
            }
        }

        void DFS_Iterative(int row, int col){
            var stack = new Stack<(int,int)>();
            stack.Push((row,col));

            while (stack.Count > 0){
                var (r,c) = stack.Pop();
                var directions = new (int,int)[] {(1,0),(-1,0),(0,1),(0,-1)};
                
                foreach (var (dr,dc) in directions){
                    // check row
                    if ((r+dr) >= 0 && (r+dr) < grid.Length &&
                     grid[r+dr][c] == '1'){                                                
                            stack.Push((r+dr, c));                        
                             grid[r+dr][c] = '0';
                    }
                    //check column
                    if ((c+dc) >= 0 && (c+dc) < grid[0].Length && 
                    grid[r][c+dc] == '1'){
                            stack.Push((r,c+dc));
                             grid[r][c+dc] = '0';
                    }
                }
            }
        }

        void DFS_Recursive(int row, int col){
            if (0 > row || row >= grid.Length) return;
            if (0 > col || col >= grid[0].Length) return;
            if (grid[row][col] == '0') return;
            else grid[row][col] = '0';

            DFS_Recursive(row-1,col);
            DFS_Recursive(row+1,col);
            DFS_Recursive(row,col-1);
            DFS_Recursive(row,col+1);
        }

        return islands;
    }
}
