// Topic: Indexers — T1.2 KeyValueStore (overload by parameter type)
// Задача: реализовать класс со СВЯЗАННЫМИ индексаторами по int и string.
// Требования:
// - Индексатор this[int id] и this[string key] возвращают/устанавливают string значение.
// - get: если ключ/ид неизвестен — бросать KeyNotFoundException.
// - set: если ключ/ид отсутствует — добавить; если есть — заменить значение.
// - null-ключи/строки: при попытке доступа по null string — бросать ArgumentNullException.
// Примечание: цель — понять перегрузку индексаторов по разным типам параметров.

namespace App.Topics.Indexers.T1_2_KeyValueStore;

public class KeyValueStore
{
    private readonly Dictionary<int, string> digits = new();
    private readonly Dictionary<string, string> str = new();
    private int newID = 1;

    public string this[int id]
    {
        get
        {
            if (!this.digits.TryGetValue(id, out var value))
                throw new KeyNotFoundException();
            return value;
        }

        set
        {
            if (value == null)
                throw new ArgumentNullException(nameof(value));
            this.digits[id] = value;
        }
    }

    public string this[string key]
    {
        get
        {
            if (key == null)
                throw new ArgumentNullException(nameof(key));

            if (!this.str.TryGetValue(key, out var value))
                throw new KeyNotFoundException();
            return value;
        }

        set
        {
            if (key == null)
                throw new ArgumentNullException(nameof(key));
            if (value == null)
                throw new ArgumentNullException(nameof(value));
            this.str[key] = value;
        }
    }
}
