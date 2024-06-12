public class LinqTests
{
    [Fact]
    public void find_numbers_higher_than_15_in_list_of_ints()
    {
        var list = new List<int>() { 1, 2, 3, 16, 17, 18, 19, 1, 2 };
        var higherThan15 = new List<int>();


        foreach (var number in list)
        {
            if (number > 15)
            {
                higherThan15.Add(number);
                continue;
            }
        }

        Assert.Equal(4, higherThan15.Count);
    }

    [Fact]
    public void linq_finder()
    {
        var list = new List<int>() { 1, 2, 3, 16, 17, 18, 19, 1, 2, };

        var higherThan15 = list.FindAll(x => x > 15);

        Assert.Equal(4, higherThan15.Count);

    }
}