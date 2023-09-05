using FluentValidation;
using Messages;
using Siagie.Matricula.Migracion.Dto.Base;
using Transversal.Functions;

namespace Validator.Base
{
    public class InstitucionEducativaBaseRequestDtoValidator : AbstractValidator<InstitucionEducativaBaseRequestDto>
    {
        public InstitucionEducativaBaseRequestDtoValidator()
        {
            RuleFor(x => x)
                  .Must((model, propertyValue, context) =>
                  {
                      model.CodigoModular = model.CodigoModular.TrimUpper();
                      model.Anexo = model.Anexo.TrimUpper();
                      return true;
                  });

            RuleFor(x => x.CodigoModular)
                .Cascade(CascadeMode.Stop)
                .NotNull().WithMessage(GlobalMessages.Required.CodigoModular)
                .Must(p => GlobalValidator<string>.IsNotNullOrEmpty(p)).WithMessage(GlobalMessages.Required.CodigoModular)
                .Must(p => GlobalValidator<string>.IsCodigoModular(p)).WithMessage(GlobalMessages.Format.CodigoModular)
                ;
            RuleFor(x => x.Anexo)
              .Cascade(CascadeMode.Stop)
              .NotNull().WithMessage(GlobalMessages.Required.Anexo)
              .Must(p => GlobalValidator<string>.IsNotNullOrEmpty(p)).WithMessage(GlobalMessages.Required.Anexo)
              .Must(p => GlobalValidator<string>.IsAnexo(p)).WithMessage(GlobalMessages.Format.Anexo)
              ;
        }
    }
}