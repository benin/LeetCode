using System;

namespace ValidSudoku
{
    public class Solution
    {
        public bool IsValidSudoku(char[,] board)
        {
            return new SudokuBoard(board).IsValid();
        }
    }
}
