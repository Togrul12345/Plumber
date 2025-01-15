using FluentValidation;
using Plumber.Bl.Dtos;
using Plumber.Bl.Services.Abstraction;
using Plumber.Bl.Services.Implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plumber.Bl.Validators
{
    public class CreateAdminUserValidator:AbstractValidator<CreateAdminUserDto>
    {
        

        public CreateAdminUserValidator()
        {
            RuleFor(a => a.FirstName).MaximumLength(50).WithMessage("max length must must be 50").MinimumLength(3).WithMessage("min length can be 3");
            RuleFor(a=>a.LastName).MaximumLength(50).WithMessage("max length must must be 50").MinimumLength(3).WithMessage("min length can be 3");
            RuleFor(a => a.Email).MaximumLength(50).WithMessage("max length must must be 50").MinimumLength(3).WithMessage("min length can be 3");
            RuleFor(a => a.UserName).MaximumLength(50).WithMessage("max length must must be 50").MinimumLength(3).WithMessage("min length can be 3");
            RuleFor(a => a.Password).Equal(a => a.ConfirmPassword).WithMessage("Password must be equal to confirmpassword");
        }
    }
}
