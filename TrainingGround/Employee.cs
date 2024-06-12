public class Employee : Person, IPrintable
{
    public List<Address> Addresses { get; set; }

    public string? EmployeeId { get; set; }

    public Employee()
    {

    }
    public Employee(string name, string employeeId) : base(name)
    {
        EmployeeId = employeeId;
        Addresses = new List<Address>();
    }

    public string GetPrintString()
    {
        return @$"{Name} ({EmployeeId})
        {this.Address.Street} {this.Address.StreetNo}
        {this.Address.City}";
    }

}

