//using Domain.Enums;
//using Domain.Exceptions;
//using Domain.ValueObjects;

//namespace Domain.Entities;

//public class Person
//{
//    public int BusinessEntityID { get; }
//    public string PersonType { get; } = string.Empty;
//    public bool NameStyle { get; }
//    public string? Title { get; }
//    public string FirstName { get; } = string.Empty;
//    public string? MiddleName { get; }
//    public string LastName { get; } = string.Empty;
//    public string? Suffix { get; }
//    public string? Gender { get; set; }
//    public int EmailPromotion { get; set; }
//    public string? AdditionalContactInfo { get; set; }
//    public string? Demographics { get; set; }
//    public Guid Rowguid { get; set; }
//    public DateTime ModifiedDate { get; set; }

//    public virtual ICollection<Email> EmailAddresses { get; set; } = [];
//    public virtual ICollection<Phone> PersonPhones { get; set; } = [];

//    public Person()
//    {
        
//    }

//    public Person(int businessEntityID, string personType, bool nameStyle, string? title, string firstName, string? middleName, string lastName, string? suffix)
//    {
//        if (businessEntityID <= 0)
//        {
//            throw new DomainException("BusinessEntityID must be greater than zero.", DomainExceptionCodes.InvalidInput);
//        }

//        BusinessEntityID = businessEntityID;
//        PersonType = personType ?? throw new DomainException("PersonType is required.", DomainExceptionCodes.InvalidInput);
//        NameStyle = nameStyle;
//        Title = title;
//        FirstName = firstName ?? throw new DomainException("FirstName is required.", DomainExceptionCodes.InvalidInput);
//        MiddleName = middleName;
//        LastName = lastName ?? throw new DomainException("LastName is required.", DomainExceptionCodes.InvalidInput);
//        Suffix = suffix;
//    }
//}
