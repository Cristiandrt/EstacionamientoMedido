using EstacionamientoMedido.Modelos;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstacionamientoMedido.Validaciones
{
    public class ClienteValidator:AbstractValidator<Cliente>
    {
        public ClienteValidator()
        {
            
                RuleFor(x => x.Nombre)
                    .NotEmpty()
                    .NotNull()
                    .MinimumLength(2)
                    .MaximumLength(50);

                RuleFor(x => x.Apellido)
                    .NotEmpty()
                    .NotNull()
                    .MinimumLength(2)
                    .MaximumLength(50);

                RuleFor(x => x.DNI)
                    .NotEmpty()
                    .NotNull()
                    .Matches(@"^\d{8}$").WithMessage("El DNI debe contener 8 dígitos (sin puntos)");

                RuleFor(x => x.Telefono)
                    .NotEmpty()
                    .NotNull()
                    .Matches(@"^\d{10}$").WithMessage("El teléfono debe contener exactamente 10 dígitos");

                RuleFor(x => x.Correo)
                    .NotEmpty()
                    .NotNull()
                    .EmailAddress().WithMessage("El correo electrónico no es válido");
           
        }

    }
}
