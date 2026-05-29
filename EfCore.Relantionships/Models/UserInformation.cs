namespace EfCore.Relantionships.Models;

public sealed class UserInformation
{
    public Guid Id { get; set; }
    public Guid UserId { get; set; }
    public string IdentityNumber { get; set; } = default!;
    public string FullAddress { get; set; } = default!;
}
