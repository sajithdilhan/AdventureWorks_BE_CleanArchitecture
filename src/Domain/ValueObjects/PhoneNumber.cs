namespace Domain.ValueObjects;

public class Phone
{
    public int BusinessEntityID { get; set; }
    public int PhoneNumberTypeID { get; set; }
    public string PhoneNumber { get; set; } = string.Empty;
    public DateTime ModifiedDate { get; set; }
    public virtual PhoneNumberType? PhoneNumberType { get; set; } = null!;

    public Phone(int businessEntityID, int phoneNumberTypeID, string phoneNumber, DateTime modifiedDate)
    {
        if (businessEntityID <= 0)
        {
            throw new ArgumentException("BusinessEntityID must be greater than zero.");
        }
        if (phoneNumberTypeID <= 0)
        {
            throw new ArgumentException("PhoneNumberTypeID must be greater than zero.");
        }
        if (string.IsNullOrWhiteSpace(phoneNumber))
        {
            throw new ArgumentException("PhoneNumber is required.");
        }
        BusinessEntityID = businessEntityID;
        PhoneNumberTypeID = phoneNumberTypeID;
        PhoneNumber = phoneNumber;
        ModifiedDate = modifiedDate;
    }
}