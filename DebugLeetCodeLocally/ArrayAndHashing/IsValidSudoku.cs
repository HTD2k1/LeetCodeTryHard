public class IsValidSudokuSolution
{   
    /*
     * Sudoku is valid (does not need to be sovable) if
     * All numbers in each column are not the same
     * All numbers in each row are not the same
     * All numbers in each 3x3 sub-box are not the same
     */
    
    // Naive approach: Check every rows, columns and sub-boxes using HashSet
    public bool IsValidSudoku(char[][] board)
    {
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