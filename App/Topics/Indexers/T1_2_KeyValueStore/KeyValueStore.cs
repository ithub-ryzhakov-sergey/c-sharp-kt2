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
    // 1) Добавьте внутренние структуры данных (например, два словаря: по int и по string).
    // 2) Реализуйте перегруженные индексаторы this[int id] и this[string key].
    // 3) Соблюдайте требования к исключениям (KeyNotFoundException, ArgumentNullException).
    // 4) Добавьте дополнительные члены по необходимости.
}
