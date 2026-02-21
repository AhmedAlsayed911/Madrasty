using Madrasty.Core.Bases;
using Madrasty.Core.Features.Students.Results;
using Madrasty.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Madrasty.Core.Features.Students.Queries.Models
{
    public class GetStudentByIdQuery : IRequest<Response<SingleStudentResponse>>
    {
        public GetStudentByIdQuery(int id)
        {
            Id = id;
        }
        public int Id { get;}
    }
}
