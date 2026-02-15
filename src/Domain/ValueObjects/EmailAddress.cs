namespace Domain.ValueObjects;

public class Email
{
    public int EmailAddressID { get; set; }
    public int BusinessEntityID { get; set; }
    public string EmailAddress { get; set; } = string.Empty;
    public Guid Rowguid { get; set; }
    public DateTime ModifiedDate { get; set; }

   public Email(int emailAddressID, int businessEntityID, string emailAddress, Guid rowguid, DateTime modifiedDate)
    {
        if (emailAddressID <= 0)
        {
            throw new ArgumentException("EmailAddressID must be greater than zero.");
        }
        if (businessEntityID <= 0)
        {
            throw new ArgumentException("BusinessEntityID must be greater than zero.");
        }
        if (string.IsNullOrWhiteSpace(emailAddress))
        {
            throw new ArgumentException("EmailAddress is required.");
        }

        EmailAddressID = emailAddressID;
        BusinessEntityID = businessEntityID;
        EmailAddress = emailAddress;
        Rowguid = rowguid;
        ModifiedDate = modifiedDate;
    }
}