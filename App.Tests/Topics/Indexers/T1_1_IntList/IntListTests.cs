using App.Topics.Indexers.T1_1_IntList;
using NUnit.Framework;

namespace App.Tests.Topics.Indexers.T1_1_IntList;

public class IntListTests
{
    [Test]
    public void Count_InitiallyZero()
    {
        var list = new IntList();
        Assert.That(list.Count, Is.EqualTo(0));
    }

    [Test]
    public void Set_AtCount_Appends()
    {
        var list = new IntList();
        list[0] = 10; // append first
        list[1] = 20; // append second
        Assert.Multiple(() =>
        {
            Assert.That(list.Count, Is.EqualTo(2));
            Assert.That(list[0], Is.EqualTo(10));
            Assert.That(list[1], Is.EqualTo(20));
        });
    }

    [Test]
    public void Set_WithinRange_Replaces()
    {
        var list = new IntList();
        list[0] = 1;
        list[1] = 2;
        list[0] = 42;
        Assert.That(list[0], Is.EqualTo(42));
        Assert.That(list[1], Is.EqualTo(2));
    }

    [Test]
    public void Get_OutOfRange_Throws()
    {
        var list = new IntList();
        Assert.Throws<ArgumentOutOfRangeException>(() => { var _ = list[0]; });
    }

    [Test]
    public void Set_IndexGreaterThanCount_Throws()
    {
        var list = new IntList();
        Assert.Throws<ArgumentOutOfRangeException>(() => list[2] = 1);
    }

    [Test]
    public void NegativeIndex_Throws()
    {
        var list = new IntList();
        Assert.Throws<ArgumentOutOfRangeException>(() => { var _ = list[-1]; });
        Assert.Throws<ArgumentOutOfRangeException>(() => list[-1] = 10);
    }
}
