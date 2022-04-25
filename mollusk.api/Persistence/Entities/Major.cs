namespace mollusk.api.Persistence.Entities;

public class Major
{
    public int Id { get; set; }
    public string Name { get; set; } = default!;

    public ICollection<Student> Students { get; set; } = new List<Student>();
}