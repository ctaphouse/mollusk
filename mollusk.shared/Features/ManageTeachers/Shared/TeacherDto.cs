using mollusk.shared.Features.ManageStudents.Shared;

namespace mollusk.shared.Features.ManageTeachers.Shared;

public class TeacherDto
{
    public int Id { get; set; }
    public string FirstName { get; set; } = default!;
    public string LastName { get; set; } = default!;
    public ICollection<StudentDto> Students { get; set; } = new List<StudentDto>();

}