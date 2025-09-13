// Topic: Operators — T2.2 VersionLite (relational operators)
// Задача: реализовать сравнение версий по лексикографическому порядку: (Major, Minor, Patch).
// Требования:
// - Публичные только для чтения свойства: int Major, Minor, Patch; задать через конструктор.
// - Реализовать IComparable<VersionLite> и операторы <, >, <=, >=.
// - Сравнение: сначала Major, затем Minor, затем Patch.
// - Конструктор должен проверять, что значения не отрицательные; иначе ArgumentOutOfRangeException.

namespace App.Topics.Operators.T2_2_VersionLite;

public class VersionLite // : IComparable<VersionLite>
{
    // Студенту:
    // 1) Реализуйте конструктор и только для чтения свойства Major, Minor, Patch.
    // 2) Реализуйте сравнение (IComparable<VersionLite>) и операторы <, >, <=, >= как лексикографическое.
    // 3) Учтите проверку на отрицательные значения в конструкторе.
}
