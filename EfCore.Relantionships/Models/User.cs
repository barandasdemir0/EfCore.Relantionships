using System.Text.Json.Serialization;

namespace EfCore.Relantionships.Models;

public sealed class User
{
    public User()
    {
        Id = Guid.CreateVersion7();
    }
    public Guid Id { get; set; }
    public string FirstName { get; set; } = default!;
    public string Lastname { get; set; } = default!;
    public string FullName => string.Join(" ", FirstName, Lastname);

    public object Information => new
    {
        InfoId = UserInformation?.Id,
        IdentityNumber = UserInformation?.IdentityNumber,
        FullAddress = UserInformation?.FullAddress
    };

    //navigation property  yani bu yazımla beraber userınformatin bilgilerine erişebiliyoruz
    [JsonIgnore]//Circular reference engellemek
    public UserInformation? UserInformation { get; set; } //--> null gelebilir bu sebeple ? attık
}
