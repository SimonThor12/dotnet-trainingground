public class LoopTests
{
    [Fact]
    public void while_loop()
    {

        int[] arr = new int[] { 1, 2, 3, 4, 5 };

        var i = 0;

        while (i < arr.Length)
        {

            Console.WriteLine($"i is now {i}");
            Assert.Equal(arr[i], i + 1);
            i++;
        }

    }

    [Fact]
    public void for_loop()
    {
        int[] arr = new int[] { 1, 2, 3, 4, 5 };

        for (int i = 0; i < arr.Length; i++)
        {
            Assert.Equal(arr[i], i + 1);
        }

    }

    [Fact]
    public void foreach_loop()
    {
        int[] arr = new int[] { 1, 2, 3, 4, 5 };

        foreach (int i in arr)
        {
            Assert.Equal((int)i, i);
        }

    }

    [Fact]
    public void address_list_loop()
    {
        var addressList = new List<Address>();
        Address add1 = new Address() { Street = "Kungsgatan", StreetNo = 1 };
        Address add2 = new Address() { Street = "Kungsgatan", StreetNo = 2 };
        Address add3 = new Address() { Street = "Kungsgatan", StreetNo = 3 };
        addressList.Add(add1);
        addressList.Add(add2);
        addressList.Add(add3);

        var i = 0;

        foreach (Address address in addressList)
        {
            Assert.Equal(address.StreetNo, i + 1);
            Assert.IsType<Address>(address);
            i++;
        }

    }
}