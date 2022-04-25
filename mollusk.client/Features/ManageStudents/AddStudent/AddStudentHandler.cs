using MediatR;
using mollusk.shared.Features.ManageStudents.AddStudent;
using System.Net.Http.Json;

namespace mollusk.client.Features.ManageStudents.AddStudent;

public class AddStudentHandler : IRequestHandler<AddStudentRequest, AddStudentRequest.Response>
{
    private readonly HttpClient _httpClient;

    public AddStudentHandler(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }
    public Task<AddStudentRequest.Response> Handle(AddStudentRequest request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
