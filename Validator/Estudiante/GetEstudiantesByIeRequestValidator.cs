using FluentValidation;
using Messages;
using Validator.Base;
using Siagie.Matricula.Migracion.Dto.Estudiante;
using Transversal.Functions;

namespace Validator.Estudiante;

public class GetEstudiantesByIeRequestValidator : AbstractValidator<GetEstudiantesByIeRequest>
{
    // validation
    public GetEstudiantesByIeRequestValidator()
    {
        RuleFor(x => x)
       .Must((model, propertyValue, context) =>
       {
           model.CodigoModular = model.CodigoModular.TrimUpper();
           model.Anexo = model.Anexo.TrimUpper();
           model.GradoId = model.GradoId.TrimUpper();
           return true;
       });
        Include(new InstitucionEducativaBaseRequestDtoValidator());
        Include(new InstitucionEducativaAnioBaseRequestDtoValidator());

        RuleFor(x => x.GradoId)
       .Cascade(CascadeMode.Stop)
       .NotNull().WithMessage(GlobalMessages.Require.IdGrado)
       .Must(p => GlobalValidator<string>.IsNotNullOrEmpty(p)).WithMessage(GlobalMessages.Require.IdGrado)
       .Must(p => GlobalValidator<string>.IsGrado(p)).WithMessage(GlobalMessages.ValidFormat.IdGrado)
       ;
    }
}