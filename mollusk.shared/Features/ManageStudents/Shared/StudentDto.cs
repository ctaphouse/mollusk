using mollusk.shared.Features.ManageTeachers.Shared;

namespace mollusk.shared.Features.ManageStudents.Shared;

public class StudentDto
{
    public int Id { get; set; }
    public string FirstName { get; set; } = default!;
    public string LastName { get; set; } = default!;
    public int MajorId { get; set; }
    
    public ICollection<TeacherDto> Teachers { get; set; } = new List<TeacherDto>();

}