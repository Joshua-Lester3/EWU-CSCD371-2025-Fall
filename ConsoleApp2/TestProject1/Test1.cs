namespace TestProject1;

[TestClass]
public class Test1
{
    [TestMethod]
    public void TestMethod1()
    {
        IEnumerable<int> numbers = new List<int>()
        {
            5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18
        };

        numbers = numbers.Where(number => number % 2 == 0);

        Assert.AreEqual(7, numbers.Count());
        foreach (int number in numbers)
        {
            Assert.AreEqual(0, number % 2);
        }

        Assert.IsFalse(numbers.Any(number => number % 2 == 0));
    }
}
