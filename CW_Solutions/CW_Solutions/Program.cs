// There will be testing in here
//using static Permutations.Permutations;
using static System.Console;
//using static SudokuSolutionValidator.Sudoku;
//using static RangeExtractionLybrary.RangeExtraction;

// Someday I will add menu :)

int[,] a1 = new int[2, 3] { { 1,2,3}
, {4,5,6}};
int[,] a2 = (int[,]) a1.Clone();
WriteLine(a2[0,0]);

/* RangeExtraction
WriteLine(Extract(new int[]{-10, -9, -8, -6, -3, -2, -1, 0, 1, 3, 4, 5, 7, 8, 9, 10, 11, 14, 15, 17, 18, 19, 20}));
*/

/* Task Sudocu
int[][] board = new int[][]
        {
          new int[] {1,0,0,0,0,0,0,0,0},
          new int[] {0,1,0,0,0,0,0,0,0},
          new int[] {0,0,0,0,0,0,0,0,0},
          new int[] {0,0,0,0,0,0,0,0,0},
          new int[] {0,0,0,0,0,0,0,0,0},
          new int[] {0,0,0,0,0,0,0,0,0},
          new int[] {0,0,0,0,0,0,0,0,0},
          new int[] {0,0,0,0,0,0,0,0,0},
          new int[] {0,0,0,0,0,0,0,0,0}
        };
int[][] board2 = new int[][]
        {
          new int[] {5, 3, 4, 6, 7, 8, 9, 1, 2},
          new int[] {6, 7, 2, 1, 9, 5, 3, 4, 8},
          new int[] {1, 9, 8, 3, 0, 2, 5, 6, 7},
          new int[] {8, 5, 0, 7, 6, 1, 4, 2, 3},
          new int[] {4, 2, 6, 8, 5, 3, 7, 9, 1},
          new int[] {7, 0, 3, 9, 2, 4, 8, 5, 6},
          new int[] {9, 6, 1, 5, 3, 7, 2, 8, 4},
          new int[] {2, 8, 7, 4, 1, 9, 6, 3, 5},
          new int[] {3, 0, 0, 2, 8, 6, 1, 7, 9},
        };

WriteLine(ValidateSolution(board));
WriteLine(ValidateSolution(board2));
*/

/* Task Permutations
 SinglePermutations("abc").ForEach(el => WriteLine(el));
 Out: abc acb bac bca cab cba   */

