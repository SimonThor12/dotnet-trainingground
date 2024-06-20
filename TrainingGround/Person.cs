using System.Net.Sockets;

public class Person : IPrintable
{
    public string? Name { get; private set; }
    public int BirthYear { get; private set; }
    public double LengthInMeters;
    public Address? Address { get; set; }

    public Person()
    {

    }
    public Person(string name)
    {

        this.Name = name;
    }

    public Person(int birthYear)
    {
        this.BirthYear = birthYear;
    }

    public int GetAge(int currentYear)
    {
        var age = currentYear - this.BirthYear;

        if (age < 0)
        {
            throw new Exception("Not born yet");
        }
        return age;
    }

    public string GetPrintString()
    {
        return @$"{Name}
        {this.Address!.Street} {this.Address.StreetNo}
        {this.Address.City}";
    }
}
