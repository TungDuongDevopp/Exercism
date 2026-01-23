public static class SaddlePoints
{
    public static IEnumerable<(int, int)> Calculate(int[,] matrix)
    {
        int row = matrix.GetLength(0);
        int col = matrix.GetLength(1);

        return from i in Enumerable.Range(0, row)
               from j in Enumerable.Range(0, col)
               let currentValue = matrix[i, j]
              
               let isMaxInRow = Enumerable.Range(0, col)
                    .All(colIndex => currentValue >= matrix[i, colIndex])
               
               let isMinInColumn = Enumerable.Range(0, row)
                   .All(rowIndex => currentValue <= matrix[rowIndex, j])
               
               where isMaxInRow && isMinInColumn
               select (i+1,j+1); 
    }
}
