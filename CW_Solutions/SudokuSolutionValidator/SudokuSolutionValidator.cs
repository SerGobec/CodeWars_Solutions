namespace SudokuSolutionValidator
{
    /* 
     * 
     * Sudoku Background
        Sudoku is a game played on a 9x9 grid. The goal of the game is to fill all cells of the grid with digits from 1 to 9, so that each column, each row, and each of the nine 3x3 sub-grids (also known as blocks) contain all of the digits from 1 to 9.

        Sudoku Solution Validator
        Write a function validSolution/ValidateSolution/valid_solution() that accepts a 2D array representing a Sudoku board, and returns true if it is a valid solution, or false otherwise. The cells of the sudoku board may also contain 0's, which will represent empty cells. Boards containing one or more zeroes are considered to be invalid solutions.

        The board is always 9 cells by 9 cells, and every cell only contains integers from 0 to 9.
     * 
     * 
     */
    public partial class Sudoku
    {
        public static bool ValidateSolution(int[][] board)
        {
            foreach (int[] arr in board) if (arr.Contains(0)) return false;
            foreach (int[] arr in board) if( HaveColisions(arr) ) return false;
            board.Reverse();
            foreach (int[] arr in board) if (HaveColisions(arr)) return false;
            for (int i = 0; i < 3;i++)
            {
                for(int j = 0;j < 3; j++)
                {
                    if(HaveColisions(CreateBlockFromBoard(board, i*3, j*3 ))) return false;
                }
            }
            return true;
        }

        public static int[] CreateBlockFromBoard(int[][] board, int x, int y)
        {
            List<int> block = new List<int>();
            for(int i = y; i < y + 3; i++) block.AddRange(board[i].Skip(x).Take(3));
            return block.ToArray();
        }
        public static bool HaveColisions(int[] arr)
        {
            return arr.GroupBy(el => el).FirstOrDefault(el => el.Count() > 1) != null;
        }
    }
}