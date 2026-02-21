using Madrasty.Core.Features.Students.Results;
using Madrasty.Core.Wrappers;
using Madrasty.Domain.Helpers;
using MediatR;

namespace Madrasty.Core.Features.Students.Queries.Models
{
    public class GetStudentPaginatedListQuery : IRequest<PaginatedResult<StudentPaginatedListResponse>>
    {
        public int PageNumber { get; set; }
        public int PageSize { get; set; }
        public StudentOrderdingEnum OrderBy { get; set; }
        public string? Search { get; set; }
    }
}
