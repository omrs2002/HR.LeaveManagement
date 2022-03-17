using AutoMapper;
using HR.LeaveManagement.Application.Features.LeaveTypes.Requests.Commands;
using HR.LeaveManagement.Domain;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using HR.LeaveManagement.Application.Persistence.Contracts;
using HR.LeaveManagement.Application.DTOs.LeaveType.Validators;
using HR.LeaveManagement.Application.Exceptions;
using HR.LeaveManagement.Application.Responses;
using FluentValidation;
using System.Linq;

namespace HR.LeaveManagement.Application.Features.LeaveTypes.Handlers.Commands
{
    public class UpdateLeaveTypeCommandHandler : IRequestHandler<UpdateLeaveTypeCommand, Unit>
    {
        //private readonly IUnitOfWork _unitOfWork;
        private readonly ILeaveTypeRepository _leaveTypeRepository;
        private readonly IMapper _mapper;

        public UpdateLeaveTypeCommandHandler(
            IMapper mapper,
            //IUnitOfWork unitOfWork,
            ILeaveTypeRepository leaveTypeRepository
        )
        {
            //_unitOfWork = unitOfWork;
            _leaveTypeRepository = leaveTypeRepository;
            _mapper = mapper;
        }

        public async Task<Unit> Handle(UpdateLeaveTypeCommand request, CancellationToken cancellationToken)
        {
            //throw new NotImplementedException();
            //var validator = new UpdateLeaveTypeDtoValidator();
            //var validationResult = await validator.ValidateAsync(request.LeaveTypeDto);

            //if (validationResult.IsValid == false)
            //    throw new ValidationException(validationResult);

            //var leaveType = await _unitOfWork.LeaveTypeRepository.Get(request.LeaveTypeDto.Id);

            //if (leaveType is null)
            //    throw new NotFoundException(nameof(leaveType), request.LeaveTypeDto.Id);

            //_mapper.Map(request.LeaveTypeDto, leaveType);

            //await _unitOfWork.LeaveTypeRepository.Update(leaveType);
            //await _unitOfWork.Save();

            //return Unit.Value;
            var response = new BaseCommandResponse();
            var validator = new UpdateLeaveTypeDtoValidator();
            var validationResult = await validator.ValidateAsync(request.LeaveTypeDto, cancellationToken);

            if (validationResult.IsValid == false)
            {
                response.Success = false;
                response.Message = "Update failed";
                response.Errors = validationResult.Errors.Select(q => q.ErrorMessage).ToList();

            }
            else
            {
                var leaveType = _mapper.Map<Domain.LeaveType>(request.LeaveTypeDto);
                await _leaveTypeRepository.Update(leaveType);
                response.Success = true;
                response.Message = "Update Successful";
                response.Id = leaveType.Id;
            }

            return Unit.Value;

        }
    }
}
