public class TypesClass
{
    [Fact]
    public void getting_age_from_person()
    {

        var person = new Person(1972);
        var age = person.GetAge(2022);

        Assert.Equal(50, age);
        Assert.IsType<Person>(person);
        Assert.IsType<int>(age);
    }
}