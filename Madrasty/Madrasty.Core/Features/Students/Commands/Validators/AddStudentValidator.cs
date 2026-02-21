using FluentValidation;
using Madrasty.Core.Features.Students.Commands.Models;
using Madrasty.Service.Abstracts;

namespace Madrasty.Core.Features.Students.Commands.Validators
{
    public class AddStudentValidator : AbstractValidator<AddStudentCommand>
    {
        private readonly IStudentService _studentService;
        public AddStudentValidator(IStudentService studentService)
        {
            _studentService = studentService;
            ApplyValidationsRules();
            ApplyCustomValidationsRules();
        }

        public void ApplyValidationsRules()
        {
            RuleFor(x => x.Name)
                .NotEmpty().WithMessage("{PropertyName} Name cannot be Empty")
                .NotNull().WithMessage("{PropertyName} Name cannot be Null")
                .MaximumLength(10).WithMessage("{PropertyValue} Max Length is 100 Characters");

            RuleFor(x => x.Address)
                .NotEmpty().WithMessage("{PropertyName} Name cannot be Empty")
                .NotNull().WithMessage("{PropertyName} Name cannot be Null")
                .MaximumLength(100).WithMessage("{PropertyValue} Max Length is 100 Characters");
        }

        public void ApplyCustomValidationsRules()
        {
            RuleFor(x => x.Name)
                .MustAsync(async (key, CancellationToken) => !await _studentService.IsNameExist(key))
                .WithMessage("Name is Already Exist");
        }
    }
}
