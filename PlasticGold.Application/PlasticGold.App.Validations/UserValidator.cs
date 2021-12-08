using FluentValidation;
using PlasticGold.Services.Model;
using PlasticGold.Application.Messages;

namespace PlasticGold.App.Validations
{
    public class UserValidator : AbstractValidator<UserRequest>
    {
        public UserValidator()
        {
            RuleFor(m => m.Name)
                .NotEmpty()
                    .WithMessage("Field Name must not be null or empty")
                .MaximumLength(50)
                    .WithMessage("Field Name must be less than 50 ")
                .MinimumLength(5)
                    .WithMessage("Field Name must have 5 legth at minimum");

            RuleFor(l => l.LastName)
                .NotEmpty()
                    .WithMessage("Field Name must not be null or empty")
                .MaximumLength(40)
                    .WithMessage("Field Name must be less than 50 ")
                .MinimumLength(5)
                    .WithMessage("Field Name must have 5 legth at minimum");

            RuleFor(c => c.ContactNumber)
               .NotEmpty()
                   .WithMessage("Field Name must not be null or empty")
               .MaximumLength(30)
                   .WithMessage("Field Name must be less than 50 ");

            RuleFor(j => j.Job)
                .NotEmpty()
                    .WithMessage("Field Job must not be null or empty ");

        }

    }
}
