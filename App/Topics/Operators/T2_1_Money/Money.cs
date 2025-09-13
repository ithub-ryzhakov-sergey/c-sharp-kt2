// Topic: Operators — T2.1 Money (==, !=, Equals/GetHashCode)
// Задача: реализовать value object для денег.
// Требования:
// - Поля: string Currency (например, "RUB", "USD"), long Amount (в минимальных единицах: копейки/центы).
// - Конструктор Money(string currency, long amount) — должен проверять currency на null/пустую строку.
// - Реализовать IEquatable<Money>, переопределить Equals(object), GetHashCode, операторы == и !=.
// - Деньги равны только если совпадают и валюта, и сумма.
// Подсказка: подумайте о нормализации регистра Currency (например, ToUpperInvariant) — оговорено в тестах.

namespace App.Topics.Operators.T2_1_Money;

public struct Money // : IEquatable<Money>
{
    // Студенту:
    // 1) Реализуйте неизменяемую структуру с полями/свойствами Currency и Amount.
    // 2) Добавьте конструктор с валидацией currency.
    // 3) Перегрузите операторы == и != в соответствии с требованиями.
    // Примечание: исходно код преднамеренно пустой — необходимо выполнить реализацию.
}
