using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.CQRS.Commands.Response
{
    public class ReserveBookCommandResponse
    {
        public string Id { get; set; }
        public bool IsReserved { get; set; }
        public bool IsSuccess { get; set; }
    }
}
