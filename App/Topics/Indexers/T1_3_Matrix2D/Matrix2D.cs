// Topic: Indexers — T1.3 Matrix2D (2D indexer)
// Задача: реализовать матрицу фиксированного размера с индексатором this[int row, int col].
// Требования:
// - Конструктор Matrix2D(int rows, int cols): rows>0, cols>0; иначе ArgumentOutOfRangeException.
// - Свойства Rows, Cols — размеры.
// - Хранение можно сделать во внутреннем одномерном массиве длиной rows*cols.
// - Индексатор get/set с проверкой границ (row in [0, Rows), col in [0, Cols)), иначе ArgumentOutOfRangeException.
// - Отображение (row, col) -> index: row * Cols + col.

namespace App.Topics.Indexers.T1_3_Matrix2D;

public class Matrix2D
{
    // Студенту:
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
    // 4) Реализуйте индексатор this[int row, int col] c проверкой границ и отображением к одномерному индексу.
}
