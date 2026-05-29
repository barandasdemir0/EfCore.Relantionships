namespace EfCore.Relantionships.Models;

public sealed class UserInformation
{
    public UserInformation()
    {
        Id = Guid.CreateVersion7();
    }
    public Guid Id { get; set; }
    public Guid UserId { get; set; }

    //navigation property
    public User? User { get; set; }
    public string IdentityNumber { get; set; } = default!;
    public string FullAddress { get; set; } = default!;
}
