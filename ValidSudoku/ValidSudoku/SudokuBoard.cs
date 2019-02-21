using System;
using System.Collections;
using System.Collections.Generic;

namespace ValidSudoku
{
    public class SudokuBoard
    {
        private int[,] _boardData;
        public int BoardSize { get { return 9; }}

        public SudokuBoard(char[,] board)
        {
            _boardData = new int[BoardSize, BoardSize];
            for(int row = 0; row < BoardSize; ++row)
            {
                for(int col = 0; col < BoardSize; ++col)
                {
                    char charVal = board[row, col];
                    if(int.TryParse(charVal.ToString(), out int val))
                    {
                        _boardData[row, col] = val;
                    }
                }
            }
        }

        private IEnumerable<int> Row(int row)
        {
            for (int i = 0; i < BoardSize; ++i)
                yield return _boardData[row, i];
        }

        private IEnumerable<int> Col(int col)
        {
            for (int i = 0; i < BoardSize; ++i)
                yield return _boardData[i, col];
        }

        private IEnumerable<int> SubSquare(int squareRow, int squareCol)
        {
            const int squareSize = 3;
            for (int row = squareRow * squareSize; row < (squareRow + 1) * squareSize; ++row)
            {
                for( int col = squareCol * squareSize; col < (squareCol + 1) * squareSize; ++col)
                {
                    yield return _boardData[row, col];
                }
            }
        }

        public bool IsValid()
        {
            return 
                CheckRows() && 
                CheckCols() &&
                CheckSquares();
        }

        private bool CheckRows()
        {
            for (int row = 0; row < BoardSize; ++row)
            {
                var setValidator = new SetValidator(Row(row));
                if (!setValidator.IsUnique)
                    return false;
            }

            return true;
        }

        private bool CheckCols()
        {
            
            for (int col = 0; col < BoardSize; ++col)
            {
                var setValidator = new SetValidator(Col(col));
                if (!setValidator.IsUnique)
                    return false;
            }

            return true;
        }
        
        private bool CheckSquares()
        {
            const int squareSize = 3;
            for (int row = 0; row < squareSize; ++row)
            {
                for( int col = 0; col < squareSize; ++col)
                {
                    var setValidator = new SetValidator(SubSquare(row, col));
                    if (!setValidator.IsUnique)
                        return false;
                }
            }

            return true;
        }
    }
}