using DAL.CQRS.Commands.Request;
using DAL.CQRS.Commands.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.CQRS.Handlers.CommandHandlers
{
    public class ReserveBookCommandHandler
    {
        public ReserveBookCommandResponse ReserveBook(ReserveBookCommandRequest reserveBookCommandRequest)
        {
            return new ReserveBookCommandResponse
            {
                Id = reserveBookCommandRequest.Id,
                IsReserved = reserveBookCommandRequest.IsReserved,
                IsSuccess = true,
            };
        }
    }
}
