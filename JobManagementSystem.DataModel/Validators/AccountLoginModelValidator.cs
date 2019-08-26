using System;
using JobManagementSystem.DataModel.Models.AccountModels;
using FluentValidation;
using JobManagementSystem.Common;
using JobManagementSystem.Common.Resources;

namespace JobManagementSystem.DataModel.Validators
{
    class AccountLoginModelValidator : AbstractValidator<AccountLoginModel>
    {
        public AccountLoginModelValidator()
        {
            RuleFor(x => x.Password).NotEmpty().WithMessage(AccountResource.PasswordNotEmpty);
            //RuleFor(x => x.Password).MaximumLength(32).WithMessage(AccountResource.PasswordLenLimit);
            RuleFor(x => x.Email).Matches(RegexConfigs.RegexMail).WithMessage(AccountResource.EmailFormatInValid);
        }
    }
}
