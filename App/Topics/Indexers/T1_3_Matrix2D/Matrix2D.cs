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
    // 1) Добавьте приватное хранилище (одномерный массив) и размеры.
    // 2) Реализуйте конструктор Matrix2D(int rows, int cols) с проверкой > 0.
    // 3) Реализуйте свойства Rows, Cols.
    // 4) Реализуйте индексатор this[int row, int col] c проверкой границ и отображением к одномерному индексу.
}
