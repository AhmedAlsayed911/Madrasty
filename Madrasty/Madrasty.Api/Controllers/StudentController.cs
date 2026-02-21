using Madrasty.Api.Base;
using Madrasty.Core.Features.Students.Commands.Models;
using Madrasty.Core.Features.Students.Queries.Models;
using Madrasty.Domain.AppMetaData;
using Microsoft.AspNetCore.Mvc;

namespace Madrasty.Api.Controllers
{
    [ApiController]
    public class StudentController : AppControllerBase
    {

        [HttpGet(Router.StudentRouting.List)]
        public async Task<IActionResult> GetStudentList()
        {
            var response = await Mediator.Send(new GetStudentListQuery());
            return Ok(response);
        }

        [HttpGet(Router.StudentRouting.PaginatedList)]
        public async Task<IActionResult> GetStudentListPaginated([FromQuery] GetStudentPaginatedListQuery query)
        {
            var response = await Mediator.Send(query);
            return Ok(response);
        }

        [HttpGet(Router.StudentRouting.GetById)]
        public async Task<IActionResult> GetStudent(int id)
        {
            //var respone = await Mediator.Send(new GetStudentByIdQuery(id));

            return NewResult(await Mediator.Send(new GetStudentByIdQuery(id)));
        }

        [HttpPost(Router.StudentRouting.Create)]
        public async Task<IActionResult> Create([FromBody] AddStudentCommand command)
        {
            var response = await Mediator.Send(command);

            return NewResult(response);
        }

        [HttpPut(Router.StudentRouting.Edit)]
        public async Task<IActionResult> Edit([FromBody] EditStudentCommand command)
        {
            var response = await Mediator.Send(command);

            return NewResult(response);
        }

        [HttpDelete(Router.StudentRouting.Delete)]
        public async Task<IActionResult> Delete([FromRoute] int id)
        {
            return NewResult(await Mediator.Send(new DeleteStudentCommand(id)));
        }

    }
}
