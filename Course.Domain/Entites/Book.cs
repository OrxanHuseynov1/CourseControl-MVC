using Course.Domain.Abstract;
using Course.Domain.Enums;

namespace Course.Domain.Entites;

public class Book : IEntity
{

    public int Id { get; set; }
    public string? ImagePath { get; set; }
    public string? Author { get; set; }
    public Genre Genre{ get; set; }
    public int PagesCount{ get; set; }
    public List<User> ReadUsers { get; set; } = [];
    public string? Description { get; set; }
}
