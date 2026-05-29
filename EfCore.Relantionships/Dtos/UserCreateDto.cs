namespace EfCore.Relantionships.Dtos;

public sealed record UserCreateDto(
    string FirstName,
    string LastName,
    string IdentityNumber,
    string FullAddress
    );
