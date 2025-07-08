using CafeApi.WebApi.Entities;
using FluentValidation;

namespace CafeApi.WebApi.ValidationRules
{
    public class ProductValidator : AbstractValidator<Product>
    {
        public ProductValidator()
        {
            RuleFor(x => x.ProductName).NotEmpty().WithMessage("Ürün adını boş geçmeyin");
            RuleFor(x => x.ProductName).MinimumLength(2).WithMessage("En az iki karakter girin");
            RuleFor(x => x.ProductName).MaximumLength(50).WithMessage("En fazla 50 karakter girin");

            RuleFor(x => x.Price).NotEmpty().WithMessage("Fiyat boş olamaz");
            RuleFor(x => x.Price).GreaterThan(0).WithMessage("Fiyat negatif olamaz");
            RuleFor(x => x.Description).NotEmpty().WithMessage("Açıklama boş olamaz");
            
        }
    }
}
