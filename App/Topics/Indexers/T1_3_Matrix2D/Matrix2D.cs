// Topic: Indexers — T1.3 Matrix2D (2D indexer)
// Задача: реализовать матрицу фиксированного размера с индексатором this[int row, int col].
// Требования:
// - Конструктор Matrix2D(int rows, int cols): rows>0, cols>0; иначе ArgumentOutOfRangeException.
// - Свойства Rows, Cols — размеры.
// - Хранение можно сделать во внутреннем одномерном массиве длиной rows*cols.
// - Индексатор get/set с проверкой границ (row in [0, Rows), col in [0, Cols)), иначе ArgumentOutOfRangeException.
// - Отображение (row, col) -> index: row * Cols + col.

using App.Topics.Indexers.T1_1_IntList;
using System.Data;

namespace App.Topics.Indexers.T1_3_Matrix2D;

public class Matrix2D
{
    // Студенту:
    // 1) Добавьте приватное хранилище (одномерный массив) и размеры.
    // 2) Реализуйте конструктор Matrix2D(int rows, int cols) с проверкой > 0.
    // 3) Реализуйте свойства Rows, Cols.
    // 4) Реализуйте индексатор this[int row, int col] c проверкой границ и отображением к одномерному индексу.

    private int[] arr;
    private int rows;
    private int cols;

    public Matrix2D(int rows, int cols)
    {
        if (rows <= 0)
            throw new ArgumentOutOfRangeException($"{nameof(rows)} < 0");
        if (cols <= 0)
            throw new ArgumentOutOfRangeException($"{nameof(cols)} < 0");

        this.rows = rows;
        this.cols = cols;
        this.arr = new int[cols * rows];
    }

    public int this[int row, int col]
    {
        get
        {
            Validate(row, col);
            var index = GetIndex(row, col);
            return this.arr[index];
        }

        set
        {
            Validate(row, col);
            var index = GetIndex(row, col);
            this.arr[index] = value;
        }
    }

    private void Validate(int row, int col)
    {
        if ((row >= 0 && row < this.rows) is false)
            throw new ArgumentOutOfRangeException($"{nameof(row)} не входит {this.rows - 1}");
        if ((col >= 0 && col < this.cols) is false)
            throw new ArgumentOutOfRangeException($"{nameof(col)} не входит {this.cols - 1}");
    }

    private int GetIndex(int row, int col)
    {
        return row * this.cols + col;
    }
}
