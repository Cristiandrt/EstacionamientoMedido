using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using EstacionamientoMedido.Modelos;


namespace EstacionamientoMedido.Validaciones
{
    public class VehiculoValidator:AbstractValidator<Vehiculo>
    {
        public VehiculoValidator()
        {
            RuleFor(x => x.Marca)
                .NotEmpty()
                .NotNull()
                .MinimumLength(3)
                .MaximumLength(20);

            RuleFor(x => x.Color)
                .NotEmpty()
                .NotNull()
                .MinimumLength(4)
                .MaximumLength(20);

            RuleFor(x => x.Patente)
                .NotEmpty()
                .NotNull()
                .Length(7);

            RuleFor(x => x.Modelo)
                .NotEmpty()
                .NotNull()
                .Matches(@"^\d{4}$");
        } 
    }

}
