using FluentValidation;
using Lesson6.Models.ViewModels;

namespace Lesson6.Models.FluentValidators
{
    public class UserFluentValidator : AbstractValidator<User>
    {
        public UserFluentValidator()
        {
            RuleFor(u => u.Email).EmailAddress().WithMessage("Emaili duz yaz!!");
            RuleFor(u => u.Pass).NotEmpty().WithMessage("required");
            RuleFor(u => u.Confirm).Equal(u => u.Pass);
        }
    }
}
