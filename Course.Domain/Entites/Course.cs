using Course.Domain.Abstract;

namespace Course.Domain.Entites;

public class Course : IEntity
{
    public Course() { }
    public int Id { get; set; }
    public required string ImagePath { get; set; }
    public required string Mentor { get; set; }
    public TimeSpan Duration { get; set; }
    public double Price { get; set; }
    public List<string> RequiredSkills { get; set; } = [];
}
