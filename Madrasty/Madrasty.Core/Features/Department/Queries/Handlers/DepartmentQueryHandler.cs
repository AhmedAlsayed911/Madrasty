using AutoMapper;
using Madrasty.Core.Bases;
using Madrasty.Core.Features.Department.Queries.Models;
using Madrasty.Core.Features.Department.Queries.Results;
using Madrasty.Core.Wrappers;
using Madrasty.Domain.Entities;
using Madrasty.Service.Abstracts;
using MediatR;
using System.Linq.Expressions;

namespace Madrasty.Core.Features.Department.Queries.Handlers
{
    public class DepartmentQueryHandler(IDepartmentService departmentService, IMapper mapper, IStudentService studentService)
        : ResponseHandler
        , IRequestHandler<GetDepartmentByIdQuery, Response<GetDepartmentByIdResponse>>
    {
        public async Task<Response<GetDepartmentByIdResponse>> Handle(GetDepartmentByIdQuery request, CancellationToken cancellationToken)
        {
            var response = await departmentService.GetDepartmentByid(request.Id);
            if (response is null)
                return NotFound<GetDepartmentByIdResponse>();

            var mappedResult = mapper.Map<GetDepartmentByIdResponse>(response);

            Expression<Func<Student, StudentResponse>> expression = e => new StudentResponse(e.StudID, e.Name);

            var studentsQueryable = studentService.GetStudentsByDepartmentIdQueryable(request.Id);
            var paginatedList = await studentsQueryable.Select(expression).ToPaginatedListAsync(request.StudentsPageNumber, request.StudentsPageSize);

            mappedResult.StudentsList = paginatedList;
            return Success(mappedResult);
        }
    }
}
