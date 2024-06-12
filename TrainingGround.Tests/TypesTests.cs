
public class TypesTests
{
    [Fact]
    public void reference_types_can_be_changed_via_reference()
    {
        //arrange 
        var person = new Person("Person A");
        person.LengthInMeters = 1.95;
        Person b = person;

        //act
        b.LengthInMeters = 1.85;

        //assert
        Assert.Equal(1.85, person.LengthInMeters);
        Assert.Equal(1.85, person.LengthInMeters);
    }
}