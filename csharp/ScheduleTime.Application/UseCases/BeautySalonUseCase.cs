using AutoMapper;
using FluentValidation;
using ScheduleTime.Application.Exceptions;
using ScheduleTime.Application.Interfaces;
using ScheduleTime.CrossCutting.DTOs.V1;
using ScheduleTime.Domain.Entities;

namespace ScheduleTime.Application.UseCases
{
    public class BeautySalonUseCase : IBeautySalonUseCase
    {
        private readonly IMapper _mapper;
        private readonly IValidator<BeautySalon> _validator;

        private BeautySalonUseCase()
        {
            if (_mapper == null) throw new ArgumentNullException(nameof(_mapper));
            if (_validator == null) throw new ArgumentNullException(nameof(_validator));
        }

        public BeautySalonUseCase(IMapper mapper, IValidator<BeautySalon> validator)
        {
            _mapper = mapper;
            _validator = validator;
        }

        public BeautySalon ValidDataAndConvertDTOInEntity(BeautySalonDTO beautySalonDTO)
        {
            var beautySalon = _mapper.Map<BeautySalon>(beautySalonDTO);
            var result = _validator.Validate(beautySalon);
            if (!result.IsValid)
            {
                var erros = result.Errors.Select(e => e.ErrorMessage).ToList();
                throw new ValidationBusinessException(erros);
            }
            return beautySalon;
        }
    }
}
