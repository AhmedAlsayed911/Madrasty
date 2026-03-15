using Madrasty.Core.Bases;
using Madrasty.Core.Features.Department.Queries.Results;
using MediatR;

namespace Madrasty.Core.Features.Department.Queries.Models
{
    public class GetDepartmentByIdQuery : IRequest<Response<GetDepartmentByIdResponse>>
    {
        public int Id { get; set; }
        public int StudentsPageNumber { get; set; }
        public int StudentsPageSize { get; set; }
    }
}
