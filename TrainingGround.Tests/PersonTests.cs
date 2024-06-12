using System.Net.Sockets;

public class PersonTests
{
    [Fact]
    public void an_employee_gets_a_nice_printed_address()
    {
        var employee = new Employee("Stefan", "1234");
        employee.Address = new Address
        {
            Street = "Kungsgatan",
            StreetNo = 1,
            City = "Stockholm"
        };

        var printString = employee.GetPrintString();
        Assert.Equal(@"Stefan (1234)
        Kungsgatan 1
        Stockholm", printString);
    }
    [Fact]
    public void person_has_an_adress()
    {
        var person = new Person();
        person.Address = new Address
        {
            Street = "Kungsgatan",
            StreetNo = 1,
            City = "Stockholm"
        };

        Assert.NotNull(person.Address);
        Assert.IsType<Address>(person.Address);
        Assert.Equal("Kungsgatan", person.Address.Street);
        Assert.Equal(1, person.Address.StreetNo);
        Assert.Equal("Stockholm", person.Address.City);

    }
    [Fact]
    public void an_employee_is_a_person()
    {
        var employee = new Employee();
        employee.LengthInMeters = 1.95;
        Assert.Equal(1.95, employee.LengthInMeters);
    }

    [Fact]
    public void an_employee_has_a_employeeId()
    {
        var employee = new Employee("Stefan", "1234");

        Assert.IsType<Employee>(employee);
        Assert.Equal("Stefan", employee.Name);
        Assert.Equal("1234", employee.EmployeeId);
    }

    [Fact]
    public void create_person_using_parameterless_constructor()
    {
        var person = new Person();
        Assert.NotNull(person);
    }
    [Fact]
    public void create_person_using_name_constructor()
    {
        var person = new Person("Stefan");
        Assert.Equal("Stefan", person.Name);
    }

    [Theory]
    [InlineData(1972, 2022, 50)]
    [InlineData(1982, 2022, 40)]
    [InlineData(1992, 2022, 30)]
    [InlineData(2022, 2022, 0)]
    public void a_person_born_in_x_is_y_years_old_in_z(int birthYear, int currentYear, int expectedAge)
    {
        var person = new Person(birthYear);
        var age = person.GetAge(currentYear);
        Assert.Equal(expectedAge, age);
    }

    [Fact]
    public void can_print_printables()
    {
        var person = new Person("Stefan");
        person.Address = new Address
        {
            Street = "Kungsgatan",
            StreetNo = 1,
            City = "Stockholm"
        };
        var employee = new Employee("Ossian", "1234");

        employee.Address = new Address
        {
            Street = "Hornsgatan",
            StreetNo = 2,
            City = "Stockholm"
        };

        Print(person);
        Print(employee);

    }

    static void Print(IPrintable printable)
    {
        var printString = printable.GetPrintString();
        Console.WriteLine(printString);
    }

}