using Course.Domain.Abstract;

namespace Course.Domain.Entites;

public class Course : IEntity
{
    public int Id { get; set; } 
    public string? ImagePath { get; set; }
    public string? Mentor { get; set; }
    public TimeSpan Duration { get; set; }
    public double Price { get; set; }
    public List<string> RequiredSkills { get; set; } = [];
}
