using System.Linq.Expressions;

public class ExceptionTests
{

    [Fact]
    public void not_handling_exception()
    {
        try
        {
            var i = 1;

            var div = 14 / (i - 1);

        }

        catch (DivideByZeroException ex)
        {

            Assert.IsType<DivideByZeroException>(ex);

        }

    }

    [Fact]
    public void get_age_from_person()
    {
        try
        {

            var person = new Person(2023);

            var age = person.GetAge(2022);

            Assert.Equal(0, age);
        }
        catch(Exception ex) {
            Assert.Equal("Not born yet", ex.Message);
            return;
        }
        Assert.True(false, "Exception didn't happen");

    }
}