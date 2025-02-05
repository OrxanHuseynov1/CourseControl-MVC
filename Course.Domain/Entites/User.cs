using Course.Domain.Abstract;

namespace Course.Domain.Entites;

public class User : IEntity
{
    public int Id { get; set; }
    public string? ImagePath { get; set; }
    public string? Name { get; set; }
    public string? Surname { get; set; }
    public DateTime Birthday { get; set; }
    public string? Speciality { get; set; }
    public List<Book> ReadBooks { get; set; } = [];

}
