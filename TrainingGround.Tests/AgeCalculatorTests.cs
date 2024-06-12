namespace TrainingGround.Tests;

public class AgeCalculatorTests
{
    public AgeCalculatorTests()
    {
    }

    [Fact]
    public void someone_born_1972_is_50_in_2022()
    {

        var age = AgeCalculator.GetAge(1972, 2022);

        Assert.Equal(50, age);

    }

    [Fact]
    public void someone_born_in_2022_is_0_in_2022()
    {


        var age = AgeCalculator.GetAge(2022, 2022);

        Assert.Equal(0, age);
    }
}