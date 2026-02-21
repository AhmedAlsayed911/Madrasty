using FluentValidation;
using Madrasty.Core.Features.Students.Commands.Models;
using Madrasty.Service.Abstracts;

namespace Madrasty.Core.Features.Students.Commands.Validators
{
    public class EditStudentValidator : AbstractValidator<EditStudentCommand>
    {
        private readonly IStudentService studentService;

        public EditStudentValidator(IStudentService studentService)
        {
            this.studentService = studentService;
            ApplyValidationRules();
            ApplyCustomValidationsRules();
        }

        public void ApplyValidationRules()
        {
            RuleFor(x => x.Name)
                .NotEmpty().WithMessage("{PropertyName} Name cannot be Empty")
                .NotNull().WithMessage("{PropertyName} Name cannot be Null")
                .MaximumLength(100).WithMessage("{PropertyValue} Max Length is 100 Characters");

            RuleFor(x => x.Address)
                .NotEmpty().WithMessage("{PropertyName} Name cannot be Empty")
                .NotNull().WithMessage("{PropertyName} Name cannot be Null")
                .MaximumLength(100).WithMessage("{PropertyValue} Max Length is 100 Characters");
        }

        public void ApplyCustomValidationsRules()
        {
            RuleFor(x => x.Name)
                .MustAsync(async (model, Key, CancellationToken) => !await studentService.IsNameExistExcludeSelf(Key, model.Id))
                .WithMessage("Name is Already Exist with Another Student");
        }
    }
}
