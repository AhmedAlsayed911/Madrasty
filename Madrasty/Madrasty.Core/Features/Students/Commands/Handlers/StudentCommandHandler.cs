using AutoMapper;
using Madrasty.Core.Bases;
using Madrasty.Core.Features.Students.Commands.Models;
using Madrasty.Domain.Entities;
using Madrasty.Service.Abstracts;
using MediatR;

namespace Madrasty.Core.Features.Students.Commands.Handlers
{
    public class StudentCommandHandler(IStudentService studentService, IMapper mapper)
        : ResponseHandler, IRequestHandler<AddStudentCommand, Response<string>>,
        IRequestHandler<EditStudentCommand, Response<string>>,
        IRequestHandler<DeleteStudentCommand, Response<string>>
    {
        public async Task<Response<string>> Handle(AddStudentCommand request, CancellationToken cancellationToken)
        {
            var studentMapper = mapper.Map<Student>(request);
            var result = await studentService.AddStudentAsync(studentMapper);

            if (result == "Success")
                return Created("Added Successfully");
            else
                return BadRequest<string>();
        }

        public async Task<Response<string>> Handle(EditStudentCommand request, CancellationToken cancellationToken)
        {
            var checkStudent = await studentService.GetStudentByIdAsync(request.Id);
            if (checkStudent is null) return NotFound<string>("Stundent Not Found");

            var studentMapper = mapper.Map<Student>(request);

            var result = await studentService.EditAsync(studentMapper);

            if (result == "Success")
                return Success($"Student with ID : {studentMapper.StudID} Updated Successfully");

            else return BadRequest<string>();
        }

        public async Task<Response<string>> Handle(DeleteStudentCommand request, CancellationToken cancellationToken)
        {
            var checkStudent = await studentService.GetStudentByIdAsync(request.Id);
            if (checkStudent is null) return NotFound<string>("Student Not Found");

            var result = await studentService.DeleteAsync(checkStudent);

            if (result == "Success")
                return Success($"Student with ID : {request.Id} Deleted Successfully");
            else return BadRequest<string>();
        }
    }
}
