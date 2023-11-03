//Determine if a 9 x 9 Sudoku board is valid. Only the filled cells need to be 
//validated according to the following rules: 
//
// 
// Each row must contain the digits 1-9 without repetition. 
// Each column must contain the digits 1-9 without repetition. 
// Each of the nine 3 x 3 sub-boxes of the grid must contain the digits 1-9 
//without repetition. 
// 
//
// Note: 
//
// 
// A Sudoku board (partially filled) could be valid but is not necessarily 
//solvable. 
// Only the filled cells need to be validated according to the mentioned rules. 
//
// 
//
// 
// Example 1: 
// 
// 
//Input: board = 
//[["5","3",".",".","7",".",".",".","."]
//,["6",".",".","1","9","5",".",".","."]
//,[".","9","8",".",".",".",".","6","."]
//,["8",".",".",".","6",".",".",".","3"]
//,["4",".",".","8",".","3",".",".","1"]
//,["7",".",".",".","2",".",".",".","6"]
//,[".","6",".",".",".",".","2","8","."]
//,[".",".",".","4","1","9",".",".","5"]
//,[".",".",".",".","8",".",".","7","9"]]
//Output: true
// 
//
// Example 2: 
//
// 
//Input: board = 
//[["8","3",".",".","7",".",".",".","."]
//,["6",".",".","1","9","5",".",".","."]
//,[".","9","8",".",".",".",".","6","."]
//,["8",".",".",".","6",".",".",".","3"]
//,["4",".",".","8",".","3",".",".","1"]
//,["7",".",".",".","2",".",".",".","6"]
//,[".","6",".",".",".",".","2","8","."]
//,[".",".",".","4","1","9",".",".","5"]
//,[".",".",".",".","8",".",".","7","9"]]
//Output: false
//Explanation: Same as Example 1, except with the 5 in the top left corner 
//being modified to 8. Since there are two 8's in the top left 3x3 sub-box, it is 
//invalid.
// 
//
// 
// Constraints: 
//
// 
// board.length == 9 
// board[i].length == 9 
// board[i][j] is a digit 1-9 or '.'. 
// 
//
// Related Topics Array Hash Table Matrix 👍 9790 👎 1010


//leetcode submit region begin(Prohibit modification and deletion)
public class Solution {
    public bool IsValidSudoku(char[][] board) {
        var columnCheck = new HashSet<char>();
        var rowCheck = new HashSet<char>();
        var subBoxCheck = new HashSet<char>();
        var checkingCol = 0; 
        var checkingSubBox = 0; 
       
        for( int i = 0; i < board.Length; i++)
        {    
            for( int j = 0; j < board[0].Length; j++)
            {
                if (board[i][j] != '.')
                {
                    if (rowCheck.Contains(board[i][j])) return false;
                    else rowCheck.Add(board[i][j]);
                }

                if (board[j][i] != '.')
                {
                    if (columnCheck.Contains(board[j][i])) return false;
                    else columnCheck.Add(board[j][i]);
                }
                
                var subBoxXIndex = 3 * (i / 3) + j / 3;
                var subBoxYIndex = 3 * (i % 3) + (j % 3);
                if (board[subBoxXIndex][subBoxYIndex] != '.')
                {
                    if (subBoxCheck.Contains(board[subBoxXIndex][subBoxYIndex])) return false;
                    else subBoxCheck.Add(board[subBoxXIndex][subBoxYIndex]);
                }
            }
            rowCheck.Clear();
            columnCheck.Clear();
            subBoxCheck.Clear();
        }
        return true;
    }
}
//leetcode submit region end(Prohibit modification and deletion)
