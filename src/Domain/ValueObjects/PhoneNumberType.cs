namespace Domain.ValueObjects;

public class PhoneNumberType
{
    public int PhoneNumberTypeID { get; set; }
    public string Name { get; set; } = string.Empty;
    public DateTime ModifiedDate { get; set; }
}