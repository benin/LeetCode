using System;

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

        public bool IsValid()
        {
            return 
                CheckRows() && 
                CheckCols() &&
                CheckSquares();
        }

        private bool CheckRows()
        {
            var setValidator = new SetValidator();
            for (int row = 0; row < BoardSize; ++row)
            {
                setValidator.Reset();
                for (int col = 0; col < BoardSize; ++col)
                {
                    if(_boardData[row, col] != 0 && !setValidator.AddUnique(_boardData[row, col]))
                        return false;
                }
            }

            return true;
        }

        private bool CheckCols()
        {
            var setValidator = new SetValidator();
            for (int col = 0; col < BoardSize; ++col)
            {
                setValidator.Reset();
                for (int row = 0; row < BoardSize; ++row)
                {
                    if(_boardData[row, col] != 0 && !setValidator.AddUnique(_boardData[row, col]))
                        return false;
                }
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
                    if(!CheckSquare(row, col))
                        return false;
                }
            }

            return true;
        }

        private bool CheckSquare(int squareRow, int squareCol)
        {
            const int squareSize = 3;
            var setValidator = new SetValidator();

            for (int row = squareRow * squareSize; row < (squareRow + 1) * squareSize; ++row)
            {
                for( int col = squareCol * squareSize; col < (squareCol + 1) * squareSize; ++col)
                {
                    if(_boardData[row, col] != 0 && !setValidator.AddUnique(_boardData[row, col]))
                        return false;
                }
            }

            return true;
        }
    }
}