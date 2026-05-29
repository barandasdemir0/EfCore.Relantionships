using System.Text.Json.Serialization;

namespace EfCore.Relantionships.Models;

public sealed class UserInformation
{
    public UserInformation()
    {
        Id = Guid.CreateVersion7();
    }
    public Guid Id { get; set; } //kendi primary keyi
    public Guid UserId { get; set; } //foreign key

    //navigation property 
    [JsonIgnore]//Circular reference engellemek
    public User? User { get; set; }//users tablosuna git diyoruz
    public string IdentityNumber { get; set; } = default!;
    public string FullAddress { get; set; } = default!;
}
