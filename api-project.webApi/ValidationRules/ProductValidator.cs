using api_project.webApi.Entities;
using FluentValidation;

namespace api_project.webApi.ValidationRules
{
    public class ProductValidator:AbstractValidator<Product>
    {
        public ProductValidator()
        {
            RuleFor(x => x.ProductName).NotEmpty().WithMessage("name required!");
            RuleFor(x => x.ProductName).MinimumLength(2).WithMessage("at least 2 characters!");
            RuleFor(x => x.ProductName).MaximumLength(50).WithMessage("max 50 characters!");

            RuleFor(x => x.Price).NotEmpty().WithMessage("price required!")
                .LessThan(0).WithMessage("price can't be 0!");

            RuleFor(x => x.ProductDescription).NotEmpty().WithMessage("description required!");
        }
    }
}
