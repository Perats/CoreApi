using CoreApi.Models;
using FluentValidation;

namespace CoreApi.Validators
{
    public class UserValidator : AbstractValidator<UserModel>
    {
        public UserValidator()
        {
            RuleFor(_ => _.FirstName).MinimumLength(3).MaximumLength(20);
            RuleFor(_ => _.LastName).MinimumLength(3).MaximumLength(20);
            RuleFor(_ => _.DeviceModel).NotNull();
        }
    }
}
