using System;

namespace RotateImage
{
  // [1,2,3]    [7,4,1]
  // [4,5,6] => [8,5,2]
  // [7,8,9]    [9,6,3]
  // 
  // [0, 0] => [0, 2]
  // [0, 1] => [1, 2]
  // [0, 2] => [2, 2]
  // [1, 0] => [0, 1]
  // [1, 1] => [1, 1]
  // [1, 2] => [2, 1]
  // [2, 0] => [0, 0]
  // [2, 1] => [1, 0]
  // [2, 2] => [2, 0]
  //
  // row' = col
  // col' = (n-1) - row

    public class Solution
    {
        class Matrix
        {
            private readonly int[][] _matrix;
            public int N { get; }

            public Matrix(int [][] matrix)
            {
                _matrix = matrix;
                N = matrix.GetLength(0);
            }

            public void RotateCells(int row, int col)
            {
                RotateCell(row, col, 4);
            }

            private void RotateCell(int row, int col, int iter)
            {
                int rr = _matrix[row][col];
                if(iter > 0 )
                    RotateCell(col, N-1 - row, iter-1);
                _matrix[col][N-1-row] = rr;
            }
        }
        
        public void Rotate(int[][] matrix) 
        {
            var mat = new Matrix(matrix);
            for(int row = 0; row < mat.N-1; row++)
                for(int col = row; col < mat.N-1 - row; col++)
                    mat.RotateCells(row,col);            
        }
    }
}
