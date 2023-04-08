using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitectDemo.Domain.Entities
{
    public class Transaction
    {
        public  int Id { get; set; }
        public required int AccountId { get; set; }
        public required decimal Amount { get; set; }
    }
}
