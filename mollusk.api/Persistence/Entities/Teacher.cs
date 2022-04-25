namespace mollusk.api.Persistence.Entities;

public class Teacher
{
    public int Id { get; set; }
    public string FirstName { get; set; } = default!;
    public string LastName { get; set; } = default!;
    public ICollection<Student> Students { get; set; } = new List<Student>();
}