// Topic: Indexers — T1.1 IntList (basic)
// Задача: реализовать класс динамического списка целых чисел с индексатором this[int index].
// Требования:
// - Свойство Count — текущее количество элементов.
// - Индексатор get должен бросать ArgumentOutOfRangeException при index < 0 или index >= Count.
// - Индексатор set:
//   * если index в диапазоне [0, Count-1] — заменить значение;
//   * если index == Count — добавить значение в конец (расширение на 1);
//   * если index > Count или index < 0 — бросать ArgumentOutOfRangeException.
// Примечание: это упражнение тренирует базовую работу с индексатором.

namespace App.Topics.Indexers.T1_1_IntList;

public class IntList
{
    private List<int> _arr { get; set; }
    public int Count { get { return _arr.Count; } }
    public IntList()
    {
        _arr = new List<int> { };
    }

    public int this[int i]
    {
        get
        {
            if (i < 0 || i >= this.Count)
            {
                throw new ArgumentOutOfRangeException();
            }
            return _arr.ElementAt(i);
        }
        set
        {
            if (i < 0 || i > this.Count)
            {
                throw new ArgumentOutOfRangeException();
            }
            if (i == Count)
            {
                _arr.Add(value);
                return;
            }
            _arr[i] = value;
        }
    }
    // public static  IntList operator []
    // 3) Реализуйте индексатор this[int index] с семантикой, описанной выше.
    // 4) Добавьте конструктор(ы) при необходимости.
    // Примечание: сейчас код преднамеренно пустой — требуется самостоятельная реализация.
}
