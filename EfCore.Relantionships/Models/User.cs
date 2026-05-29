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
    //public Guid UserInformationId { get; set; } //tablo adı + Id EF bunu otomatik olarak algılar

    //vabigation property üstteki id alttaki kodla bağlı olacak
    public UserInformation? UserInformation { get; set; } //--> null gelebilir bu sebeple ? attık
}
