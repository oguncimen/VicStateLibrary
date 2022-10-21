using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class Books
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public bool IsReserved { get; set; }
    }
}
