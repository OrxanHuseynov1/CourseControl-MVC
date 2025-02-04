using Course.Domain.Abstract;
using Course.Domain.Enums;

namespace Course.Domain.Entites;

public class Book : IEntity
{

    public int Id { get; set; }
    public required string ImagePath { get; set; }
    public required string Author { get; set; }
    public required Genre Genre{ get; set; }
    public int PagesCount{ get; set; }
    public List<User> ReadUsers { get; set; } = [];
    public required string Description { get; set; }
}
