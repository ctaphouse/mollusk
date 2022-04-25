using MediatR;
using mollusk.shared.Features.ManageStudents.Shared;

namespace mollusk.shared.Features.ManageStudents.AddStudent;

public record AddStudentRequest(StudentDto Student) : IRequest<AddStudentRequest.Response>
{
    public const string RouteTemplate = "api/students";
    
    public record Response(int StudentId);
}