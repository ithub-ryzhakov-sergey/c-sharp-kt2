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
    // Студенту:
    // 1) Добавьте приватное хранилище (например, List<int> или массив с расширением).
    // 2) Реализуйте свойство Count.
    // 3) Реализуйте индексатор this[int index] с семантикой, описанной выше.
    // 4) Добавьте конструктор(ы) при необходимости.
    // Примечание: сейчас код преднамеренно пустой — требуется самостоятельная реализация.

    private List<int> lst;
    private int count;

    public IntList()
    {
        this.lst = new List<int>();
        this.count = 0;
    }

    public IntList(int digits)
    {
        if (digits < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(digits), "digits no -");
        }

        this.lst = new List<int>(capacity: digits);
        this.count = 0;
    }

    public int Count => this.count;

    public int this[int index]
    {
        get
        {
            if ((index < 0) || (index >= this.count))
                throw new ArgumentOutOfRangeException(nameof(index), "нет в диапазоне");
            return this.lst[index];
            
        }

        set
        {
            if ((index < 0) || (index > this.count))
                throw new ArgumentOutOfRangeException(nameof(index), "нет в диапазоне");

            if (index == count)
            {
                this.lst.Add(value);
                count++;
            }
            else
            {
                this.lst[index] = value;
            }
        }                       
    }
    
}
