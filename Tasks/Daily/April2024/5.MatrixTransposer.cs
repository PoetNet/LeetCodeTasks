namespace Tasks.Daily.April2024;

public class MatrixTransposer
{
    public int[][] Transpose(int[][] matrix)
    {
        int rows = matrix[0].Length;
        int cols = matrix.Length;

        var result = new int[rows][];

        for (int i = 0; i <= rows; i++)
        {
            result[i] = new int[cols];
            for (int j = 0; j <= cols; j++)
            {
                result[i][j] = matrix[j][i];
            }
        }

        return result;
    }
}
