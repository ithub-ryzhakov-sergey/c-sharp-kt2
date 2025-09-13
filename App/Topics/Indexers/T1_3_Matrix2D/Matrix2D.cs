namespace App.Topics.Indexers.T1_3_Matrix2D;

public class Matrix2D
{
    private int[] _matrix;
    public int Rows { get; }
    public int Cols { get; }
    public Matrix2D(int rows, int cols)
    {
        if (rows < 1 || cols < 1)
        {
            throw new ArgumentOutOfRangeException();
        }
        Cols = cols;
        Rows = rows;
        _matrix = new int[Rows*Cols];
    }
    public int this[int row, int col] 
    {
        get
        {
            if (row < 0 || col < 0) { throw new ArgumentOutOfRangeException(); }
            if (row >=Rows || col >= Cols) { throw new ArgumentOutOfRangeException(); }
            return _matrix[row * (Cols - 1) + col];
        }
        set
        {
            if (row < 0 || col < 0) { throw new ArgumentOutOfRangeException(); }
            if (row >=Rows || col >= Cols) { throw new ArgumentOutOfRangeException(); }
            _matrix[row * (Cols -1)+ col] = value;
        }
    }
}
