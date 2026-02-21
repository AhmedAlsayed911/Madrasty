using AutoMapper;
using Madrasty.Core.Bases;
using Madrasty.Core.Features.Students.Queries.Models;
using Madrasty.Core.Features.Students.Results;
using Madrasty.Core.Wrappers;
using Madrasty.Domain.Entities;
using Madrasty.Service.Abstracts;
using MediatR;
using System.Linq.Expressions;

namespace Madrasty.Core.Features.Students.Queries.Handlers
{
    public class StudentQueryHandler(IStudentService studentService, IMapper mapper) : ResponseHandler
        , IRequestHandler<GetStudentListQuery, Response<List<StudentListResponse>>>
        , IRequestHandler<GetStudentByIdQuery, Response<SingleStudentResponse>>
        , IRequestHandler<GetStudentPaginatedListQuery, PaginatedResult<StudentPaginatedListResponse>>
    {
        public async Task<Response<List<StudentListResponse>>> Handle(GetStudentListQuery request, CancellationToken cancellationToken)
        {
            var studentList = await studentService.GetStudentsListAsync();
            var studentListMapper = mapper.Map<List<StudentListResponse>>(studentList);

            return Success(studentListMapper);
        }

        public async Task<Response<SingleStudentResponse>> Handle(GetStudentByIdQuery request, CancellationToken cancellationToken)
        {
            var student = await studentService.GetStudentByIdAsync(request.Id);
            var studentListResponse = mapper.Map<SingleStudentResponse>(student);

            if (student is null)
                return NotFound<SingleStudentResponse>("");

            return Success(studentListResponse);
        }

        public async Task<PaginatedResult<StudentPaginatedListResponse>> Handle(GetStudentPaginatedListQuery request, CancellationToken cancellationToken)
        {
            Expression<Func<Student, StudentPaginatedListResponse>> expression =
                e => new StudentPaginatedListResponse(e.StudID, e.Name, e.Address, e.Department.DName);

            var querableStudents = studentService.GetStudentsQueryable();
            var filteredQuery = studentService.FilterStudentPaginatedQuery(request.OrderBy, request.Search);
            var paginatedResult = await filteredQuery.Select(expression).ToPaginatedListAsync(request.PageNumber, request.PageSize);

            return paginatedResult;

        }
    }
}
