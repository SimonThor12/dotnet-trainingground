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
        var list = new List<int>() { 2, 3, 16, 17, 18, 19, 1, 2, 17 };

        var higherThan15 = list.FindAll(x => x > 15);

        Assert.Equal(5, higherThan15.Count);

        var sortedListA = list.OrderBy(x => x).ToList();
        var sortedListD = list.OrderByDescending(x => x).ToList();

        Assert.Equal(1, sortedListA[0]);
        Assert.Equal(19, sortedListD[0]);

    }

    [Fact]
    public void linq_find()
    {
        var list = new List<int>() { 1, 2, 3, 16, 17, 18, 19, 1, 2, 17 };

        var higherThan15 = list.Find(x => x > 15);

        Assert.Equal(16, higherThan15);

    }

    [Fact]
    public void linq_to_check_if_any_matches()
    {
        var list = new List<int>() { 1, 2, 3, 16, 17, 18, 19, 1, 2, 17 };

        var anyEqual2 = list.Any(x => x == 2);

        Assert.True(anyEqual2);
    }

    [Fact]
    public void linq_check_all_positive()
    {
        var list = new List<int>() { 1, 2, 3, 16, 17, 18, 19, 1, 2, 17 };

        var isPositive = list.All(x => x > 0);

        Assert.True(isPositive);
    }

    [Fact]
    public void linq_where_name_is_more_than_4_chars()
    {
        var list = new List<Person>() { new Person("Aaaron"), new Person("Dave"), new Person("Bea"), new Person("Ceasar") };

        var moreThan4Chars = list.Where(x => x.Name!.Length > 4).ToList();

        Assert.Equal(2, moreThan4Chars.Count);
        Assert.Equal("Aaaron", moreThan4Chars[0].Name);
    }

    [Fact]
    public void linq_get_only_names()
    {

        var list = new List<Person>() { new Person("Aaaron"), new Person("Dave"), new Person("Bea"), new Person("Ceasar") };

        var listOfNamesMoreThan4 = list.Where(x => x.Name.Length > 4).Select(x => x.Name).ToList();

        Assert.Equal(2, listOfNamesMoreThan4.Count);
        Assert.Equal("Aaaron", listOfNamesMoreThan4[0]);
        Assert.Equal("Ceasar", listOfNamesMoreThan4[1]);
    }


}