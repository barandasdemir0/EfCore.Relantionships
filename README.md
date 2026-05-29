# EfCore.Relantionships

EF Core ile modern ilişkisel veritabanı tasarımlarını anlatan, **One-to-One**, **One-to-Many** ve **Many-to-Many** ilişkilerin .NET üzerindeki kullanımını pratik olarak gösteren bir eğitim projesidir.

Bu projede özellikle **One-to-One ilişki**, **navigation property kullanımı**, **include/join sorguları**, **DTO ile veri oluşturma** ve **global exception handling** örnekleri yer almaktadır.

## Özellikler

- EF Core ile ilişki yapılandırmaları
- One-to-One ilişki örneği
- Navigation property kullanımı
- `Include`, `Join` ve `From` ile veri okuma örnekleri
- DTO ile kullanıcı oluşturma
- Global exception handling
- OData desteği
- OpenAPI ve Scalar arayüzü
- SQL Server entegrasyonu

## Kullanılan Teknolojiler

- .NET 10
- ASP.NET Core Web API
- Entity Framework Core
- Microsoft SQL Server
- OData
- Scalar.AspNetCore

## Proje Yapısı

- `Program.cs`  
  Uygulamanın başlangıç noktası, servis kayıtları, endpoint’ler ve API yapılandırmaları

- `Context/ApplicationDbContext.cs`  
  EF Core `DbContext` yapısı ve ilişki konfigürasyonları

- `Models/User.cs`  
  Kullanıcı modeli

- `Models/UserInformation.cs`  
  Kullanıcıya ait ek bilgiler modeli

- `Dtos/UserCreateDto.cs`  
  Kullanıcı oluşturma isteği için kullanılan DTO

- `ExceptionHandler.cs`  
  Merkezi hata yönetimi sınıfı

## Örnek Senaryo

Bu projede bir kullanıcı oluşturulurken şu yapı kullanılır:

- `User`
- `UserInformation`

Aralarında **One-to-One** ilişki kurulmuştur.  
`UserInformation` tablosu, `User` tablosuna `UserId` foreign key’i ile bağlıdır.

## Başlıca Endpoint’ler

- `POST /user-create`  
  Yeni kullanıcı ve kullanıcı bilgisi oluşturur

- `GET /userGetAll`  
  Kullanıcıları ilişkili bilgileriyle birlikte getirir

## Veritabanı İlişkisi

İlişki şu şekilde tanımlanmıştır:

- `User` -> `UserInformation`
- `HasOne(...)`
- `WithOne(...)`
- `HasForeignKey<UserInformation>(...)`
- `OnDelete(DeleteBehavior.Cascade)`



## Not

Bu proje öğrenme amaçlı hazırlanmıştır ve EF Core ilişki mantığını anlaşılır şekilde göstermek için sade tutulmuştur.
