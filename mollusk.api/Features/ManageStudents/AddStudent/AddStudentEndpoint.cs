using Ardalis.ApiEndpoints;
using Microsoft.AspNetCore.Mvc;
using mollusk.api.Persistence;
using mollusk.api.Persistence.Entities;
using mollusk.shared.Features.ManageStudents.AddStudent;

namespace mollusk.api.Features.ManageStudents.AddStudent;

public class AddStudentEndpoint : EndpointBaseAsync.WithRequest<AddStudentRequest>.WithActionResult<AddStudentRequest.Response>
{
    private readonly MolluskContext _context;

    public AddStudentEndpoint(MolluskContext context)
    {
        _context = context;
    }
    
    [HttpPost(AddStudentRequest.RouteTemplate)]
    public override async Task<ActionResult<AddStudentRequest.Response>> HandleAsync(AddStudentRequest request, CancellationToken cancellationToken = default)
    {
        var student = new Student
        {
            Id = request.Student.Id,
            FirstName = request.Student.FirstName,
            LastName = request.Student.LastName,
            MajorId = request.Student.MajorId
        };

        await _context.AddAsync(student);

        var teachers = request.Student.Teachers.Select(t => new Teacher
        {
            Id = t.Id,
            FirstName = t.FirstName,
            LastName = t.LastName,
            Students = new List<Student> {student}
        });

        await _context.AddRangeAsync(teachers);

        await _context.SaveChangesAsync(cancellationToken: cancellationToken);

        return Ok(student.Id);
    }
}