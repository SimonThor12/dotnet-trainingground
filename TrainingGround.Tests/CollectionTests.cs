public class CollectionTests
{
    [Fact]
    public void an_array_has_a_length()
    {
        var arrOfInts = new int[5];
        var arrWithValues = new int[] { 1, 2, 3 };
        var arrWithStrings = new string[] { "Name 1", "Name 2" };

        Assert.Equal(5, arrOfInts.Length);
        Assert.Equal(3, arrWithValues.Length);
        Assert.Equal(2, arrWithStrings.Length);
    }

    [Fact]
    public void getting_stuff_out()
    {
        var arrOfStrings = new string[] { "fisk", "ananas" };
        Assert.Equal("fisk", arrOfStrings[0]);
        Assert.Equal("ananas", arrOfStrings[1]);

    }

    [Fact]
    public void a_list_of_ints_is_flexible()
    {

        List<int> values = new List<int>();

        values.Add(1);
        values.Add(2);
        values.Add(3);

        values.RemoveAt(0);

        Assert.Equal(2, values.Count);
        Assert.Equal(2, values[0]);
        Assert.Equal(3, values[1]);
    }

    [Fact]
    public void a_list_can_hold_anything()
    {
        var intList = new List<int>();
        var stringList = new List<string>();
        var addressList = new List<Address>();

        intList.Add(1); intList.Add(2); intList.Add(3);
        stringList.Add("fisk"); stringList.Add("ost"); stringList.Add("ananas");
        addressList.Add(new Address() { Street = "Gatan", StreetNo = 1 });
        addressList.Add(new Address() { Street = "Gatan", StreetNo = 2 });
        addressList.Add(new Address() { Street = "Styket", StreetNo = 2 });

        Assert.IsType<int>(intList[0]);
        Assert.IsType<string>(stringList[1]);
        Assert.IsType<Address>(addressList[1]);
        Assert.IsNotType<int>(addressList[2]);
    }

    [Fact]
    public void an_employee_have_more_than_one_address()
    {
        // arrange
        var emp = new Employee("Marcus", "DBCSAS-1253");

        // act
        emp.Addresses.Add(new Address() { Street = "Work street", StreetNo = 2, City = "Stockholm" });
        emp.Addresses.Add(new Address() { Street = "Vacation street", StreetNo = 2, City = "Honolulu" });

        // assert
        Assert.Equal(2, emp.Addresses.Count);
    }
}