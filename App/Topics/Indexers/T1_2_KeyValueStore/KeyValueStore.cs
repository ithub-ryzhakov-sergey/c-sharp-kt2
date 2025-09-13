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
    // Студенту:
    Dictionary<int, string> _intArr = new Dictionary<int, string> {};
    Dictionary<string, string> _strArr = new Dictionary<string, string> {};
    public string this[int i]
    {
        get
        {
            if (!_intArr.ContainsKey(i))
            {
                throw new KeyNotFoundException();
            }
            string res;
            this._intArr.TryGetValue(i, out res);
            return res;
        }
        set
        {
            this._intArr[i] = value;
        }
    }
    public string this[string i]
    {
        get
        {
            string res;
            _strArr.TryGetValue(i, out res);
            if (res == null)
            {
                throw new KeyNotFoundException();
            }
            return res;
        }
        set
        {
            this._strArr[i] = value;
        }
    }
    // 1) Добавьте внутренние структуры данных (например, два словаря: по int и по string).
    // 2) Реализуйте перегруженные индексаторы this[int id] и this[string key].
    // 3) Соблюдайте требования к исключениям (KeyNotFoundException, ArgumentNullException).
    // 4) Добавьте дополнительные члены по необходимости.
}
