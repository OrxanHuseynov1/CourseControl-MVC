using Course.Domain.Abstract;

namespace Course.Domain.Entites;

public class User : IEntity
{
    public int Id { get; set; }
    public required string ImagePath { get; set; }
    public required string Name { get; set; }
    public required string Surname { get; set; }
    public required DateTime Birthday { get; set; }
    public required string Speciality { get; set; }
    public List<Book> ReadBooks { get; set; } = [];

}
