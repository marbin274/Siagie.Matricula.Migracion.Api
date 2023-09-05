using FluentValidation;
using Messages;
using Siagie.Matricula.Migracion.Dto.Base;

namespace Validator.Base
{
    public class InstitucionEducativaAnioBaseRequestDtoValidator : AbstractValidator<InstitucionEducativaAnioBaseRequestDto>
    {
        public InstitucionEducativaAnioBaseRequestDtoValidator()
        {
            RuleFor(x => x.Anio)
                 .Cascade(CascadeMode.Stop)
                 .NotNull().WithMessage(GlobalMessages.Required.Anio)
                 .Must(p => GlobalValidator<short>.IsValidAnioAcademico(p)).WithMessage(GlobalMessages.Format.Anio)
                 ;
        }
    }
}