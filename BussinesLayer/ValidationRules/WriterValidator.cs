using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesLayer.ValidationRules
{
    public class WriterValidator : AbstractValidator<Writer>
    {
        public WriterValidator()
        {
            RuleFor(x => x.WriterName).NotEmpty().WithMessage("Yazar adını boş geçemezsiniz");
            RuleFor(x => x.writerSurname).NotEmpty().WithMessage("Yazar Soyadını boş geçemezsinşz");
            RuleFor(x => x.WriterAbout).NotEmpty().WithMessage("Hakkında Kısmını boş geçemezsiniz");
            RuleFor(x => x.WriterTitle).NotEmpty().WithMessage("unvan Kısmını boş geçemezsiniz");
            RuleFor(x => x.WriterName).MinimumLength(3).WithMessage("Lütfen en az 2 karakter griişi yapın");
            RuleFor(x => x.writerSurname).MaximumLength(50).WithMessage("Lütfen 50 karakterden fazla değer girişi ypmayın");

        }
    }
}
