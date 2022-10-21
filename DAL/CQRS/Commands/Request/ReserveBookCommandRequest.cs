using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.CQRS.Commands.Request
{
    public class ReserveBookCommandRequest
    {
        public string Id { get; set; }
        public bool IsReserved { get; set; }
        public Guid BookingNumber { get; set; }
    }
}
