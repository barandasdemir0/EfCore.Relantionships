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
}
