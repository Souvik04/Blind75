using System;
using System.Collections.Generic;
using System.Text;

namespace Blind75
{
    public class Graph
    {
        /// <summary>
        /// Ref: https://leetcode.com/problems/number-of-islands/
        /// </summary>
        /// <param name="grid"></param>
        /// <returns>Count of total islands</returns>
        public int NumIslands(char[][] grid)
        {
            int count = 0;

            for (int i = 0; i < grid.Length; i++)
            {
                for (int j = 0; j < grid[0].Length; j++)
                {
                    if (grid[i][j] == '1')
                    {
                        DFS(grid, i, j);
                        count++;
                    }
                }
            }
            return count;
        }

        private void DFS(char[][] grid, int r, int c)
        {
            if (r < 0 || r >= grid.Length || c < 0 || c >= grid[0].Length || grid[r][c] == '0')
            {
                return;
            }

            grid[r][c] = '0';

            int[] dir = new int[] { -1, 1, -1, 1 };

            for (int i = 0; i < 4; i++)
            {
                DFS(grid, r + dir[i], c);
                DFS(grid, r, c + dir[i]);
            }
        }
    }
}
