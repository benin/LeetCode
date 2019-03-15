using System;

namespace SetMatrixZeroes
{
    public class Matrix
    {
        public int Rows { get; }
        public int Cols { get; }
        public int Unique { get; set;}

        public int[,] Source => _source;

        private readonly int[,] _source;

        public Matrix(int[,] matrix)
        {
            _source = matrix;

            Rows = _source.GetLength(0);
            Cols = _source.GetLength(1);
            
            Unique = FindUniq(int.MaxValue / 3);
        }

        private int FindUniq(int xValue)
        {
            int res = xValue;
            for (int row = 0; row < Rows; ++row)
            {
                for (int col = 0; col < Cols; ++col)
                {
                    if (_source[row, col] == xValue)
                    {
                        res = FindUniq(xValue++);
                    }
                }
            }

            return res;
        }

        public void CheckZeroes()
        {
            // Check cols
            for (int row = 0; row < Rows; ++row)
            {
                for (int col = 0; col < Cols; ++col)
                {
                    if (_source[row, col] == 0)
                    {
                        UpdateCrossUnique(row, col);
                    }
                }
            }
        }  
        public void UpdateCrossUnique(int row, int col)
        {
            for (int i = 0; i < Rows; ++i)
            {
                if (_source[i, col] != 0)
                    _source[i, col] = Unique;
            }

            for (int i = 0; i < Cols; ++i)
            {
                if (_source[row, i] != 0)
                    _source[row, i] = Unique;
            }            
        }

        public void UpdateZeroes()
        {
            for (int row = 0; row < Rows; ++row)
            {
                for (int col = 0; col < Cols; ++col)
                {
                    if (_source[row, col] == Unique)
                    {
                        _source[row, col] = 0;
                    }
                }
            }
        }
    }

    public class Solution
    {
        public void SetZeroes(int[,] matrix) 
        {
            var mat = new Matrix(matrix);

            // Check cols
            for (int row = 0; row < mat.Rows; ++row)
            {
                for (int col = 0; col < mat.Cols; ++col)
                {
                    if (mat.Source[row, col] == 0)
                    {
                        mat.UpdateCrossUnique(row, col);
                    }
                }
            }

            mat.UpdateZeroes();
        }

        
    }
}
