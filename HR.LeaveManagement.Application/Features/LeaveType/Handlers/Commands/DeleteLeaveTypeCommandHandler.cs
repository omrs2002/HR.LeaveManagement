using AutoMapper;
using HR.LeaveManagement.Application.Exceptions;
using HR.LeaveManagement.Application.Features.LeaveTypes.Requests.Commands;
using HR.LeaveManagement.Application.Persistence.Contracts;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace HR.LeaveManagement.Application.Features.LeaveTypes.Handlers.Commands
{
    public class DeleteLeaveTypeCommandHandler : IRequestHandler<DeleteLeaveTypeCommand>
    {
        //private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public DeleteLeaveTypeCommandHandler(
            //IUnitOfWork unitOfWork,
            IMapper mapper)
        {
            //_unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<Unit> Handle(DeleteLeaveTypeCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
            //var leaveType = await _unitOfWork.LeaveTypeRepository.Get(request.Id);

            //if (leaveType == null)
            //    throw new NotFoundException(nameof(LeaveType), request.Id);

            //await _unitOfWork.LeaveTypeRepository.Delete(leaveType);
            //await _unitOfWork.Save();

            //return Unit.Value;
        }
    }
}
