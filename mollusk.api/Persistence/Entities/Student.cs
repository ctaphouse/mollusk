namespace mollusk.api.Persistence.Entities;

public class Student
{
    public int Id { get; set; }
    public string FirstName { get; set; } = default!;
    public string LastName { get; set; } = default!;
    public int MajorId { get; set; }
    public Major Major { get; set; } = default!;
    public ICollection<Teacher> Teachers { get; set; } = new List<Teacher>();
}