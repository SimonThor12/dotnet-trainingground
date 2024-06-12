using TrainingGround;

public class ConditionalTests
{
    [Fact]
    public void should_be_kid_when_younger_than_18()
    {
        var Person = new Person(2005);
        var category = AgeCalculator.GetAgeCategory(Person, 2022);


        Assert.Equal(AgeCategory.Kid, category);
    }

    [Fact]
    public void should_be_adult_when_18_or_older()
    {
        var Person = new Person(2004);
        var category = AgeCalculator.GetAgeCategory(Person, 2022);

        Assert.Equal(AgeCategory.Adult, category);
    }

    [Fact]
    public void when_50_should_be_prime_age()
    {
        var Person = new Person(1972);
        var category = AgeCalculator.GetAgeCategory(Person, 2022);

        Assert.Equal(AgeCategory.Prime, category);
    }

    [Fact]
    public void under_18_for_kid()
    {
        var span = AgeCalculator.GetAgeSpan(AgeCategory.Kid);

        Assert.Equal("Under 18 years", span);
    }

}