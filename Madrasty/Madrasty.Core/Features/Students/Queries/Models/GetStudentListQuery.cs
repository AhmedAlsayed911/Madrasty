using Madrasty.Core.Bases;
using Madrasty.Core.Features.Students.Results;
using Madrasty.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Madrasty.Core.Features.Students.Queries.Models
{
    public class GetStudentListQuery : IRequest<Response<List<StudentListResponse>>>
    {

    }
}
