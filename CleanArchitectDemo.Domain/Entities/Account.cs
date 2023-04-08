using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitectDemo.Domain.Entities
{
    public class Account
    {
        public  int AccountId { get; set; }
        public required string Name { get; set; }
        public  required string AccountNumber { get; set; } 
        public required decimal Balance { get; set; }
    }
}
    