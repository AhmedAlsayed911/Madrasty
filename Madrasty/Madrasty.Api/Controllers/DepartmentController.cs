using Madrasty.Api.Base;
using Madrasty.Core.Features.Department.Queries.Models;
using Madrasty.Domain.AppMetaData;
using Microsoft.AspNetCore.Mvc;

namespace Madrasty.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentController : AppControllerBase
    {
        [HttpGet(Router.DepartmentRouting.GetById)]
        public async Task<IActionResult> GetDepartmentById([FromQuery] GetDepartmentByIdQuery query)
        {
            var result = await Mediator.Send(query);
            return NewResult(result);
        }
    }
}