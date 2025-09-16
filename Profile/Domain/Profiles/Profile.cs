namespace Profile.Domain.Profiles;

public sealed class Profile
{
    public Guid Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public string FullName => FirstName + LastName;
    
    public short Age { get; set; }
    
    public string CellPhone { get; set; }
    public string Phone { get; set; }
    
    
    public string Address { get; set; }
    public string Email { get; set; }
    
    public string ProfilePictureUrl { get; set; }
    
    public string EncryptedData { get; set; }
}