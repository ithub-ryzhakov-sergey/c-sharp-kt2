namespace App.Topics.Indexers.T1_3_Matrix2D;

public class Matrix2D
{
    private readonly double[] _data;

    public int Rows { get; }
    public int Cols { get; }

    public Matrix2D(int rows, int cols)
    {
        if (rows <= 0)
            throw new ArgumentOutOfRangeException(nameof(rows), "Number of rows must be greater than 0");
        if (cols <= 0)
            throw new ArgumentOutOfRangeException(nameof(cols), "Number of columns must be greater than 0");

        Rows = rows;
        Cols = cols;
        _data = new double[rows * cols];
    }

    public double this[int row, int col]
    {
        get
        {
            ValidateIndices(row, col);
            int index = row * Cols + col;
            return _data[index];
        }
        set
        {
            ValidateIndices(row, col);
            int index = row * Cols + col;
            _data[index] = value;
        }
    }

    private void ValidateIndices(int row, int col)
    {
        if (row < 0 || row >= Rows)
            throw new ArgumentOutOfRangeException(nameof(row),
                $"Row index {row} is out of range. Valid range is [0, {Rows - 1}]");

        if (col < 0 || col >= Cols)
            throw new ArgumentOutOfRangeException(nameof(col),
                $"Column index {col} is out of range. Valid range is [0, {Cols - 1}]");
    }

    // Дополнительные методы для удобства работы
    public void Fill(double value)
    {
        for (int i = 0; i < _data.Length; i++)
        {
            _data[i] = value;
        }
    }

    public void FillRandom(double min = 0, double max = 1)
    {
        Random random = new Random();
        for (int i = 0; i < _data.Length; i++)
        {
            _data[i] = random.NextDouble() * (max - min) + min;
        }
    }

    public override string ToString()
    {
        var sb = new System.Text.StringBuilder();
        for (int i = 0; i < Rows; i++)
        {
            for (int j = 0; j < Cols; j++)
            {
                sb.Append($"{this[i, j]:F2}\t");
            }
            sb.AppendLine();
        }
        return sb.ToString();
    }
}