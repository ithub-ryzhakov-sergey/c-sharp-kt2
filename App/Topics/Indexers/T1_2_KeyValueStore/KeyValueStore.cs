namespace App.Topics.Indexers.T1_1_IntList;

public class IntList
{
    private int[] _items;
    private int _count;

    public IntList()
    {
        _items = new int[4]; // Начальная емкость
        _count = 0;
    }

    public IntList(int initialCapacity)
    {
        if (initialCapacity < 0)
            throw new ArgumentOutOfRangeException(nameof(initialCapacity), "Capacity cannot be negative");

        _items = new int[initialCapacity];
        _count = 0;
    }

    public int Count => _count;

    public int this[int index]
    {
        get
        {
            if (index < 0 || index >= _count)
                throw new ArgumentOutOfRangeException(nameof(index),
                    $"Index {index} is out of range. Valid range is [0, {_count - 1}]");

            return _items[index];
        }
        set
        {
            if (index < 0 || index > _count)
                throw new ArgumentOutOfRangeException(nameof(index),
                    $"Index {index} is out of range. Valid range is [0, {_count}]");

            if (index == _count)
            {
                // Добавление нового элемента в конец
                EnsureCapacity(_count + 1);
                _items[_count] = value;
                _count++;
            }
            else
            {
                // Замена существующего элемента
                _items[index] = value;
            }
        }
    }

    private void EnsureCapacity(int requiredCapacity)
    {
        if (_items.Length >= requiredCapacity)
            return;

        int newCapacity = Math.Max(_items.Length * 2, requiredCapacity);
        int[] newArray = new int[newCapacity];
        Array.Copy(_items, newArray, _count);
        _items = newArray;
    }

    // Дополнительный метод для удобства добавления элементов
    public void Add(int item)
    {
        this[_count] = item;
    }

    // Дополнительный метод для очистки списка
    public void Clear()
    {
        _count = 0;
    }
}