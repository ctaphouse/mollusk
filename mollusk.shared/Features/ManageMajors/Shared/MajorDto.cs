using mollusk.shared.Features.ManageStudents.Shared;

namespace mollusk.shared.Features.ManageMajors.Shared;

public class MajorDto
{
    public int Id { get; set; }
    public string Name { get; set; } = default!;
    public ICollection<StudentDto> Students { get; set; } = new List<StudentDto>();
}